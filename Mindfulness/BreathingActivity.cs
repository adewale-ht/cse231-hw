using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base(
        "Breathing",
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    { }

    public void Run()
    {
        Start();
        int duration = GetDuration();
        int elapsed = 0;
        while (elapsed < duration)
        {
            Console.Write("\nBreathe in... ");
            ShowCountdown(4);
            elapsed += 4;
            if (elapsed >= duration) break;
            Console.Write("\nBreathe out... ");
            ShowCountdown(4);
            elapsed += 4;
        }
        End();
    }
}