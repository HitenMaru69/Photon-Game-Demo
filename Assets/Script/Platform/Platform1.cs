using Photon.Pun;
using UnityEngine;

public class Platform1 : MonoBehaviourPun
{
    [SerializeField] Platform platform;
    [SerializeField]PhotonView view;

    private void Start()
    {
         //view = GetComponent<PhotonView>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            if(platform.randomNumber == 0)
            {
                view.RPC(nameof(DestroyPlateform1),RpcTarget.All);
            }

            //PhotonView photonView = collision.gameObject.GetComponent<PhotonView>();

            //if (platform.randomNumber == 0)
            //{
            //    if (!PhotonNetwork.IsMasterClient || !photonView.IsMine)
            //    {
            //        view.TransferOwnership(PhotonNetwork.LocalPlayer);
                    
            //    }
            //    PhotonNetwork.Destroy(this.gameObject);

            //}
        }

    }

    [PunRPC]
    void DestroyPlateform1()
    {

        Destroy(this.gameObject);

    }
}
