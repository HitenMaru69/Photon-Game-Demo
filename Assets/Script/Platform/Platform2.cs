using UnityEngine;

public class Platform2 : MonoBehaviour
{
    [SerializeField] Platform platform;


    private void OnCollisionEnter(Collision collision)
    {
        if(platform.randomNumber == 1)
        {
            Destroy(this.gameObject);
        }
    }
}
