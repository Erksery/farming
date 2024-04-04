using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class MovementButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public Vector2 Direction;

    private bool _isPressed;

    public event Action<Vector2> Pressed;

    private void Update()
    {
        if (_isPressed)
            Pressed?.Invoke(Direction);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        _isPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        _isPressed = false;
        Pressed?.Invoke(Vector2.zero);
    }
}