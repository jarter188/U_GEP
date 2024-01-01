using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleItem : MonoBehaviour, IPickupable
{
    gameObject.SendMessage()

    public void Pickup()
    {
        ItemManager.Instance.Add(Item);
        Destroy(gameObject);
    }
}
