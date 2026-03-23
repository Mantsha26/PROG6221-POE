using System;
using System.Threading.Tasks;

public static class ConsoleUI
{
    public static string[] AsciiLogo =
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

    public static void ClearWithHeader()
    {
        Console.Clear();
        DisplayAsciiArt(AsciiLogo, ConsoleColor.Cyan);
        Console.WriteLine();
    }

    public static void DisplayAsciiArt(string[] art, ConsoleColor color)
    {
        Console.ForegroundColor = color;

        foreach (var line in art)
            Console.WriteLine(line);

        Console.ResetColor();
    }

    public static async Task TypewriterEffect(string text, int delay = 50)
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

    public static void DisplayError(string msg)
    {
        WriteLineColored($"❌ {msg}", ConsoleColor.Red);
    }

    public static void DisplayWarning(string msg)
    {
        WriteLineColored($"⚠ {msg}", ConsoleColor.Yellow);
    }

    public static void DisplayInfo(string msg)
    {
        WriteLineColored($"ℹ {msg}", ConsoleColor.Blue);
    }

    public static string GetUserInput(string prompt)
    {
        WriteColored(prompt, ConsoleColor.Green);
        var input = Console.ReadLine();
        return input ?? string.Empty;
    }

    public static void Pause(string msg)
    {
        WriteLineColored(msg, ConsoleColor.DarkGray);
        Console.ReadKey();



        ERTYU
    }
}