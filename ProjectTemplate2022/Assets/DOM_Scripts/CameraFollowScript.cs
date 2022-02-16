using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowScript : MonoBehaviour
{
    [SerializeField] Transform targetToFollow;
    [SerializeField] float smoothSpeed = 0.125f;
    [SerializeField] Vector3 cameraAngle;

    void FixedUpdate()
    {
        Vector3 desiredPosition = targetToFollow.position + cameraAngle;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        transform.position = smoothedPosition;

        transform.LookAt(targetToFollow);
    }
}
