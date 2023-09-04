using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Likeability : MonoBehaviour
{
    TextMeshProUGUI myText;
    public static int likeability = 50;
    // Start is called before the first frame update
    void Start()
    {
        myText = GetComponent<TextMeshProUGUI>();
    }
    void Update()
    {
        myText.text = "È£°¨µµ : " + likeability.ToString();
    }

    
}
