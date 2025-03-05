using UnityEngine;

public class SweetOnionDecorator : AHotdogDecorator
{
    public SweetOnionDecorator(AHotdog hotdog) 
        : base(hotdog, hotdog.GetName() + " со сладким луком", 30, 10) {}
}
