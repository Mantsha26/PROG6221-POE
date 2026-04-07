using System;
using System.Threading.Tasks;

public static class ConsoleUI
{
    public static string[] AsciiLogo =// ASCII art logo for the chatbot, displayed at the top of the console interface
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

    public static void ClearWithHeader()// Clears the console and displays the ASCII art logo at the top, creating a consistent header for the chatbot interface
    {
        Console.Clear();
        DisplayAsciiArt(AsciiLogo, ConsoleColor.Cyan);
        Console.WriteLine();
    }

    public static void DisplayAsciiArt(string[] art, ConsoleColor color)// Displays the provided ASCII art in the specified color, enhancing the visual appeal of the console interface
    {
        Console.ForegroundColor = color;

        foreach (var line in art)
            Console.WriteLine(line);

        Console.ResetColor();
    }

    public static async Task TypewriterEffect(string text, int delay = 50)// Simulates a typewriter effect by printing each character of the provided text with a delay, creating a dynamic and engaging user experience when the chatbot responds
    {
        foreach (char c in text)
        {
            Console.Write(c);
            await Task.Delay(delay);
        }

        Console.WriteLine();
    }

    public static void WriteColored(string text, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.Write(text);
        Console.ResetColor();
    }

    public static void WriteLineColored(string text, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(text);
        Console.ResetColor();
    }

    public static void DrawLine(char c = '═')
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
        WriteColored(prompt, ConsoleColor.Green);// Prompts the user for input with a colored message, enhancing the user interface and making it clear when input is expected
        var input = Console.ReadLine();
        return input ?? string.Empty;
    }

    public static void Pause(string msg)
    {
        WriteLineColored(msg, ConsoleColor.DarkGray);
        Console.ReadKey();

    }
}