using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public static ItemManager Instance;
    public List<ItemID> Items = new List<ItemID>();
    public GameObject player;
    public Transform canvas;

    private void Awake()
    {
        Instance = this;
    }

    public void Add(ItemID item)
    {
        canvas.GetComponent<InventoryItem>().AddNametoSlot(item);
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
            GameObject itemInstance = Instantiate(Item.prefab);
            itemInstance.transform.position = player.transform.position + player.transform.forward * 2;
            itemInstance.transform.localScale = itemInstance.transform.localScale / 2;
            Remove(Item);
        }    
    }
}
