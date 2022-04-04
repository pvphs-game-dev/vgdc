using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    void FixedUpdate()
    {
        Vector3 desiredPosition = target.position;
        Vector3 offsetPosition = desiredPosition + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, offsetPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }
}