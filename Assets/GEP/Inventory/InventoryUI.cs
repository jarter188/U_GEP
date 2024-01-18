using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using Unity.VisualScripting;
using TMPro;
using JetBrains.Annotations;

public class InventoryUI : MonoBehaviour
{
    [Header("UI")]
    //public Image image;
    //public GridLayout grid;
    Transform ItemGrid;

    //public string title;

    private void Start()
    {
        // Finds the object in control of all of the slots.
        ItemGrid = gameObject.transform.Find("Inv_Back");

    }

    public void AddNametoSlot(ItemID item)
    {
        
        bool Ran = false;

        // for each memeber of the array the parameters of each slot are found.
        foreach (Transform itemSlot in ItemGrid)
        {
            Transform panel = itemSlot.transform.Find("Panel");
            Transform Name = panel.transform.Find("Item Title");
            Transform Image = panel.transform.Find("Item Image");
            Transform Description = panel.transform.Find("Item Description");

            // If the name of the slot is empty then the data is assigned.
            if (Name.GetComponent<TextMeshProUGUI>().text == "")
            {
                if (!Ran)
                {
                    Name.GetComponent<TextMeshProUGUI>().text = item.ItemName;
                    Image.GetComponent<Image>().sprite = item.image;
                    Description.GetComponent<TextMeshProUGUI>().text = item.Description;
                    // Ran being set to true stops data being assigned to the same slot
                    // that was just assigned data.
                    Ran = true;
                }
            }
        }
    }

    public void RemoveNametoSlot(ItemID item)
    {
        // for each slot within the grid the parameters of each slot are found.
       foreach (Transform itemSlot in ItemGrid)
       {
            Transform panel = itemSlot.transform.Find("Panel");
            Transform Name = panel.transform.Find("Item Title");
            Transform Image = panel.transform.Find("Item Image");
            Transform Description = panel.transform.Find("Item Description");

            // finds the name of the text object and compares it to the item
            // being removed in the array
            if (Name.GetComponent<TextMeshProUGUI>().text == item.ItemName)
            {
                // Sets everything to nothing
                Name.GetComponent<TextMeshProUGUI>().text = "";
                Description.GetComponent<TextMeshProUGUI>().text = "";
                Image.GetComponent<Image>().sprite = null;
            }
        }
    }
}
