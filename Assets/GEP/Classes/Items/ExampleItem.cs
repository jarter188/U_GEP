using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleItem : MonoBehaviour, IPickupable
{
    // Allows manager to access the open class where any item can be added to.
    GameObject ItemManager;
    public ItemID ID;
    
    void Start()
    {
        // On start up All example items will find the manager using its custom tag.
        ItemManager = GameObject.FindWithTag("ItemManagerTag");
    }

    public void Pickup()
    {
        // Send message transfers the data easily to the manager, in this instance with a ID attached. 
        ItemManager.SendMessage("Add", ID);
        // WHen its picked up the gameobject is destroyed.
        Destroy(gameObject);
    }
}
