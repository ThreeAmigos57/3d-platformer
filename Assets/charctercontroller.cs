using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charctercontroller : MonoBehaviour
{
   

    // Update is called once per frame
    public float maxSpeed = 1.0f;
    public float roatation = 0.0f;
    public float camRotation = 0.0f;
    public float camRoatationSpeed = 1.5f;
    GameObject cam;
    Rigidbody myRigidbody;

    bool isonGrounnd;
    public GameObject GroundChecker;
    public LayerMask groundLayer;


   void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;

        cam = GameObject.Find("Main Camera");
        myRigidbody = GetComponent<Rigidbody>();
    }
    void Update()
    {
       

        Vector3 newVelocity = transform.forward * Input.GetAxis("Vertical") * maxSpeed;
        myRigidbody.velocity = new Vector3(newVelocity.x, myRigidbody.velocity.y, newVelocity.z);
        roatation = roatation + Input.GetAxis("Mouse X");
        transform.rotation = Quaternion.Euler(new Vector3(0.0f, roatation, 0.0f));

        camRotation = camRotation + Input.GetAxis("Mouse Y") * camRoatationSpeed;
        cam.transform.localRotation = Quaternion.Euler(new Vector3(camRotation, 0.0f, 0.0f));
    }
}
