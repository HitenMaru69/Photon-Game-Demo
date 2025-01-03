using Photon.Pun;
using UnityEngine;

public class Plateformmanager : MonoBehaviourPun
{
    [SerializeField] GameObject platformPrefeb;
    [SerializeField] GameObject winningPlatform;
    [SerializeField] Transform spwanPosition;
    [SerializeField] int numberOfPlatformSpwan;
    [SerializeField] int platformLength;
    [SerializeField] PhotonView view;

    private void Start()
    {
        SpwanPlatforms();
    }
    [PunRPC]

    void SpwanPlatforms()
    {
        for (int i = 0; i < numberOfPlatformSpwan; i++)
        {
            PhotonNetwork.Instantiate(platformPrefeb.name, spwanPosition.position, Quaternion.identity);

            Vector3 newpos = spwanPosition.position;
            newpos.z = newpos.z + platformLength;

            spwanPosition.position = newpos;

        }


        Vector3 newPos = spwanPosition.position;
        newPos.z = newPos.z + platformLength / 2;
        spwanPosition.position = newPos;

        PhotonNetwork.Instantiate(winningPlatform.name, spwanPosition.position, Quaternion.identity);

    }
}
