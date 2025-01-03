using Photon.Pun;
using UnityEngine;

public class Platform2 : MonoBehaviourPun
{
    [SerializeField] Platform platform;
    [SerializeField]PhotonView view;

    private void Start()
    {
        view = GetComponent<PhotonView>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            if(platform.randomNumber == 1)
            {
                view.RPC(nameof(DestroyPlatform2), RpcTarget.All);
            }

            //PhotonView photonView = collision.gameObject.GetComponent<PhotonView>();

            //if (platform.randomNumber == 1)
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
    void DestroyPlatform2()
    {
        Destroy(this.gameObject);
    }
}



