
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingdoor : MonoBehaviour
{
    public bool isOpen = false;

    public Transform door;
    public Transform startingpoint;
    public Transform EndPoint;

    public bool doorisOpen;

    private void Start()
    {
        door.position = startingpoint.position;
    }

    private void Update()
    {
        if (isOpen == true)
        {
            door.position = Vector3.MoveTowards(door.position, EndPoint.position, Time.deltaTime);
            doorisOpen = true;
        }

        // if(doorisOpen == true)
        // {
        //     door.position = Vector3.MoveTowards(door.position, startingpoint.position, Time.deltaTime);
        // }
    }

}
