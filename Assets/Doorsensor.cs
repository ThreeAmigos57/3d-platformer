using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doorsensor : MonoBehaviour
{
   public movingdoor myDoor;

   private void OnTriggerEnter(Collider other)
   {
		  if(other.tag == "Player")
		  {
			myDoor.isOpen = true;
		  }
   }
}
