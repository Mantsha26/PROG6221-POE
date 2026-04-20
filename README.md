 Features
Feature	Description

Voice Greeting	Plays a .wav greeting audio file when the bot starts

User Personalization	Asks for user's name and uses it throughout the conversation

Keyword-Based Responses	Matches user input to predefined cybersecurity topics

Code Detection	Detects if user pastes code instead of asking questions

Typing Effect	Simulates realistic typing for bot responses

Colored Console UI	Uses color-coded messages for better readability

Question Tracking	Counts how many questions each user asks

Graceful Exit	Displays goodbye message when user types "exit"

 File Structure

CybersecurityBot/

├── Program.cs              # Entry point - Main() method

├── ChatBot.cs              # Core bot logic, conversation loop

├── ResponseSystem.cs       # Keyword matching & response generation

├── User.cs                 # User data model (name, question count)

├── ConsoleUI.cs            # UI helpers (colors, typing effect, prompts)

└──  greeting.wav        # Optional audio file for voice greeting


 Keyword Response System

Keyword	Response Topic

hello, hi	Greetings

how are you	Bot status

purpose	Bot's mission

password	Strong password tips

phishing	Email safety

safe browsing	HTTPS, safe downloads

malware	Harmful software protection

social engineering	Confidential data safety

thanks	Appreciation reply

help	Available topics list

 Class Responsibilities

Class	Responsibility

Program-	Entry point, exception handling, console setup

ChatBot-	Main conversation flow, user greeting, exit logic, audio playback

ResponseSystem-	Keyword matching, random response selection, code detection

User-	Stores name, first interaction time, question count (thread-safe)

ConsoleUI-	All console output: colors, typing effect, ASCII art, input prompts

 How to Run
 
Prerequisites
.NET SDK (6.0 or higher)

Windows (for System.Media.SoundPlayer audio support)

Steps

 1. Clone or create project directory

mkdir CybersecurityBot

cd CybersecurityBot

 2. Create console application

dotnet new console

 3. Add all .cs files (Program.cs, ChatBot.cs, ResponseSystem.cs, User.cs, ConsoleUI.cs)

 4. (Optional) Add greeting.wav to resources folder

 5. Build and run

dotnet build

dotnet run

Sample Interaction

text

Enter your name: Alice

Welcome Alice! I am CyberGuard, your Cybersecurity Awareness Assistant.


i You can ask about:

• Password Safety

• Phishing Attacks

• Safe Browsing

• Malware

• Social Engineering

• Exit



Alice > What is phishing?

CyberGuard > Phishing emails try to trick you into giving personal information.

Alice > How do I make strong passwords?

CyberGuard > Use strong passwords with at least 12 characters including letters, numbers, and symbols.

Alice > exit

==================================================

Goodbye Alice! Stay safe online!

==================================================

 Reference List (Harvard Style)

National Institute of Standards and Technology (2020) Digital Identity Guidelines. Available at: https://pages.nist.gov/800-63-3/
 (Accessed: 11 April 2026).

Cybersecurity and Infrastructure Security Agency (2023) Avoiding Social Engineering and Phishing Attacks. Available at: https://www.cisa.gov
 (Accessed: 11 April 2026).

Kaspersky (2024) What is Malware? Definition and Protection Tips. Available at: https://www.kaspersky.com/resource-center/threats/malware-definition
 (Accessed: 11 April 2026).

NortonLifeLock (2024) Safe Browsing Tips for Internet Users. Available at: https://us.norton.com
 (Accessed: 11 April 2026).

Microsoft (2024) Protect Yourself from Phishing. Available at: https://support.microsoft.com
 (Accessed: 11 April 2026).

International Organization for Standardization (2022) ISO/IEC 27001 Information Security Management. Available at: https://www.iso.org/isoiec-27001-information-security.html
 (Accessed: 11 April 2026)
