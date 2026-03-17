using System;
using System.Threading;

public class User
{
    public string Name { get; set; } = string.Empty;
    public DateTime FirstInteraction { get; private set; }

    private int _questionsAsked;
    public int QuestionsAsked => _questionsAsked;

    public User()
    {
        FirstInteraction = DateTime.Now;
        _questionsAsked = 0;
    }

    public void IncrementQuestionCount()
    {
        Interlocked.Increment(ref _questionsAsked);
    }

    public override string ToString()
    {
        return $"User: {Name}, Questions: {QuestionsAsked}";
    }
}

