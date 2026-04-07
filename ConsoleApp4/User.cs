using System;
using System.Threading;

public class User
{
    public string Name { get; set; } = string.Empty;// User's name, can be set during greeting or later
    public DateTime FirstInteraction { get; private set; }// Timestamp of the user's first interaction with the chatbot

    private int _questionsAsked;
    public int QuestionsAsked => _questionsAsked;

    public User()
    {
        FirstInteraction = DateTime.Now;// Initialize the first interaction time when the user object is created
        _questionsAsked = 0;
    }

    public void IncrementQuestionCount()// Method to safely increment the count of questions asked by the user
    {
        Interlocked.Increment(ref _questionsAsked);
    }

    public override string ToString()// Override ToString for easy debugging and display of user information
    {
        return $"User: {Name}, Questions: {QuestionsAsked}";
    }
}

