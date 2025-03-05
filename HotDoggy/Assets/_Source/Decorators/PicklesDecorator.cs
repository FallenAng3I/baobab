using UnityEngine;

public class PicklesDecorator : AHotdogDecorator
{
    public PicklesDecorator(AHotdog hotdog) 
        : base(hotdog, hotdog.GetName() + " с маринованными огурцами", 50, 20) {}
}
