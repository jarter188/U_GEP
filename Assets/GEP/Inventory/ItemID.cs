using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//// Gets the file ItemID assigns menu name named scriptiableItem. 
[CreateAssetMenu(fileName = "ItemID", menuName = "ScriptableItem/New ItemID", order = 1)]

public class ItemID : ScriptableObject
{
    public int ID;
    public string ItemName;
    public GameObject prefab;
    public Sprite image;
}
