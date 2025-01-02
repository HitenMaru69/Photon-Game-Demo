using Photon.Pun;
using UnityEngine;

public class Winning : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PhotonView photonView = other.gameObject.GetComponent<PhotonView>();

            if(photonView != null)
            {
                if (photonView.IsMine)
                {                    
                    Debug.Log("You win");
                    GamePlayUI.instance.SetWinnLose(true,false);
                }
            }
        }
    }
}
