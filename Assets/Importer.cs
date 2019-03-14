using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;
using Photon.Pun;

public class Importer : MonoBehaviour
{
    public ObjReader reader;
    public Transform root;
    public UIManager UIManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Import()
    {
        string path = EditorUtility.OpenFilePanel("Select the object to import", "", "obj");
        path = "Engine";
        string name = Path.GetFileNameWithoutExtension(path);
        
        var parent = PhotonNetwork.Instantiate(name, Vector3.zero, Quaternion.EulerAngles(0, 0, 0), 0);

        for (int i = 0; i < parent.transform.childCount; i++)
        {
            var child = parent.transform.GetChild(i);
            child.gameObject.AddComponent<Part>();
            UIManager.addPart(child);
        }
    }

    public void LoadEngine()
    {


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
