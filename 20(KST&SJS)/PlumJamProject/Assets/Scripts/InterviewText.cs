using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InterviewText : MonoBehaviour
{
    TextMeshProUGUI myText;
    public GameObject talkPanel;
    public GameObject choice;

    public static string choiceText;
    public static int interviewNum = 0;
    public static bool isTalking = false;
    
    // Start is called before the first frame update
    void Start()
    {
        myText = GetComponent<TextMeshProUGUI>();
        
        
        
        myText.text = "\"꾸빵\"면접을 시작합니다.";
        interviewNum++;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(!isTalking)
            {
                Interview(interviewNum);
            }
        }
    }

    public void Interview(int interviewNum)
    {
        if (interviewNum == 1)
        {
            myText.text = "이 일을 지원한 이유가 뭔가요?";
            choice.SetActive(true);
        }
        else if (interviewNum == 2)
        {
            myText.text = "본인의 장점을 뭐라고 생각하나요?";
            choice.SetActive(true);
            talkPanel.SetActive(false);
        }
        else if (interviewNum == 3)
        {
            myText.text = "마지막으로 하고 싶은 말 있나요?";
            choice.SetActive(true);
            talkPanel.SetActive(false);
        }
    }
}

