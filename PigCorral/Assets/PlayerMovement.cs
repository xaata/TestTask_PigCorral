using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float movementSpeed = 10;
    private Rigidbody2D rb;
    Vector2 movement;
    [SerializeField] private Animator animator;
    [SerializeField] private Joystick joyStick;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        movement.x = joyStick.Horizontal;
        movement.y = joyStick.Vertical;
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);


    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * movementSpeed * Time.fixedDeltaTime);
        
    }
}
