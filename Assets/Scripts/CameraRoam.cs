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
        Vector3 newPos = new Vector3(target.position.x, target.position.y + 15f, target.position.z -15f);
        transform.position = Vector3.Slerp(transform.position, newPos, FollowSpeed*Time.deltaTime);
    }
}
