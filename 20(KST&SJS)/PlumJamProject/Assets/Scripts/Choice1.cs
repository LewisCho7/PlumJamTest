using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Choice1_ : MonoBehaviour
{
    TextMeshProUGUI choice1;
    public GameObject talkPanel;
    public GameObject choice;
    public static bool onOff;
    // Start is called before the first frame update
    void Start()
    {
        choice1 = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (InterviewText.interviewNum == 1)
        {
            choice1.text = "������ �ܼ�Ʈ �������ߵǼ� ���� ������մϴ�.";
        }
        else if (InterviewText.interviewNum == 2)
        {
            choice1.text = "���� �÷��Դϴ�.";
        }
        else if (InterviewText.interviewNum == 3)
        {
            choice1.text = "�̾��ֽŴٸ� ������ ���ϰڽ��ϴ�.";
        }
    }

    public void Choice1()
    {
        if (InterviewText.interviewNum == 1)
        {
            Likeability.likeability -= 10;
        }
        else if (InterviewText.interviewNum == 2)
        {
            Likeability.likeability -= 20;
        }
        else if (InterviewText.interviewNum == 3)
        {
            Likeability.likeability += 20;
        }

        InterviewText.choiceText = choice1.text;
        talkPanel.SetActive(true);
        InterviewText.isTalking = true;
        choice.SetActive(false);
    }
}
