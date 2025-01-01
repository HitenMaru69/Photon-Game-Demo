using UnityEngine;

public class Platform : MonoBehaviour
{
    public int randomNumber;

    private void Start()
    {
        randomNumber = Random.Range(0, 2);
    }
}
