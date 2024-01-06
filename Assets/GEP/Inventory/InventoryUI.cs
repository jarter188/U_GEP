using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using Unity.VisualScripting;

public class InventoryItem : MonoBehaviour
{
    [Header("UI")]
    public Image image;
    public GridLayout grid;

    private void Start()
    {
        gameObject.transform.Find("Inv_Back");
     
    }
}
