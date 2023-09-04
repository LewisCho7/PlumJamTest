using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPage : MonoBehaviour
{
    public RectTransform rectPage;
    // Start is called before the first frame update
    void Awake()
    {
        rectPage = GetComponent<RectTransform>();
    }
}
