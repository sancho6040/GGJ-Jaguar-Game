using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRoam : MonoBehaviour
{
    public float FollowSpeed = 0f;
    public float yOffset = 100f;
    public Transform target;

    void Update()
    {
        Vector3 newPos = new Vector3(target.position.x, target.position.y + 40f, target.position.z -60f);
        transform.position = Vector3.Slerp(transform.position, newPos, Time.deltaTime);
    }
}
