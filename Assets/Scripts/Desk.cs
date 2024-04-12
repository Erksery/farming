using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desk : MonoBehaviour
{
    [SerializeField] private SpriteRenderer desk;
    [SerializeField] private Sprite deskSprite;
    [SerializeField] private Sprite activeDeskSprite;

    private GameObject player;
    private bool readyForAction;


    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }
    private void FixedUpdate()
    {
        if (Vector3.Distance(this.transform.position, player.transform.position) <= 1.2f)
        {
            readyForAction = true;
            desk.sprite = activeDeskSprite;

        }
        else
        {
            readyForAction = false;
            desk.sprite = deskSprite;
        }
    }
}
