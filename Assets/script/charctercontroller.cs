using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charctercontroller : MonoBehaviour
{
   

    // Update is called once per frame
    public float maxSpeed;
    public float normalSpeed = 10.0f;
    public float sprintSpeed = 20.0f;

     float roatation = 0.0f;
     float camRotation = 0.0f;
     float camRoatationSpeed = 1.5f;

     public float maxSprint = 5.0f;
     float sprintTimer;


    GameObject cam;
    Rigidbody myRigidbody;

    bool isonGrounnd;
    public GameObject GroundChecker;
    public LayerMask groundLayer;
    public float jumpforce = 300.0f;


   void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;

        sprintTimer = maxSprint;

        cam = GameObject.Find("Main Camera");
        myRigidbody = GetComponent<Rigidbody>();
    }
    void Update()
    {
       isonGrounnd = Physics.CheckSphere(GroundChecker.transform.position, 0.1f, groundLayer);
          if (isonGrounnd == true && Input.GetKeyDown(KeyCode.Space))
          {
                myRigidbody.AddForce(transform.up * jumpforce);
          }

          if(Input.GetKey(KeyCode.LeftShift) && sprintTimer > 0.0f)
          {
              maxSpeed = sprintSpeed;
              sprintTimer = sprintTimer - Time.deltaTime;
          } else
          {
                maxSpeed = normalSpeed;
                if(Input.GetKey(KeyCode.LeftShift) == false ){
                sprintTimer = sprintTimer + Time.deltaTime;
                }
               
          }
          sprintTimer = Mathf.Clamp(sprintTimer,0.0f,maxSpeed);
               
          



        Vector3 newVelocity = transform.forward * Input.GetAxis("Vertical") * maxSpeed + (transform.right * Input.GetAxis("Horizontal") * maxSpeed);
        myRigidbody.velocity = new Vector3(newVelocity.x, myRigidbody.velocity.y, newVelocity.z);

        roatation = roatation + Input.GetAxis("Mouse X");
        transform.rotation = Quaternion.Euler(new Vector3(0.0f, roatation, 0.0f));

        camRotation = camRotation - Input.GetAxis("Mouse Y") * camRoatationSpeed;

        camRotation = Mathf.Clamp(camRotation, -40.0f, 40.0f);

        cam.transform.localRotation = Quaternion.Euler(new Vector3(camRotation, 0.0f, 0.0f));
    }
}
