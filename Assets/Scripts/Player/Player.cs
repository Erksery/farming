using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static List<Item> items = new List<Item>();

    void Start()
    {
        Item item = new Item("pumpkin", "Sprites/pumpkin", 3, Item.TYPEFOOD, 10, 1, 5f);
        items.Add(item);
    }
}
