using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doorsensor : MonoBehaviour
{
   public movingdoor myDoor;
   public bool is_range = false;

   private void OnTriggerEnter(Collider other)
   {
		if(other.tag == "Player")
		{
			is_range = true;
		}
   }

	private void OnTriggerExit(Collider other)
	{
		if (other.tag == "Player")
		{
			is_range = false;
		}
	}

    private void Update()
    {


        if (is_range == true && Input.GetKeyDown(KeyCode.E))
        {
			myDoor.isOpen = true;
            //StartCoroutine(Opener());
        }


    }
    //IEnumerator Opener()
    //{
    //    if (myDoor.doorisOpen == true && Input.GetKeyDown(KeyCode.E))
    //    {
    //        myDoor.isOpen = false;
    //        myDoor.doorisOpen = false;
    //    }
    //}
}
