using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Inventory : MonoBehaviour
{
    private Dictionary<string, int> myInventory = new Dictionary<string, int>();
    public TextMeshPro inventoryDisplay;

    private void Start()
    {
        inventoryDisplay.text = "";
        myInventory.Add("Sword", 4);
        myInventory.Add("Potion", 3);
        myInventory.Add("Towel", 2);

        myInventory["Sword"] = 10;
        myInventory.Remove("Potion");

        DisplayInventory();
    }

    private void DisplayInventory()
    {
        inventoryDisplay.text = null;
        foreach (var item in myInventory)
        {
            inventoryDisplay.text += "Item: " + item.Key + " Quantity: " + item.Value + "\n";
        }
    }

    private void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            AddGun();
        }
        if (Input.GetMouseButtonDown(1))
        {
            RemoveGun();
        }
    }
    public void RemoveGun()
    {
        myInventory.Add("Gun", 20);
        DisplayInventory();
    }
    public void AddGun()
    {
        myInventory.Remove("Gun");
        DisplayInventory();
    }
}
