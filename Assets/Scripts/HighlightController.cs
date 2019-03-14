using Photon.Pun;
using UnityEngine;

public class HighlightController : MonoBehaviour
{

    private HighlightObject highlightObject;
    public TrackGameObject labelPanel;

    private void Start()
    {
        labelPanel.gameObject.SetActive(false);
    }

    public void SelectObject(HighlightObject highlightObject)
    {
        var parent = highlightObject.transform.parent;
        var photonView = parent.GetComponent<PhotonView>();


        if (this.highlightObject == highlightObject)
        {
            photonView.RPC("stopHighightChild", RpcTarget.All, highlightObject.name);
            labelPanel.gameObject.SetActive(false);
            this.highlightObject = null;
        }
        else
        {
            labelPanel.gameObject.SetActive(true);
            if (this.highlightObject != null)
            {
                photonView.RPC("stopHighightChild", RpcTarget.All, this.highlightObject.name);
            }

            this.highlightObject = highlightObject;
            labelPanel.textbox.text = this.highlightObject.name;
            photonView.RPC("startHighightChild", RpcTarget.All, this.highlightObject.name);
            labelPanel.TrackObject = highlightObject.gameObject;
        }
    }

}