using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//// Gets the file ItemID assigns menu name named scriptiableItem. 
[CreateAssetMenu(fileName = "ItemID", menuName = "ScriptableItem/New ItemID", order = 1)]

// Scriptable Object class typeD
public class ItemID : ScriptableObject
{
    // ID is the identifier for the object when its picked up. This is used when an object is picked up to find which 
    public int ID;
    // replaces the empty name UI text box on the canvas prefab. Identifies the object for the player. 
    public string ItemName;
    // contains the prefab of the object which is being picked up.
    public GameObject prefab;
    // image which is assigned to empty image on the canvas slot
    public Sprite image;
    // replaces the empty name Description text box on the canvas prefab. Identifies the object for the player.
    public string Description;
}
