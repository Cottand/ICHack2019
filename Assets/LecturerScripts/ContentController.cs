using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContentController : MonoBehaviour
{

    public Part EntryTemplate;

    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        // I'll do some shortcuts here yay
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //Something to reset views
           /* if (canvas.gameObject.activeInHierarchy == false)
            {
                canvas.gameObject.SetActive(true);
                Time.timeScale = 0;
            }
            else
            {
                canvas.gameObject.SetActive(false);
                Time.timeScale = 1;
            } */
        }

    }

    public void AddToContent(Part go)
    {
        var newEntry = Instantiate(EntryTemplate, transform);
        
    }

    public struct MyPart
    {
        public string name;
        public int id;

    }
    /*
    public List<Part> GetPartsArray()
    {
            List<Part> list = new List<MyPart>();
            foreach (Transform child in transform)
            {
                Part otherPart = child.gameObject.GetComponent<Part>();
                if (otherPart.IsVanished) continue;
                list.Add(otherPart);
            }
            return MyPart;
        } */
    

}
