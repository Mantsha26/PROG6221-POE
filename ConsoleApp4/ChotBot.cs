using System;
using System.IO;
using System.Media;
using System.Threading.Tasks;
using System.Linq;

public class ChatBot
{
    private User currentUser;
    private ResponseSystem responseSystem;
    private bool isRunning = true;

    public string BotName { get; set; } = "CyberGuard";

    public ChatBot()
    {
        responseSystem = new ResponseSystem();

        // Play greeting audio automatically when chatbot starts
        PlayVoiceGreeting();
    }

    public void PlayVoiceGreeting()
    {
        // Try to locate and play a generated TTS file from common locations.
        PlayMusic();
    }

    public static void PlayMusic()
    {
        string[] candidateDirs = new[]// common locations to check for the greeting audio file
        {
            AppDomain.CurrentDomain.BaseDirectory,
            Environment.CurrentDirectory,
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "resources"),
            Path.Combine(Environment.CurrentDirectory, "resources")
        };

        string[] patterns = new[] { "greeting.wav", "*.wav" };

        string found = null;

        foreach (var dir in candidateDirs)
        {
            try
            {
                if (!Directory.Exists(dir))
                    continue;

                foreach (var pattern in patterns)
                {
                    var file = Directory.EnumerateFiles(dir, pattern, SearchOption.TopDirectoryOnly).FirstOrDefault();
                    if (!string.IsNullOrEmpty(file))
                    {
                        found = file;
                        break;
                    }
                }

                if (found != null)
                    break;
            }
            catch
            {
                // ignore inaccessible dirs
            }
        }

        if (found == null)
        {
            Console.WriteLine("Voice greeting file not found.");
            return;
        }

        try
        {
            using (var player = new SoundPlayer(found))
            {
                player.Load();
                player.PlaySync();
            }

            Console.WriteLine($"Playing voice greeting: {Path.GetFileName(found)}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Failed to play voice greeting: {ex.Message}");
        }
    }

    public async Task GreetUser()
    {
        Console.WriteLine();

        string name = ConsoleUI.GetUserInput("Enter your name: ");

        while (string.IsNullOrWhiteSpace(name))
        {
            ConsoleUI.DisplayError("Name cannot be empty.");
            name = ConsoleUI.GetUserInput("Enter your name: ");
        }

        currentUser = new User { Name = name };

        Console.WriteLine();

        await ConsoleUI.TypewriterEffect(
            $"Welcome {currentUser.Name}! I am {BotName}, your Cybersecurity Awareness Assistant.",
            40);

        ConsoleUI.DrawLine();

        ConsoleUI.DisplayInfo("You can ask about:");

        Console.WriteLine("• Password Safety");
        Console.WriteLine("• Phishing Attacks");
        Console.WriteLine("• Safe Browsing");
        Console.WriteLine("• Malware");
        Console.WriteLine("• Social Engineering");
        Console.WriteLine("• Exit");

        ConsoleUI.DrawLine();
    }

    public async Task StartConversation()
    {
        while (isRunning)// main conversation loop
        {
            ConsoleUI.WriteColored($"{currentUser.Name} > ", ConsoleColor.Cyan);

            string input = Console.ReadLine() ?? string.Empty;

            if (string.IsNullOrWhiteSpace(input))// handle empty input
            {
                ConsoleUI.DisplayWarning("Please type a question.");
                continue;
            }

            if (input.ToLower() == "exit") // allow user to exit the chatbot
            {
                await ExitBot();
                break;
            }

            currentUser.IncrementQuestionCount();

            string response = responseSystem.GetResponse(input);

            ConsoleUI.WriteColored($"{BotName} > ", ConsoleColor.Magenta);

            await ConsoleUI.TypewriterEffect(response, 30);

            Console.WriteLine();
        }
    }

    private async Task ExitBot() //method to exit the chatbot gracefully
    {
        ConsoleUI.DrawLine('=');

        await ConsoleUI.TypewriterEffect(
            $"Goodbye {currentUser.Name}! Stay safe online! 🔐",
            40);

        ConsoleUI.DrawLine('=');
    }
}

