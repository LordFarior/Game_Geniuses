using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "Players", order = 3, fileName = "PlayerData")]
public class PlayerData : ScriptableObject
{
    public int health;
    public float magic;
    public Vector3 currentPosition;
    public int playersCount;
    public float walkSpeed = 5f;
    public Slider healthDisplay;

}
