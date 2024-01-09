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

        ItemGrid = gameObject.transform.Find("Inv_Back");

    }

    public void AddNametoSlot(ItemID item)
    {
        bool Ran = false;

        foreach (Transform itemSlot in ItemGrid)
        {
            Transform panel = itemSlot.transform.Find("Panel");
            Transform Name = panel.transform.Find("Item Title");
            Transform Image = panel.transform.Find("Item Image");

            if (Name.GetComponent<TextMeshProUGUI>().text == "")
            {
                if (!Ran)
                {
                    Name.GetComponent<TextMeshProUGUI>().text = item.ItemName;
                    Image.GetComponent<Image>().sprite = item.image;
                    Ran = true;
                }
            }
        }
    }

    public void RemoveNametoSlot(ItemID item)
    {
       foreach (Transform itemSlot in ItemGrid)
       {
            Transform panel = itemSlot.transform.Find("Panel");
            Transform Name = panel.transform.Find("Item Title");
            Transform Image = panel.transform.Find("Item Image");

            if (Name.GetComponent<TextMeshProUGUI>().text == item.ItemName)
            {
                Name.GetComponent<TextMeshProUGUI>().text = "";
                Image.GetComponent<Image>().sprite = null;
            }
        }
    }
}
