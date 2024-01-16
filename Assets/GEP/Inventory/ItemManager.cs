using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    // Instance of ItemManager Created
    public static ItemManager Instance;
    // List to store virual inventory members created.
    public List<ItemID> Items = new List<ItemID>();
    // player reference created.
    public GameObject player;
    // canvas reference created.
    public Transform canvas;

    private void Awake()
    {
        // Creates intial instance. 
        Instance = this;
    }

    public void Add(ItemID item)
    {
        // When item is picked up the UI component is called running the script 
        // which adds the item data to the UI.
        canvas.GetComponent<InventoryUI>().AddNametoSlot(item);
        // Add new item to list of items.
        Debug.Log("Picked up" + item);
        Items.Add(item);
    }

    public void Remove(ItemID item)
    {
        // When item is dropped the UI component to remove it from the UI is ran including the
        // script containing the code when removes it.
        canvas.GetComponent<InventoryUI>().RemoveNametoSlot(item);
        // Remove item from list.
        Debug.Log("Removed" + item);
        Items.Remove(item);
    }

    public void OnDrop(bool isPressed)
    {
        // If the I button is pressed.
        if (isPressed)

        {
            // Reduces the array count by 1
            int ItemPos = Items.Count - 1;
            // This is return removes the last member of the array.
            ItemID Item = Items[ItemPos];
            // An Instance is created 
            GameObject itemInstance = Instantiate(Item.prefab);
            // Sets the items position in accordance to the player.
            itemInstance.transform.position = player.transform.position + player.transform.forward * 2;
            // Sets the scale of the object when it spawns in.
            itemInstance.transform.localScale = itemInstance.transform.localScale / 2;
            // Removes Item from array.
            Remove(Item);
        }    
    }
}
