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
    //대사
    string originText;
    TextMeshProUGUI myText;

    //몇 번째 대사인지
    int Dialog_Count = 0;

    // Start is called before the first frame update
    void Start()
    {
        myText = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        // Prologue씬 대사 & 기능
        if (Input.GetKeyDown(KeyCode.Space) && GameManager.SceneNum == 1)
        {
            if (Dialog_Count == 0)
            {
                myText.text = "2023년 어느 여름날...\n-플럼-";
                StartCoroutine(TypingRoutine());
            }
            else if (Dialog_Count == 1)
            {
                myText.text = "??? : 아 방학인데 할게 하나도 없네.. 유튜브나 봐야겠다..";
                StartCoroutine(TypingRoutine());
            }
            else if (Dialog_Count == 2)
            {
                myText.text = "??? : 직캠..? 이게 뭐지?";
                StartCoroutine(TypingRoutine());
            }
            else if (Dialog_Count == 3)
            {
                myText.text = "??? : 오 뭐야 이거";
                newjeansMosaic.SetActive(true);
                StartCoroutine(TypingRoutine());
            }
            else if (Dialog_Count == 4)
            {
                myText.text = "??? : 그래 결심했어..";
                StartCoroutine(TypingRoutine());
            }
            else if (Dialog_Count == 5)
            {
                myText.text = "??? : 난 이무대를 직접 봐야겠어!";
                StartCoroutine(TypingRoutine());
            }
            else if (Dialog_Count == 1)
            {
                nextBtn.SetActive(true);
            }
        }

        // Start씬 대사 & 기능
        if (Input.GetKeyDown(KeyCode.Space) && GameManager.SceneNum == 2)
        {
            if (Dialog_Count == 0)
            {
                myText.text = "으 설거지 미루지말걸.. 너무 많잖아..";
                StartCoroutine(TypingRoutine());
            }
            else if (Dialog_Count == 1)
            {
                myText.text = "음..? 어?! 이 노래는????";
                StartCoroutine(TypingRoutine());
            }
            else if (Dialog_Count == 2)
            {
                nextBtn.SetActive(true);
            }
        }

        // AfterMusicQuiz씬 대사 & 기능
        if (Input.GetKeyDown(KeyCode.Space) && GameManager.SceneNum == 4)
        {
            if (Dialog_Count == 0)
            {
                myText.text = "좋아 뉴진스!";
                StartCoroutine(TypingRoutine());
            }
            else if (Dialog_Count == 1)
            {
                myText.text = "콘서트에 가려면 돈을 벌어야지";
                StartCoroutine(TypingRoutine());
            }
            else if (Dialog_Count == 2)
            {
                myText.text = "알바 면접이나 지원해볼까?";
                StartCoroutine(TypingRoutine());
            }
            else if (Dialog_Count == 3)
            {
                nextBtn.SetActive(true);
            }
        }

        //Interview씬
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
                myText.text = "그렇게 나는 성덕이 되었다.";
                StartCoroutine(TypingRoutine());
            }
            if (Dialog_Count == 1)
            {
                myText.text = "끄읕";
                StartCoroutine(TypingRoutine());
            }

        }

            IEnumerator TypingRoutine() // 타이핑 코루틴
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
