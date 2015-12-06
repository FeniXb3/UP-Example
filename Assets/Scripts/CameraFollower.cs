using UnityEngine;
using System.Collections;

public class CameraFollower : MonoBehaviour
{
    public Vector3 offset;
    public GameObject objectToFollow;

    void Start()
    {
        if(objectToFollow == null)
        {
            objectToFollow = GameObject.FindGameObjectWithTag("Player");
        }
    }

    void Update()
    {
        transform.position = objectToFollow.transform.position + offset;
    }
}
