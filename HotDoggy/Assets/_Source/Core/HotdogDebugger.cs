using UnityEngine;

public class HotdogDebugger : MonoBehaviour
{
    public HotdogData classicHotdogData;

    private void Start()
    {
        AHotdog classic = new ClassicHotdog(classicHotdogData);
        Debug.Log($"{classic.GetName()} ({classic.GetWeight()}г) — {classic.GetCost()}р.\n");
        
        AHotdog withPickles = new PicklesDecorator(classic);
        Debug.Log($"Дополнительная информация:\n{withPickles.GetName()} ({withPickles.GetWeight()}г) — {withPickles.GetCost()}р.\n");
        
        AHotdog withSweetOnion = new SweetOnionDecorator(classic);
        Debug.Log($"{withSweetOnion.GetName()} ({withSweetOnion.GetWeight()}г) — {withSweetOnion.GetCost()}р.");
    }
}