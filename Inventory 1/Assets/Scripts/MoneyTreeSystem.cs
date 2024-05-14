using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic; // Added namespace for List

public class MoneyTreeSytem : MonoBehaviour
{
    public float money = 100.0f; // Player's money
    public Text moneyText; // Reference to the Text component displaying money

    // Function to buy an item
    public void BuyItem(Item item)
    {
        if (money >= item.price)
        {
            money -= item.price; // Deduct money
            UpdateMoneyDisplay(); // Update UI
            Inventory.AddItem(item); // Add item to inventory
        }
        else
        {
            Debug.Log("Not enough money!");
        }
    }

    // Function to update money display
    void UpdateMoneyDisplay()
    {
        moneyText.text = "Money: $" + money.ToString("F2"); // Format money to display with two decimal places
    }
}

public class Inventory : MonoBehaviour
{
    private static List<Item> items = new List<Item>(); // Player's inventory

    // Function to add an item to the inventory
    public static void AddItem(Item item)
    {
        items.Add(item);
    }
}

public class Item : MonoBehaviour
{
    public string Square;
    public float price;
}
