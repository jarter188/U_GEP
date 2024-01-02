using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleItem : MonoBehaviour, IPickupable
{
    /// <summary>
    /// gameObject.SendMessage()
    /// </summary
    /// 

    public Item Item;

    public void Pickup()
    {
        ItemManager.Instance.Add(Item);
        Destroy(gameObject);
    }
}
