using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonEventHandler : MonoBehaviour
{
        // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onTeacherClick()
    {
        staticGlobalVariables.next_scene = 1;
        Application.LoadLevel(2);
    }

    public void onStudentClick()
    {
        staticGlobalVariables.next_scene = 3;
        Application.LoadLevel(2);
    }
}
