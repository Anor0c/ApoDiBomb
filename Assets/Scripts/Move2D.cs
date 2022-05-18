using UnityEngine;
using UnityEngine.InputSystem;

public class Move2D : MonoBehaviour
{
    [SerializeField] float speed;
    Vector2 stickDirection;

    Rigidbody2D rb; //pas oublier de mettre un rigid body 2d!!!

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        stickDirection.y = 0;
        rb.velocity = stickDirection * speed;
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        stickDirection = context.ReadValue<Vector2>();
    }
}

