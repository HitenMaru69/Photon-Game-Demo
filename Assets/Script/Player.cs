using Photon.Pun;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float playerSpeed;
    [SerializeField] float jumpForce;

    private Rigidbody rb;
    private float horizontal;
    private float vertical;
    private Vector3 movement;
    private bool isJump;
    private PhotonView photonView;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        photonView = GetComponent<PhotonView>();
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

        if (photonView.IsMine)
        {
            if (transform.position.y <= -10f)
            {
                Destroy(photonView.gameObject);
                GamePlayUI.instance.SetWinnLose(false, true);
            }
        }

       
    }

    private void FixedUpdate()
    {
        if(photonView.IsMine)
        {
            PlayerMoveMent();

            if (isJump)
            {
                PLayerJump();
                isJump = false;
            }
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
