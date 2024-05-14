using UnityEngine;
using UnityEngine.UI; // Add this line to access UI components

public class DragAndDrop : MonoBehaviour
{
    public Text moneyText; // Reference to the UI Text element displaying money
    public float StartingMoney { get; private set; } = 100f;
    private float money;

    private void Start()
    {
        money = StartingMoney; // Initialize money
        UpdateMoneyText(); // Update UI text on start
    }

    public void RefundItem(float price)
    {
        money += price;
        Debug.Log($"Item refunded for {price}! Money: {money}");
        UpdateMoneyText(); // Update UI text after refunding item
    }
    public void BuyItem(float price)
    {
        if (money >= price)
        {
            money -= price;
            Debug.Log($"Item bought for {price}! Money left: {money}");
            UpdateMoneyText(); // Update UI text after buying item
        }
        else
        {
            Debug.Log("Not enough money to buy the item!");
        }
    }

    public void SellItem(float price)
    {
        money += price;
        Debug.Log($"Item sold for {price}! Money: {money}");
        UpdateMoneyText(); // Update UI text after selling item
    }

    public void DestroyObject(GameObject obj)
    {
        Destroy(obj);
    }

    private void UpdateMoneyText()
    {
        if (moneyText != null)
        {
            moneyText.text = "Money: " + money.ToString("F2"); // Format money to display with two decimal places
        }
    }
}