using Photon.Pun;
using UnityEngine;

public class Platform2 : MonoBehaviour
{
    [SerializeField] Platform platform;
    PhotonView view;

    private void Start()
    {
        view = GetComponent<PhotonView>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PhotonView photonView = collision.gameObject.GetComponent<PhotonView>();

            if (platform.randomNumber == 1)
            {
                if (!PhotonNetwork.IsMasterClient || !photonView.IsMine)
                {
                    view.TransferOwnership(PhotonNetwork.LocalPlayer);
                }

                PhotonNetwork.Destroy(this.gameObject);



            }
        }
   
    }
}
