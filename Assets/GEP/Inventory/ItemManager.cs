using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public static ItemManager Instance;
    public List<ItemID> Items = new List<ItemID>();

    private void Awake()
    {
        Instance = this;
    }

    public void Add(ItemID item)
    {
        Items.Add(item);
    }

    public void Remove(ItemID item)
    {
        Items.Remove(item);
    }

    public void OnDrop(bool isPressed)
    {
        if (isPressed)
        {
            int ItemPos = Items.Count - 1;
            ItemID Item = Items[ItemPos];
            Remove(Item);
        }    
            
    }
}
