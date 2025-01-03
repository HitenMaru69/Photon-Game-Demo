using Photon.Pun;
using UnityEngine;

public class Platform2 : MonoBehaviourPun
{
    [SerializeField] Platform platform;
   

    private void Start()
    {
      
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            if(platform.randomNumber == 1)
            {
                PhotonView photonView = GetComponent<PhotonView>();
              
                photonView.RPC(nameof(DestroyPlatForm1), RpcTarget.All);
               
            }

        }
   
    }

    [PunRPC]
    void DestroyPlatForm1()
    {
        Destroy(gameObject);
    }


}



