using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crop : MonoBehaviour
{
    [SerializeField] private Collider2D _collider;

    private int STEP_EMPTY = 0;
    private int STEP_GROWS = 1;
    private int STEP_READY = 2;
    private int STEP_PLOW = 3;

    private SpriteRenderer seedSprite;
    private SpriteRenderer productSprite;
    private SpriteRenderer cropSprite;

    private Item cropItem;
    private int step = 0;

    private GameObject player;
    private bool readyForAction;

    void Start()
    {
        cropSprite = GetComponent<SpriteRenderer>();
        seedSprite = GetComponentsInChildren<SpriteRenderer>()[1];
        productSprite = GetComponentsInChildren<SpriteRenderer>()[2];

        player = GameObject.FindWithTag("Player");

    }
    void OnMouseDown()
    {

        Item item = Player.items[0];

        if (readyForAction)
        {
            
            if (step == STEP_EMPTY)
            {
                Debug.Log(JsonUtility.ToJson(item));
                if (item.type == Item.TYPEFOOD)
                {
                    Player.removeItem();
                    step = STEP_GROWS;
                    cropItem = item;
                    //cropItem.count = 1;
                    seedSprite.sprite = Resources.Load<Sprite>("Sprites/seeds");
                    StartCoroutine(grow());
                }
            }
            else if (step == STEP_READY)
            {
                productSprite.sprite = Resources.Load<Sprite>("Sprites/empty");
                seedSprite.sprite = Resources.Load<Sprite>("Sprites/extraDirt");
                _collider.enabled = false;
               
                Player.checkItemExists(cropItem);
                step = STEP_PLOW;
            }
        }
    }
    private IEnumerator grow()
    {
        yield return new WaitForSeconds(cropItem.timeToGrow);

        seedSprite.sprite = Resources.Load<Sprite>("Sprites/empty");
        productSprite.sprite = Resources.Load<Sprite>(cropItem.img);

        step = STEP_READY;
        _collider.enabled = true;
    }
    private void FixedUpdate()
    {
        if(step != STEP_GROWS)
        {
            if(Vector3.Distance(this.transform.position, player.transform.position) <= 1.5f)
            {
                readyForAction = true;
                cropSprite.sprite = Resources.Load<Sprite>("Sprites/seedbedSelected");
            }
            else
            {
                readyForAction = false;
                cropSprite.sprite = Resources.Load<Sprite>("Sprites/seedbed");
            }
        }
        else
        {
            cropSprite.sprite = Resources.Load<Sprite>("Sprites/seedbed");
        }
    }

}
