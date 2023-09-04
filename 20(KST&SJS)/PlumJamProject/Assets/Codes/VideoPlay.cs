using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoPlay : MonoBehaviour
{    
    public RectTransform rect;
 
    void Awake()
    {
        rect = GetComponent<RectTransform>();
    }
}
