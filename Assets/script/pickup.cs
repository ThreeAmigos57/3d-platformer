using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{

    public GameObject has_script;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider Other)
    {
        has_script.GetComponent<objectivemanager>().ObjectiveCompleted();
        Destroy(gameObject);
    }

    
}
