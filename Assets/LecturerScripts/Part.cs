using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Part : MonoBehaviour
{
    public Text displayName;
    public GameObject physical;

    // Start is called before the first frame update
    private bool vanished;
    private bool highlighted;
   // private string name;   for some reason the var name already exists
   
    public Part(int id, string name)
    {
        this.vanished = false;
        this.highlighted = true;
        this.name = name;
        displayName.text = name;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool IsHighlighted()
    {
        return highlighted;
    }

    public bool IsVanished()
    {
        return vanished;
    }

    public void ToggleHighlight()
    {
        highlighted = !highlighted;
    }

    Color LightGray = new Color(30, 30, 30,50);
    Color TransWhite = new Color(255, 255, 255, 46);
  //  private defCol = GetComponent<Image>().color;
    public void ToggleVanish()
    {
        vanished = !vanished;

        if (vanished)
        {
            GetComponent<Image>().color = LightGray;
        }
        else
        {
            GetComponent<Image>().color = TransWhite;
        }
        var parent = physical.transform.parent;
        PhotonView photonView = parent.GetComponent<PhotonView>();
        photonView.RPC("toggleChildVisibility", RpcTarget.All, physical.name, !vanished);
        //physical.SetActive(!vanished);
    }



    public void UnVanish()
    {
        vanished = true;
         GetComponent<Image>().color = TransWhite;
    }

    public void UnHighlight()
    {
        highlighted = false;
    }

    public string GetName()
    {
        return this.name;
    }

    public void SetName(string newname)
    {
        name = newname;
    }



    
}
