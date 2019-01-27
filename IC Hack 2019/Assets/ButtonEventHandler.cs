using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    public void onEnterClick(string scene)
    {
        if(scene == "Lecturer")
        {
            NetworkManager.CreateRoom();
        }
        SceneManager.LoadScene(scene);
    }
}
