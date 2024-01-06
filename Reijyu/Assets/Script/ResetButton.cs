using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetButton : MonoBehaviour
{
    public List<GameObject> list = new List<GameObject>();
    public void OnClick()
    {
        foreach (GameObject g in list)
        {
            g.GetComponent<Image>().color = new Color(1, 1, 1);
            g.GetComponent<ButtonControl>().isTap = false;
        }
    }
}