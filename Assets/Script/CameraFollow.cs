using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject target;

    [SerializeField] float speed;
    [SerializeField] Vector3 offSet;
    private void LateUpdate()
    {
        FollowPlayer();
    }

    void FollowPlayer()
    {
        if (target != null)
        {
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, target.transform.position + offSet, speed);

            transform.position = smoothedPosition;
        }


    }
}
