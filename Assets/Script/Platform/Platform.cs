using Photon.Pun;
using UnityEngine;

public class Platform : MonoBehaviourPun
{
    public int randomNumber;

    [SerializeField] PhotonView view;

    private void Start()
    {
        if(PhotonNetwork.IsMasterClient)
        {
            randomNumber = Random.Range(0, 2);
            view.RPC("SetRandomNumber", RpcTarget.All, randomNumber);
        }

    }

    [PunRPC]
    void SetRandomNumber(int number)
    {
        randomNumber = number;
    }
    
}
