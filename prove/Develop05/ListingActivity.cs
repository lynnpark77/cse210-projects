public class ListingActivity : Activity 
{
    public ListingActivity() : base ( "Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {

    }

    private int _count = 0;
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate? ",
        "What are personal strengths of yours? ",
        "Who are people that you have helped this week? ",
        "When have you felt the Holy Ghost this month? ",
        "Who are some of your personal heroes? "
    };

    public void Run()
    {
         _duration = 0;
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while(DateTime.Now < endTime)
        {
            Console.WriteLine("List as many responses you can to the following prompt:");
            Console.WriteLine($" ---{GetRandomPrompt()}---");
            Console.Write("You may begin in: ");
            ShowCountDown(5);
            Console.WriteLine();
            List<string> userResponses = GetListFromUser();
            Console.WriteLine($"You listed {userResponses.Count} items! ");
            Console.WriteLine();
        } 
        DisplayEndingMessage(); 
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    private List<string> GetListFromUser()
    {
        List<string> userResponse = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while(DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            userResponse.Add(response);
        }
        return userResponse;
       
    }

}