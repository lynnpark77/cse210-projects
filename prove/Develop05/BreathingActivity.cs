public class BreathingActivity : Activity
{
    public BreathingActivity() : base ("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.") 
    {
        
    }
    
    public void Run(int seconds)
    {
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        for ( int i = 0; i)

    }
}