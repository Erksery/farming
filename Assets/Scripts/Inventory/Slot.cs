using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    private Image slotImage;
    private Image itemImage;
    private Text countText;

    public void fillSlot(Item item)
    {
        slotImage = GetComponent<Image>();
        itemImage = GetComponentsInChildren<Image>()[1];
        countText = GetComponentInChildren<Text>();

        Debug.Log(item);

        if (item.count > 0)
            countText.text = item.count.ToString();
        else
            countText.text = "";
            itemImage.sprite = Resources.Load<Sprite>(item.img);
    }

}
