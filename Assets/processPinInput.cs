using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class processPinInput : MonoBehaviour
{
    public Button myButton;
    public Text buttonText;
    public InputField roomNo;

    // Start is called before the first frame update
    void Start()
    {
        myButton = GetComponent<Button>();
        buttonText = GetComponentInChildren<Text>();
        myButton.onClick.AddListener(ProcessPin);
    }

    void ProcessPin()
    {
        buttonText.text = "Joining session...";
        myButton.enabled = false;
        staticGlobalVariables.roomName = roomNo.text;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
