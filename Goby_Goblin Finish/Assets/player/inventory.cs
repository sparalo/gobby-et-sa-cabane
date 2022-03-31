
using UnityEngine;
using UnityEngine.UI;

public class inventory : MonoBehaviour
{
    public int coinsCount;
    public Text coinsCountText;

    public int potionCount;
    public Text potionCountText;

    public static inventory instance;

    private void Awake()
    {
        if(instance != null)
        {
            Debug.LogWarning("Il y'a plus d'une instance de Inventory dans la scène.");
            return;
        }

        instance = this;
    }

    public void AddCoins(int countC)
    {
        coinsCount += countC;
        coinsCountText.text = coinsCount.ToString();
    }

    public void MinCoins(int countC)
    {
        coinsCount -= countC;
        coinsCountText.text = coinsCount.ToString();
    }

    public void AddPotion(int countP)
    {
        potionCount += countP;
        potionCountText.text =potionCount.ToString();
    }
}
