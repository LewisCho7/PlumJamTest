using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class Captcha : MonoBehaviour
{
    public RectTransform rectCaptcha;
    void Awake()
    {
        rectCaptcha = GetComponent<RectTransform>();
    }

    public void ShowCaptcha()
    {
        rectCaptcha.localScale = Vector3.one;
    }
    public void HideCaptcha()
    {
        rectCaptcha.localScale = Vector3.zero;
    }

}
