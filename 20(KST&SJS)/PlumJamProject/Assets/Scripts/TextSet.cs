using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using KoreanTyper;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;



public class TextSet : MonoBehaviour
{
    public GameObject nextBtn;
    public GameObject newjeansMosaic;
    public GameObject talkPanel;
    public GameObject choice;
    //���
    string originText;
    TextMeshProUGUI myText;

    //�� ��° �������
    int Dialog_Count = 0;

    // Start is called before the first frame update
    void Start()
    {
        myText = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        // Prologue�� ��� & ���
        if (Input.GetKeyDown(KeyCode.Space) && GameManager.SceneNum == 1)
        {
            if (Dialog_Count == 0)
            {
                myText.text = "2023�� ��� ������...\n-�÷�-";
                StartCoroutine(TypingRoutine());
            }
            else if (Dialog_Count == 1)
            {
                myText.text = "??? : �� �����ε� �Ұ� �ϳ��� ����.. ��Ʃ�곪 ���߰ڴ�..";
                StartCoroutine(TypingRoutine());
            }
            else if (Dialog_Count == 2)
            {
                myText.text = "??? : ��ķ..? �̰� ����?";
                StartCoroutine(TypingRoutine());
            }
            else if (Dialog_Count == 3)
            {
                myText.text = "??? : �� ���� �̰�";
                newjeansMosaic.SetActive(true);
                StartCoroutine(TypingRoutine());
            }
            else if (Dialog_Count == 4)
            {
                myText.text = "??? : �׷� ����߾�..";
                StartCoroutine(TypingRoutine());
            }
            else if (Dialog_Count == 5)
            {
                myText.text = "??? : �� �̹��븦 ���� ���߰ھ�!";
                StartCoroutine(TypingRoutine());
            }
            else if (Dialog_Count == 1)
            {
                nextBtn.SetActive(true);
            }
        }

        // Start�� ��� & ���
        if (Input.GetKeyDown(KeyCode.Space) && GameManager.SceneNum == 2)
        {
            if (Dialog_Count == 0)
            {
                myText.text = "�� ������ �̷�������.. �ʹ� ���ݾ�..";
                StartCoroutine(TypingRoutine());
            }
            else if (Dialog_Count == 1)
            {
                myText.text = "��..? ��?! �� �뷡��????";
                StartCoroutine(TypingRoutine());
            }
            else if (Dialog_Count == 2)
            {
                nextBtn.SetActive(true);
            }
        }

        // AfterMusicQuiz�� ��� & ���
        if (Input.GetKeyDown(KeyCode.Space) && GameManager.SceneNum == 4)
        {
            if (Dialog_Count == 0)
            {
                myText.text = "���� ������!";
                StartCoroutine(TypingRoutine());
            }
            else if (Dialog_Count == 1)
            {
                myText.text = "�ܼ�Ʈ�� ������ ���� �������";
                StartCoroutine(TypingRoutine());
            }
            else if (Dialog_Count == 2)
            {
                myText.text = "�˹� �����̳� �����غ���?";
                StartCoroutine(TypingRoutine());
            }
            else if (Dialog_Count == 3)
            {
                nextBtn.SetActive(true);
            }
        }

        //Interview��
        if (Input.GetKeyDown(KeyCode.Space) && GameManager.SceneNum == 5 && InterviewText.isTalking)
        {
            

            if (InterviewText.interviewNum == 1)
            {
                myText.text = InterviewText.choiceText;
                StartCoroutine(TypingRoutine());
                InterviewText.isTalking = false;
                InterviewText.interviewNum++;

            }
            else if (InterviewText.interviewNum == 2)
            {
                myText.text = InterviewText.choiceText;
                StartCoroutine(TypingRoutine());
                InterviewText.isTalking = false;
                InterviewText.interviewNum++;
            }
            else if (InterviewText.interviewNum == 3)
            {
                myText.text = InterviewText.choiceText;
                StartCoroutine(TypingRoutine());
                InterviewText.isTalking = false;
                InterviewText.interviewNum++;
            }
            else if (InterviewText.interviewNum == 4)
            {
                nextBtn.SetActive(true);
            }
        }

        if (Input.GetKeyDown(KeyCode.Space) && GameManager.SceneNum == 7) {
            if (Dialog_Count == 0)
            {
                myText.text = "�׷��� ���� ������ �Ǿ���.";
                StartCoroutine(TypingRoutine());
            }
            if (Dialog_Count == 1)
            {
                myText.text = "����";
                StartCoroutine(TypingRoutine());
            }

        }

            IEnumerator TypingRoutine() // Ÿ���� �ڷ�ƾ
        {
            originText = myText.text;
            int typingLength = originText.GetTypingLength();

            for (int index = 0; index <= typingLength; index++)
            {
                myText.text = originText.Typing(index);
                yield return new WaitForSeconds(0.05f);
            }

            Dialog_Count++;
        }
    }
}
