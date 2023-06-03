using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Set camera to follow target player
        transform.position = new Vector3(target.position.x, target.position.y, transform.position.z);

        // Match player rotation
        transform.rotation = target.rotation;
    }

}
