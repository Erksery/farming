using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static List<Item> items = new List<Item>();

    void Start()
    {
        Item item = new Item("pumpkin", "Sprites/pumpkin", Item.TYPEFOOD, 3, 10, 1, 5f);
        items.Add(item);
    }

    public static Item getHandItem()
    {
        return new Item
            (
            items[0].name,
            items[0].img,
            items[0].count,
            items[0].type,
            items[0].price,
            items[0].lvlWhenUnlock,
            items[0].timeToGrow
            );
    }

    private static Item getEmptyItem()
    {
        return new Item("empty", "Sprites/empty", 0, 0, 0, 0, 0);
    }

    public static void removeItem()
    {
        if(items[0].count == 1)
            items[0] = getEmptyItem();
        else
            items[0].count -= 1;
    }

    public static void checkItemExists(Item item)
    {
        bool exist = false;
        for (int i = 0; i < items.Count; i++)
        {
            if (item.name == items[i].name)
            {
                items[i].count += 1;
                exist = true;
                break;
            }
        }
        if (!exist)
            addItemToInventory(item);
    }

    private static void addItemToInventory(Item item)
    {
        bool added = false;
        for (int i = 0; i < items.Count; i++)
        {
            if (items[i].name == "empty")
            {
                items[i] = item;
                added = true;
                break;
            }
        }
        if (!added)
            items.Add(item);
    }
}
