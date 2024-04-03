using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour

{

    public Sprite down;
    public Sprite up;
    public Sprite left;
    public Sprite right;


    public float speed;
    private Rigidbody2D rb;
    private Vector2 direction;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = this.GetComponent<SpriteRenderer>();
    }


    private void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.y = Input.GetAxisRaw("Vertical");
    }


    private void FixedUpdate()
    {
        if (direction.y > 0)
            spriteRenderer.sprite = up;
        else if (direction.y < 0)
            spriteRenderer.sprite = down;
        else if (direction.x > 0)
            spriteRenderer.sprite = right;
        else if (direction.x < 0)
            spriteRenderer.sprite = left;

        rb.MovePosition(rb.position + direction * speed * Time.deltaTime);
    }

}
