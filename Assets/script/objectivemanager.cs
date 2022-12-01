using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectivemanager : MonoBehaviour
{

    public int object_count = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ObjectiveCompleted()
    {
        object_count += 1;
    }

}
