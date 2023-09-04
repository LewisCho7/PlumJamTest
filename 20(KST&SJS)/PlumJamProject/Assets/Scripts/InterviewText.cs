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
        
        
        
        myText.text = "\"�ٻ�\"������ �����մϴ�.";
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
            myText.text = "�� ���� ������ ������ ������?";
            choice.SetActive(true);
        }
        else if (interviewNum == 2)
        {
            myText.text = "������ ������ ����� �����ϳ���?";
            choice.SetActive(true);
            talkPanel.SetActive(false);
        }
        else if (interviewNum == 3)
        {
            myText.text = "���������� �ϰ� ���� �� �ֳ���?";
            choice.SetActive(true);
            talkPanel.SetActive(false);
        }
    }
}

