public class ListingActivity : Activity 
{
    public ListtingActivity() : base ( "Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {

    }

    private int _count ;
    private List<string> prompts ;

    private List<string> prompts = new List<string>
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
            GetRandomPrompt();
            ShowSpinner(5);
            GetListFromUser();
            Console.WriteLine();
        } 
        DisplayEndingMessage(); 
    }

    private void GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }

    private List<string> GetListFromUser()
    {
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($" ---{GetRandomPrompt()}---");
        Console.Write("You may begin in: ");
        ShowCountDown(5);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while(DateTime.Now < endTime)
        {
            Console.Write(">");
            string response = Console.ReadLine();
            List<string> userResponse = new List<string>();
            userResponse.Add(response);
        }

        Console.WriteLine($"You listed {userResponse.Count} items!");
        Console.WriteLine();
    }

}