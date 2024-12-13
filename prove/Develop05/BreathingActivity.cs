public class BreathingActivity : Activity
{
    public BreathingActivity() : base ("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.") 
    {
        
    }
    
    public void Run()
    {
        _duration = 0;
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while(DateTime.Now < endTime)
        {
            Console.Write("Breath in...");
            ShowCountDown(4);
            Console.WriteLine();
            Console.Write("Now breath out...");
            ShowCountDown(6);
            Console.WriteLine();
            Console.WriteLine();
        }

        DisplayEndingMessage();

    }
}