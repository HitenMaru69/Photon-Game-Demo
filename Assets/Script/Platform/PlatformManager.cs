using UnityEngine;

public class PlatformManager : MonoBehaviour
{
    [SerializeField] GameObject platformPrefeb;
    [SerializeField] Transform spwanPosition;
    [SerializeField] int numberOfPlatformSpwan;
    [SerializeField] int platformLength;

    

    private void Start()
    {
        SpwanPlatforms();
    }

    void SpwanPlatforms()
    {
        for(int i = 0; i < numberOfPlatformSpwan; i++)
        {
            Instantiate(platformPrefeb, spwanPosition.position,Quaternion.identity);

            Vector3 newpos = spwanPosition.position;
            newpos.z = newpos.z + platformLength;

            spwanPosition.position = newpos;

        }

    }
}
