using Photon.Pun;
using UnityEngine;

public class Platform : MonoBehaviourPun
{
    public int randomNumber;

    private void Start()
    {
        randomNumber = Random.Range(0, 2);
        photonView.RPC("SetRandomNumber",RpcTarget.All ,randomNumber);
    }

    [PunRPC]
    void SetRandomNumber(int number)
    {
        randomNumber = number;
    }
    
}
