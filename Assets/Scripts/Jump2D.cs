using UnityEngine;
using UnityEngine.InputSystem;

public class Jump2D : MonoBehaviour
{
    Rigidbody2D rb;

    public float jumpHeight;
    bool isGrounded = true;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    public void OnJump(InputAction.CallbackContext obj)
    {
        if (!obj.started)
            return;
        Jump();
    }
    void Jump()
    {//il faudrait une autre facon de sauter
        if (isGrounded)
        {
            rb.AddForce(Vector2.up * jumpHeight,ForceMode2D.Impulse);
        }
    }
}
