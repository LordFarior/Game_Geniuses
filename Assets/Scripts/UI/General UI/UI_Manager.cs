using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    public float displayValue;
    public PlayerData playerOneData;
    public Slider playerOneHealth;

    void UpdateHealthBar()
    {
        playerOneHealth.value = playerOneData.health;
    }
    // Update is called once per frame
    void Update()
    {
        UpdateHealthBar();
    }
}
