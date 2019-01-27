using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Imported : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene().name == "Student")
        {
            Debug.Log("trying to root");
            var root = GameObject.Find("ImageTarget").transform;
            transform.SetParent(root);
            transform.rotation = Quaternion.EulerAngles(0, 0, 0);
            transform.position = Vector3.zero;
        }
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
