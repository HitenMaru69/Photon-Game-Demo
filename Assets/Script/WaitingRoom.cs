using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class WaitingRoom : MonoBehaviour
{
    [SerializeField] GameObject playePrefeb;
    [SerializeField] GameObject spwanPosition;
    [SerializeField] CameraFollow cameraFollow;
    [SerializeField] GameObject waitingText;
    [SerializeField] GameObject platformManager;

    private void Start()
    {
        SpwanPlayer();
    }

    private void Update()
    {
        WaitingForOtherPlayer();
    }


    void SpwanPlayer()
    {
        Renderer renderer = spwanPosition.GetComponent<Renderer>();
        Vector3 sizeOfPositionObject = renderer.bounds.size;

        Vector3 centerPosition = spwanPosition.transform.position;

        float randomx = Random.Range(centerPosition.x - sizeOfPositionObject.x/2, centerPosition.x + sizeOfPositionObject.x / 2);
        float randomz = Random.Range(centerPosition.z - sizeOfPositionObject.z/2, centerPosition.z + sizeOfPositionObject.z / 2);

        Vector3 newPosition = new Vector3(randomx, 1, randomz);


        GameObject player = PhotonNetwork.Instantiate(playePrefeb.name, newPosition, Quaternion.identity);
        cameraFollow.target = player;
        cameraFollow.enabled = true;
    }

    void WaitingForOtherPlayer()
    {
        if(PhotonNetwork.CurrentRoom.PlayerCount == PhotonNetwork.CurrentRoom.MaxPlayers)
        {
            waitingText.SetActive(false);
            platformManager.gameObject.SetActive(true);
            this.gameObject.SetActive(false);
        }
        else
        {
            waitingText.SetActive(true);
            
        }
    }

}
