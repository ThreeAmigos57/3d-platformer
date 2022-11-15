using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider Other)
    {
        Destroy(gameObject);
    }

    
}
