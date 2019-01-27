using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    //public GameObject[] parts;
    public GameObject entryPrefab;
    public Transform scroll;
    public Part[] tempParts;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addPart(Transform part)
    {
        var entry = Instantiate(entryPrefab, scroll);
        entry.GetComponent<Part>().physical = part.gameObject;
    }

    public void setList(Part[] parts)
    {
        tempParts = parts;
      //  int n = 0;
        foreach (var part in parts)
        {
            GameObject entry = Instantiate(entryPrefab, transform);
          //  n++;
        }
    }

    public void ShowAll()
    {
        foreach (var part in tempParts)
        {
            part.UnVanish();
        }
    }

    public void UnHighilightAll()
    {
        foreach (var part in tempParts)
            part.UnHighlight();
    }
}
