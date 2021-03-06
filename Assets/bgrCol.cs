﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bgrCol : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    float timeLeft;
    Color targetColor;
    // Update is called once per frame

    void Update()
    {
        var image = GetComponent<Image>();
        if (timeLeft <= Time.deltaTime)
        {
            image.color = targetColor;

            targetColor = new Color(Random.value, Random.value, Random.value);
            timeLeft = 2.0f;
        }
        else
        {
            image.color = Color.Lerp(image.color, targetColor, Time.deltaTime / timeLeft);
            image.CrossFadeAlpha(0.6f, 0f, true);
            timeLeft -= Time.deltaTime;
        }
    }


}
