using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//// Gets the file ItemID assigns menu name named scriptiableItem. 
[CreateAssetMenu(fileName = "ItemID", menuName = "ScriptableItem/New ItemID", order = 1)]

public class Item : ScriptableObject
{
    public int ID;
    public string Name;
    public GameObject prefab;
    public Sprite image;
}
