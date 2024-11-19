public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "If I had one thing I could do over today, what would it be?",
        "What was the best part of my day?",
        "Who was the most interesting person I interacted with today?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "What scripture stood out from my scripture study today?"
    };


    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);
        string promptGenerator = _prompts[randomIndex];
        return promptGenerator;
    }


}