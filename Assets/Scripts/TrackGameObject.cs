using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TrackGameObject : MonoBehaviour
{

    public Text textbox;
    public GameObject TrackObject;
    public Vector3 Offset;

    void Update()
    {
        if (TrackObject != null)
        {
            gameObject.transform.position = Camera.main.WorldToScreenPoint(
                TrackObject.transform.position) + Offset;
        }
    }

}