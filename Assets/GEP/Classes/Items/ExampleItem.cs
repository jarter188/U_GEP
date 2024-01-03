using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleItem : MonoBehaviour, IPickupable
{
    GameObject ItemManager;
    public ItemID ID;
    
    void Start()
    {
        ItemManager = GameObject.FindWithTag("ItemManagerTag");
    }

    public void Pickup()
    {
        ItemManager.SendMessage("Add", ID);
        Destroy(gameObject);
    }
}
