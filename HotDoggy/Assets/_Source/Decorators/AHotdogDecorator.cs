using UnityEngine;

public abstract class AHotdogDecorator : AHotdog
{
    protected AHotdog hotdog;
    protected int extraCost;
    protected int extraWeight;
    
    public AHotdogDecorator(AHotdog hotdog, string name, int extraCost, int extraWeight) 
        : base(ScriptableObject.CreateInstance<HotdogData>())
    {
        this.hotdog = hotdog;
    }
}