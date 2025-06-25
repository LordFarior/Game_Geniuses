using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Scriptable Objects/Item")]
public class Item : ScriptableObject
{
    public string itemName;
    [field: TextArea]
    public string description;
    public GameObject model;
    public Sprite icon;
    public int cost;
    public bool canDiscard;
}
