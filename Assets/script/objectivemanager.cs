using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        
        if (object_count == 2)
        {
            SceneManager.LoadScene(2);
            Cursor.lockState = CursorLockMode.None;
        }

    }

    public void ObjectiveCompleted()
    {
        object_count += 1;
    }

}
