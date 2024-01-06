using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonControl : MonoBehaviour
{
    public bool isTap = false;
    public void OnClick()
    {
        if (!isTap)
        {
            gameObject.GetComponent<Image>().color = new Color(0.4f, 0.4f, 0.4f);
            isTap = true;
        }
        else if (isTap)
        {
            gameObject.GetComponent<Image>().color = new Color(1, 1, 1);
            isTap = false;
        }
    }
}
