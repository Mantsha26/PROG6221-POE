 Cybersecurity Awareness Chatbot
Academic Project Documentation (Console Application)

1. Project Title
Cybersecurity Awareness Chatbot (CyberGuard)

2. Project Description
The Cybersecurity Awareness Chatbot (CyberGuard) is a console-based application developed using C# to promote user awareness of common cybersecurity threats and safe online practices.
The chatbot interacts with users through a structured conversational interface and provides guidance on essential cybersecurity topics such as:

Password safety
Phishing attacks
Safe browsing practices
Malware threats
Social engineering risks

The system also enhances usability through audio greeting functionality and visual console interface formatting.

3. Purpose of the Project

The purpose of this chatbot is to:

Educate users about cybersecurity risks
Encourage safe digital behaviour
Provide quick awareness-level responses
Demonstrate implementation of object-oriented programming concepts
Apply console-based user interaction techniques
Support learning outcomes aligned with introductory cybersecurity awareness systems
4. Technologies Used

The chatbot was implemented using:

Technology	Purpose
C#	Core programming language
.NET Console Application	Application framework
System.Media Library	Audio greeting playback
Async / Await	Smooth response display
Dictionary Collections	Keyword matching responses
5. System Features

The chatbot provides the following functionality:

5.1 Voice Greeting Feature

The system automatically plays a greeting audio file (greeting.wav) during startup to improve user engagement and accessibility.

5.2 Interactive Console Interface

The chatbot prompts the user to enter their name and then begins a conversation using a structured command interface.

Example interaction:

Enter your name: Mantsha
Welcome Mantsha! I am CyberGuard.
5.3 Keyword Recognition Engine

The chatbot identifies cybersecurity-related keywords entered by the user and returns relevant responses using dictionary-based matching.

Example keywords supported:

password
phishing
safe browsing
malware
social engineering
5.4 Typewriter Animation Effect

Responses are displayed using asynchronous character-by-character rendering to simulate a conversational chatbot experience.

5.5 User Interaction Tracking

The chatbot records:

user name
number of questions asked
session start time

This supports structured interaction monitoring during runtime.

5.6 Input Validation

The chatbot prevents:

empty inputs
invalid commands
programming code insertion

Example response:

It looks like you entered programming code. Please ask a cybersecurity question instead.
6. System Architecture

The application follows an object-oriented modular structure consisting of five primary classes:

Class	Responsibility
Program.cs	Application entry point
ChatBot.cs	Conversation control logic
User.cs	Stores user information
ResponseSystem.cs	Generates responses
ConsoleUI.cs	Handles interface formatting

This modular structure improves:

maintainability
readability
scalability
7. Cybersecurity Topics Covered

The chatbot provides awareness-level guidance on the following security concepts:

Password Safety

Users are advised to create strong passwords containing:

uppercase letters
lowercase letters
numbers
symbols
Phishing Awareness

Users are warned about suspicious:

emails
links
attachments
impersonation attempts
Safe Browsing Practices

The chatbot encourages users to:

verify HTTPS website connections
avoid unsafe downloads
avoid suspicious links
Malware Protection

Users are advised to:

install antivirus software
update systems regularly
avoid unknown downloads
Social Engineering Awareness

The chatbot explains risks involving manipulation techniques used to obtain confidential information from users.

8. Error Handling Implementation

The chatbot includes structured exception handling to prevent system crashes during execution.

Example:

try
{
    chatbot execution
}
catch (Exception ex)
{
    error message display
}

This improves reliability and user experience.

9. Limitations of the System

Although effective for awareness-level interaction, the chatbot has the following limitations:

keyword-based responses only
no machine learning integration
no persistent storage of conversations
no graphical interface
limited topic expansion capability

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
