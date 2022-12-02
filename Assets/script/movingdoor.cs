
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingdoor : MonoBehaviour
{
    public bool isOpen = false;

    public Transform door;
    public Transform startingpoint;
    public Transform EndPoint;

    public Doorsensor Door;

    private void Start()
    {
        startingpoint.position = door.position;
    }

    private void Update()
    {
        if (isOpen == true)
        {
            door.position = Vector3.MoveTowards(door.position, EndPoint.position, Time.deltaTime);

        }
        if(Door.closingdoor == true)
        {
            isOpen = false;
            door.position = Vector3.MoveTowards(door.position, startingpoint.position, Time.deltaTime);
            Debug.Log("Closing Door");
        }

        // if(doorisOpen == true)
        // {
        //     door.position = Vector3.MoveTowards(door.position, startingpoint.position, Time.deltaTime);
        // }
    }

}
