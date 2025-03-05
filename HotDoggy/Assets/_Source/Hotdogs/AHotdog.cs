public abstract class AHotdog
{
    protected HotdogData data;
    
    public AHotdog(HotdogData data)
    {
        this.data = data;
    }
    
    public string GetName() => data.hotdogName;
    public int GetCost() => data.baseCost;
    public int GetWeight() => data.weight;
}