using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] int playerSpeed;
    [SerializeField] int jumpForce;

    private Rigidbody rb;
    private float horizontal;
    private float vertical;
    private Vector3 movement;
    private bool isJump;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        movement = new Vector3 (horizontal, 0,vertical).normalized;
        
        if(Input.GetKeyDown(KeyCode.Space))
        {
            isJump = true;
        }

    }

    private void FixedUpdate()
    {
        PlayerMoveMent();

        if(isJump)
        {
            PLayerJump();
            isJump = false;
        }
    }

    void PlayerMoveMent()
    {
        rb.MovePosition(rb.position + movement * playerSpeed * Time.fixedDeltaTime);
    }

    void PLayerJump()
    {
        rb.AddForce(Vector3.up * jumpForce,ForceMode.Impulse);
    }
}
