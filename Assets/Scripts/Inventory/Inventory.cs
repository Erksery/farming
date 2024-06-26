using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Inventory : MonoBehaviour
{
    private List<Slot> slots = new List<Slot>();
    public static Slot selectedSlot = null;

    void Start()
    {
        slots = GetComponentsInChildren<Slot>().ToList();

        int i = 0;
        foreach(Slot slot in slots)
        {
            slot.fillSlot(i);

            i++;
        }
    }


}
