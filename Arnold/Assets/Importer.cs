using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
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
        //string path = EditorUtility.OpenFilePanel("Select the object to import", "", "obj");
        //GameObject[] objs = reader.ConvertFile(path, true);
        //foreach (var obj in objs)
        //{
        //    obj.transform.SetParent(root);
        //}
    }

    public void LoadEngine()
    {
        var parent = PhotonNetwork.Instantiate("EnginePrefab", Vector3.zero, Quaternion.EulerAngles(0, 0, 0), 0);

        for (int i = 0; i < parent.transform.childCount; i++)
        {
            var child = parent.transform.GetChild(i);
            child.gameObject.AddComponent<Part>();
            UIManager.addPart(child);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
