using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crop : MonoBehaviour
{
    private SpriteRenderer seedSprite;
    private SpriteRenderer productSprite;
    private SpriteRenderer cropSprite;

    void Start()
    {
        cropSprite = GetComponent<SpriteRenderer>();
        seedSprite = GetComponentsInChildren<SpriteRenderer>()[1];
        productSprite = GetComponentsInChildren<SpriteRenderer>()[2];

        productSprite.sprite = Resources.Load<Sprite>("Sprites/pumpkin");
    }

    void Update()
    {
        
    }

}
