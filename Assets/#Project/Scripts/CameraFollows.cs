using System;
using Unity.Profiling;
using UnityEngine;

public class CameraFollows : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float offset;



    void Start()
    {
        
    }

   
    void Update()
    {
        float z = target.position.z - offset;
        Vector3 position = transform.position;

        position.z = z;

        transform.position = position ;
    }
}

