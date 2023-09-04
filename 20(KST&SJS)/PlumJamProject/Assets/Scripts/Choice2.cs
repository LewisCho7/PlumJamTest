using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Choice2_ : MonoBehaviour
{
    TextMeshProUGUI choice2;
    public GameObject talkPanel;
    public GameObject choice;
    // Start is called before the first frame update
    void Start()
    {
        choice2 = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (InterviewText.interviewNum == 1)
        {
            
            choice2.text = "돈을 버는 것도 좋지만, 많은 경험을 쌓고 싶기때문입니다.";
            
        }
        else if(InterviewText.interviewNum == 2)
        {
            choice2.text = "저는 성실하고 목표를 이룰 수 있는 사람입니다.";
        }
        else if (InterviewText.interviewNum == 3)
        {
            choice2.text = "뉴진스 보고 싶다..";
        }
    }

    public void Choice2()
    {
        if (InterviewText.interviewNum == 1)
        {
            Likeability.likeability += 10;
        }
        else if (InterviewText.interviewNum == 2)
        {
            Likeability.likeability += 20;
        }
        else if (InterviewText.interviewNum == 3)
        {
            Likeability.likeability -= 20;
        }
            InterviewText.choiceText = choice2.text;
        talkPanel.SetActive(true);
        InterviewText.isTalking = true;
        choice.SetActive(false);
    }
}
