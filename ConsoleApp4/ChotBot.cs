using System;
using System.Threading.Tasks;
using System.Media;
using System.Speech.Synthesis;

public class ChatBot
{
    private User currentUser;
    private ResponseSystem responseSystem;
    private bool isRunning = true;

    public string BotName { get; set; } = "CyberGuard";

    public ChatBot()
    {
        responseSystem = new ResponseSystem();
    }

    public void PlayVoiceGreeting()
    {
        try
        {
            using (SoundPlayer player = new SoundPlayer("greeting.wav"))
            {
                SpeechSynthesizer _ss = new SpeechSynthesizer();
                _ss.Speak("Hi ! Welcome to the Cybersecurity Awareness Bot. I'm here to help you stay safe online");
            }
        }
        catch
        {
            ConsoleUI.DisplayWarning("Voice greeting not available.");
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

        ConsoleUI.DrawLine();
    }

    public async Task StartConversation()
    {
        while (isRunning)
        {
            ConsoleUI.WriteColored($"{currentUser.Name} > ", ConsoleColor.Cyan);

            string input = Console.ReadLine() ?? string.Empty;

            if (string.IsNullOrWhiteSpace(input))
            {
                ConsoleUI.DisplayWarning("Please type a question.");
                continue;
            }

            if (input.ToLower() == "exit")
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

    private async Task ExitBot()
    {
        ConsoleUI.DrawLine('=');

        await ConsoleUI.TypewriterEffect(
            $"Goodbye {currentUser.Name}! Stay safe online! 🔐",
            40);

        ConsoleUI.DrawLine('=');
    }
}
