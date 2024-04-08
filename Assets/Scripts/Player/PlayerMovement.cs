using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D Rigidbody;
    public float Speed;

    public Sprite down;
    public Sprite up;
    public Sprite left;
    public Sprite right;

    private SpriteRenderer spriteRenderer;

    public MovementButton[] Buttons;

    private void Start()
    {
        spriteRenderer = this.GetComponent<SpriteRenderer>();
    }

    private void OnEnable()
    {
        foreach (MovementButton button in Buttons)
            button.Pressed += OnPressed;
    }

    private void OnDisable()
    {
        foreach (MovementButton button in Buttons)
            button.Pressed -= OnPressed;
    }

    private void OnPressed(Vector2 direction)
    {
         if (direction.y > 0)
            spriteRenderer.sprite = up;
        else if (direction.y < 0)
            spriteRenderer.sprite = down;
        else if (direction.x > 0)
            spriteRenderer.sprite = right;
        else if (direction.x < 0)
            spriteRenderer.sprite = left;

        Rigidbody.velocity = direction * Speed;
    }
}
