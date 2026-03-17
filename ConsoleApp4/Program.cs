using System;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.Title = "Cybersecurity Awareness Bot";
        Console.OutputEncoding = Encoding.UTF8;

        var bot = new ChatBot();

        try
        {
            ConsoleUI.ClearWithHeader();

            bot.PlayVoiceGreeting();

            await bot.GreetUser();

            await bot.StartConversation();
        }
        catch (Exception ex)
        {
            ConsoleUI.DisplayError($"Error: {ex.Message}");
        }

        ConsoleUI.Pause("Press any key to exit...");
    }
}
