using UnityEngine;

public class WallCling : MonoBehaviour
{
    public float speed = 5f;
    public float wallSlideSpeed = 2f;
    public float jumpForce = 10f;

    private Rigidbody2D rb;
    private bool isTouchingWall;
    private bool isGrounded;
    private float moveInput;

    public Transform wallCheck;
    public float checkRadius = 0.2f;
    public LayerMask wallLayer;

    public Transform groundCheck;
    public LayerMask groundLayer;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        moveInput = Input.GetAxis("Horizontal");

        isTouchingWall = Physics2D.OverlapCircle(wallCheck.position, checkRadius, wallLayer);
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, groundLayer);

        // Movimento horizontal normal
        rb.linearVelocity = new Vector2(moveInput * speed, rb.linearVelocity.y);

        // Wall Cling (grudar na parede)
        if (isTouchingWall && !isGrounded && moveInput != 0)
        {
            // Reduz a velocidade de queda (efeito de deslizar)
            if (rb.linearVelocity.y < -wallSlideSpeed)
            {
                rb.linearVelocity = new Vector2(rb.linearVelocity.x, -wallSlideSpeed);
            }

            // Pulo na parede (wall jump)
            if (Input.GetButtonDown("Jump"))
            {
                rb.linearVelocity = new Vector2(-moveInput * speed, jumpForce);
            }
        }
    }
}