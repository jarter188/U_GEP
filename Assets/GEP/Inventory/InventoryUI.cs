using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using Unity.VisualScripting;
using TMPro;
using JetBrains.Annotations;

public class InventoryItem : MonoBehaviour
{
    [Header("UI")]
    //public Image image;
    //public GridLayout grid;
    public Transform ItemGrid;
    
    //public string title;

    private void Start()
    {
        if (ItemGrid = gameObject.transform.Find("Inv_Back"))
        {
            Debug.Log("Wacky");
        }
    }

    public void AddNametoSlot(ItemID item)
    {
        
        foreach (Transform itemSlot in ItemGrid)
        {
            Transform panel = itemSlot.transform.Find("Panel");
            Transform Name = panel.transform.Find("Item Title");
            if (Name.GetComponent<TextMeshProUGUI>().text == "")
            {
                Transform title = panel.transform.Find("Item Title");
                if (title.GetComponent<TextMeshProUGUI>().text == "")
                {
                    title.GetComponent<TextMeshProUGUI>().text = item.Name;
                    Debug.Log(item.Name);
                }
            }

            if (itemSlot.transform.Find("Item Title"))
            {
                Debug.Log("temp text");
            }
        }
    }
}
