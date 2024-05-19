using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowing : MonoBehaviour
{
    [SerializeField] private Vector3 offset;
    [SerializeField] private float damping;
    private Vector3 velocity = Vector3.zero;

    [SerializeField] private Transform target;
    

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = target.position + offset;
        transform.position=Vector3.SmoothDamp(transform.position, targetPosition,ref velocity, damping);


    }
}
