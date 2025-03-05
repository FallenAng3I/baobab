using UnityEngine;

[CreateAssetMenu(fileName = "HotdogData", menuName = "Hotdog/Create New Hotdog")]
public class HotdogData : ScriptableObject
{
    public string hotdogName;
    public int baseCost;
    public int weight;
}