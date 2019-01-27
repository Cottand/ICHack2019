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

    [PunRPC]
    public void toggleChildVisibility(string childName, bool active)
    {
        var child = transform.Find(childName);
        Debug.Log(childName);
        if (child != null)
        {
            child.gameObject.SetActive(active);
        }
    }

    [PunRPC]
    public void startHighightChild(string childName)
    {
        var child = transform.Find(childName);
        if(child != null)
        {
            //var ob = GameObject.Find("Manager").GetComponent<HighlightController>();
            //ob.labelPanel.gameObject.SetActive(true);
            child.GetComponent<HighlightObject>().StartHighlight();
        }
    }

    [PunRPC]
    public void stopHighightChild(string childName)
    {
        var child = transform.Find(childName);
        if (child != null)
        {
            //var ob = GameObject.Find("Manager").GetComponent<HighlightController>();
            //ob.labelPanel.gameObject.SetActive(false);
            child.GetComponent<HighlightObject>().StopHighlight();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
