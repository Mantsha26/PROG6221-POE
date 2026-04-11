using System;
using System.Threading.Tasks;

public static class ConsoleUI
{
    public static string[] AsciiLogo =// art logo for the chatbot, displayed at the top of the console interface
    {
        "╔════════════════════════════════════════════════════╗",
        "║      ██████╗ ██╗   ██╗██████╗ ███████╗██████╗     ║",
        "║     ██╔════╝ ╚██╗ ██╔╝██╔══██╗██╔════╝██╔══██╗    ║",
        "║     ██║       ╚████╔╝ ██████╔╝█████╗  ██████╔╝    ║",
        "║     ██║        ╚██╔╝  ██╔══██╗██╔══╝  ██╔══██╗    ║",
        "║     ╚██████╗    ██║   ██████╔╝███████╗██║  ██║    ║",
        "║      ╚═════╝    ╚═╝   ╚═════╝ ╚══════╝╚═╝  ╚═╝    ║",
        "║            CYBERSECURITY AWARENESS BOT 🔐         ║",
        "╚════════════════════════════════════════════════════╝"
    };

    public static void ClearWithHeader()// Clears the console and showsthe header/logo
    {
        Console.Clear();
        DisplayAsciiArt(AsciiLogo, ConsoleColor.Cyan);
        Console.WriteLine();
    }

    public static void DisplayAsciiArt(string[] art, ConsoleColor color)// displays art in a chosen color, used for the chatbot logo and any other decorative elements in the console interface
    {
        Console.ForegroundColor = color;

        foreach (var line in art)
            Console.WriteLine(line);

        Console.ResetColor();
    }

    public static async Task TypewriterEffect(string text, int delay = 50)// simulates typing effect by printing characters one at a time with a delay, 
    {
        foreach (char c in text)
        {
            Console.Write(c);
            await Task.Delay(delay);//delay between characters
        }

        Console.WriteLine();
    }

    public static void WriteColored(string text, ConsoleColor color)// Writes text in a specified color
    {
        Console.ForegroundColor = color;
        Console.Write(text);
        Console.ResetColor();
    }

    public static void WriteLineColored(string text, ConsoleColor color)// Writes a line of text in a specified color
    {
        Console.ForegroundColor = color;
        Console.WriteLine(text);
        Console.ResetColor();
    }

    public static void DrawLine(char c = '═')// horizontal line
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine(new string(c, 50));
        Console.ResetColor();
    }

    public static void DisplayError(string msg)// Displays an error message with a red color and an error icon, making it visually distinct and easily recognizable as an error
    {
        WriteLineColored($"❌ {msg}", ConsoleColor.Red);
    }

    public static void DisplayWarning(string msg)// Displays a warning message with a yellow color and a warning icon, making it visually distinct from errors and informational messages
    {
        WriteLineColored($"⚠ {msg}", ConsoleColor.Yellow);
    }

    public static void DisplayInfo(string msg)// Displays an informational message with a blue color and an info icon, making it visually distinct from errors and warnings
    {
        WriteLineColored($"ℹ {msg}", ConsoleColor.Blue);
    }

    public static string GetUserInput(string prompt)
    {
        WriteColored(prompt, ConsoleColor.Green);// Prompts the user for input with a colored message
        var input = Console.ReadLine();
        return input ?? string.Empty;// Returns empty string if input is null
    }

    public static void Pause(string msg)// Pauses the console and waits for the user to press a key, displaying a message in dark gray color to indicate that the program is waiting for user interaction
    {
        WriteLineColored(msg, ConsoleColor.DarkGray);
        Console.ReadKey();

    }
}