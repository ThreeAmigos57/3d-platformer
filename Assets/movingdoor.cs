using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingdoor : MonoBehaviour
{
    public bool isOpen = false;

    public Transform door;
    public Transform startingpoint;
    public Transform EndPoint;

    private void Start()
    {
        door.position = startingpoint.position;
    }

    private void update()
    {
       if(isOpen == true)
       {
        door.position = Vector3.MoveTowards(door.position,EndPoint.position,Time.deltaTime);
       }
    }   
}
