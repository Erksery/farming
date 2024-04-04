using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D Rigidbody;
    public float Speed;

    public MovementButton[] Buttons;

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
        Rigidbody.velocity = direction * Speed;
    }
}
