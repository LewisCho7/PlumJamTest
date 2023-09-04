using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.Search;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class GameControl : MonoBehaviour
{
    [SerializeField] TMP_InputField field;
    [SerializeField] TextMeshProUGUI checkedInputText;
    [SerializeField] TextMeshProUGUI gameTitle;
    public GameObject btn;
    string[] correctAnswer = { "Attention", "Cookie", "Ditto", "ETA", "Super Shy" };
    

    public VideoPlayer video;
    public VideoPlay videoPlay;
    
    public VideoClip[] videoClips;

    RectTransform rect;
    
    int videoIndex = 0;
    int clipIndex = 0;

    void Awake()
    {
        
        rect = videoPlay.rect;
        
        foreach (var clips in videoClips) {
            if (clips == null)
            {
                videoClips[clipIndex] = clips;
                clipIndex++;
                break;
            }
        }

        clipIndex = 0;
    }

    // Start is called before the first frame update
    void Start()
    {
        checkedInputText.text = "";
        gameTitle.text = "노래 2초 듣고 제목 맞추기";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            CheckInputText(field.text);
            //Debug.Log(field.text);
        }
    }

    public void PlayGame()
    {
        rect.localScale = Vector3.zero;
        video.Play();
        Invoke("StopVideo", 2f);
        checkedInputText.text = "정답을 입력하세요";
    }

    public void CheckInputText(string fieldText)
    {
        //Debug.Log(fieldText.Length);
        //Debug.Log(correctAnswer.Length);
        if (fieldText == correctAnswer[videoIndex])
        {
            checkedInputText.text = "정답입니다!";
            Invoke("ViewVideo",3);
        }
        else
        {
            checkedInputText.text = "오답입니다.";
            Invoke("ViewVideo", 3);
        }
    }

    public void ViewVideo()
    {
        rect.localScale = Vector3.one;
        gameTitle.text = correctAnswer[videoIndex];
        PlayVideo();
        Invoke("StopVideo", 5f);
        Invoke("NextRound", 6f);
    }

    public void NextRound()
    {
        checkedInputText.text = "정답을 입력하세요";
        field.text = "";
        videoIndex++;
        clipIndex++;
        if (clipIndex >= 5)
            btn.SetActive(true);
        video.clip = videoClips[clipIndex];
    }

    public void PlayVideo()
    {
        video.Play();
    }
    public void StopVideo()
    {
        rect.localScale = Vector3.zero;
        video.Stop();
        gameTitle.text = "노래 2초 듣고 제목 맞추기";
    }

    
}
