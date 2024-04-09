using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    [SerializeField] private Image slotImage;
    [SerializeField] private Image itemImage;
    [SerializeField] private TextMeshProUGUI countText;

    public void fillSlot(Item item)
    {


        Debug.Log(JsonUtility.ToJson(item));

        if (item.count > 0)
            countText.text = item.count.ToString();
        else
            countText.text = "";
            itemImage.sprite = Resources.Load<Sprite>(item.img);
    }
}
