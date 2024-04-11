using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    [SerializeField] private Image slotImage;
    [SerializeField] private Image itemImage; 
    [SerializeField] private Sprite placeHolderSelected;
    [SerializeField] private Sprite placeHolder;
    [SerializeField] private TextMeshProUGUI countText;

    private int id;

    public void fillSlot(Item item, int id)
    {
        this.id = id;

        if (item.count > 0)
            countText.text = item.count.ToString();
        else
            countText.text = "";
            itemImage.sprite = Resources.Load<Sprite>(item.img);
    }



    public void Click()
    {

        if (Inventory.selectedSlot == null)
        {
            slotImage.sprite = placeHolderSelected;
            Inventory.selectedSlot = this;
        }
        else if(Inventory.selectedSlot == this)
        {
            slotImage.sprite = placeHolder;
            Inventory.selectedSlot = null;
        }
        else
        {
            Inventory.selectedSlot.slotImage.sprite = placeHolderSelected;
            Inventory.selectedSlot = null;
        }
    }
}
