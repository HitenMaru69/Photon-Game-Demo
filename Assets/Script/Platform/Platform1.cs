using UnityEngine;

public class Platform1 : MonoBehaviour
{
    [SerializeField] Platform platform;

    private void OnCollisionEnter(Collision collision)
    {
        if(platform.randomNumber == 0)
        {
            Destroy(this.gameObject);
        }
    }
}
