using System;
using System.Collections.Generic;

public class ResponseSystem
{
    private Dictionary<string, string[]> responses;
    private Random rand = new Random();

    public string DefaultResponse { get; set; } =// Default response when no keywords are matched
        "I didn’t quite understand that. Please ask a cybersecurity question like password safety, phishing, or safe browsing.";

    public ResponseSystem()
    {
        responses = new Dictionary<string, string[]>(StringComparer.OrdinalIgnoreCase)// Initialize the response dictionary with common user inputs and corresponding responses
        {
            ["hello"] = new[]
            {
                "Hello! How can I help you stay safe online?",
                "Hi there! Ask me anything about cybersecurity."
            },

            ["hi"] = new[]
            {
                "Hello! How can I assist you today?",
                "Hi! Ready to learn about cybersecurity?"
            },

            ["how are you"] = new[]
            {
                "I'm doing great! Ready to help you stay safe online.",
                "I'm functioning perfectly! How can I help?"
            },

            ["purpose"] = new[]
            {
                "My purpose is to help users understand cybersecurity threats.",
                "I teach people about password safety, phishing attacks, and safe browsing."
            },

            ["password"] = new[]
            {
                "Use strong passwords with at least 12 characters including letters, numbers, and symbols.",
                "Never reuse passwords across multiple websites and consider using a password manager."
            },

            ["phishing"] = new[]
            {
                "Phishing emails try to trick you into giving personal information.",
                "Always check the sender email and avoid clicking suspicious links."
            },

            ["safe browsing"] = new[]
            {
                "Always look for HTTPS in website addresses.",
                "Avoid downloading files from unknown websites."
            },

            ["malware"] = new[]
            {
                "Malware is harmful software that can damage your computer or steal data.",
                "Install antivirus software and keep your system updated."
            },

            ["social engineering"] = new[]
            {
                "Social engineering tricks people into revealing confidential information.",
                "Never share passwords or sensitive data with strangers."
            },

            ["thanks"] = new[]
            {
                "You're welcome! Stay safe online.",
                "Happy to help! Let me know if you have more cybersecurity questions."
            },

            ["help"] = new[]
            {
                "You can ask me about password safety, phishing attacks, safe browsing, malware, or social engineering.",
                "Try asking about cybersecurity topics like passwords or phishing."
            }
        };
    }

    public string GetResponse(string input)// Method to get a response based on user input
    {
        if (string.IsNullOrWhiteSpace(input))// Handle empty or whitespace input
        {
            return DefaultResponse;
        }

        string cleaned = input.Trim().ToLower();// Clean the input remove spaces and convert to lowercase for easier matching

        // Ignore programming code inputs
        if (cleaned.Contains("using ") ||
            cleaned.Contains("class ") ||
            cleaned.Contains("{") ||
            cleaned.Contains("}") ||
            cleaned.Contains("console.") ||
            cleaned.Contains("static"))
        {
            return "It looks like you entered programming code. Please ask a cybersecurity question instead.";
        }
        else if (responses.Count > 0)
        {
            // Use a while loop to iterate through response keys
            var keys = new List<string>(responses.Keys);//Get the keys from the responses dictionary
            int i = 0;

            while (i < keys.Count)// Loop through the keys to find a match in the cleaned input
            {
                string key = keys[i];

                if (cleaned.Contains(key))// If a match is found, select a random response from the corresponding array and return it
                {
                    var options = responses[key];
                    return options[rand.Next(options.Length)];
                }

                i++;
            }
        }

        return DefaultResponse;// If no matches are found, return the default response
    }
}