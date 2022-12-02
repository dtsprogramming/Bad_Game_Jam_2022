using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Player Movement")]
    public float moveSpeed = 5f;

    [Header("Player Jump")]
    [SerializeField] private float jumpVelocity = 5f;
    [SerializeField] private float fallMultiplier = 2.5f;
    [SerializeField] private float lowJumpMultiplier = 2f;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask ground;

    private Rigidbody rb;
    private Transform tf;
    private float horizontalMove;
    private float zMove;
    private Vector3 currentVelocity;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        tf = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckForInput();
        ImprovedJumpMechanics();
    }

    private void FixedUpdate()
    {
        if (tf.position.y < 50)
        {
            MovePlayer();
        }
        else
        {
            FinalPlatformMotion();
        }
        
    }

    private void CheckForInput()
    {
        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            PlayerJump();
        }

        horizontalMove = Input.GetAxisRaw("Horizontal") * Time.deltaTime;
        zMove = Input.GetAxisRaw("Vertical") * Time.deltaTime;

        currentVelocity = new Vector3(horizontalMove * moveSpeed, rb.velocity.y, 0f);
    }

    private void MovePlayer()
    {
        if (horizontalMove != 0)
        {
            rb.velocity = currentVelocity;
        }
        else
        {
            currentVelocity = new Vector3(0f, rb.velocity.y, 0f);
            rb.velocity = currentVelocity;
        }
    }

    private void FinalPlatformMotion()
    {
        currentVelocity = new Vector3(horizontalMove * moveSpeed, rb.velocity.y, zMove * moveSpeed);

        if (horizontalMove != 0 || zMove != 0   )
        {
            rb.velocity = currentVelocity;
        }
        else
        {
            currentVelocity = new Vector3(0f, rb.velocity.y, 0f);
            rb.velocity = currentVelocity;
        }
    }



    private void PlayerJump()
    {
        rb.velocity = Vector3.up * jumpVelocity;
    }

    private void ImprovedJumpMechanics()
    {
        if (rb.velocity.y < 0)
        {
            rb.velocity += Vector3.up * Physics.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        }
        else if (rb.velocity.y > 0 && !Input.GetButton("Jump"))
        {
            rb.velocity += Vector3.up * Physics.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
        }
    }

    private bool IsGrounded()
    {
        return Physics.CheckSphere(groundCheck.position, 0.1f, ground);
    }

}
