using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Ticketing : MonoBehaviour
{
    //public GameObject ticketing;

    [SerializeField] TMP_InputField fieldCaptcha;
    public Captcha captcha;
    public FirstPage firstPage;
    public SecondPage secondPage;

    public RectTransform rectFirstPage;
    public RectTransform rectSecondPage;
    public RectTransform rectCap;
    //public RectTransform rectImage;

    public bool isDateClicked = false;
    public bool isRSVClicked = false;      //reservation click
    public bool isSeatClicked = false;
    public bool isFinishClicked = false;

    //string correctCaptcha = "PLUMJAM";

    void Awake()
    {
        //rectImage = GetComponent<RectTransform>();
        rectCap = GetComponent<RectTransform>();
        rectFirstPage = GetComponent<RectTransform>();
        rectSecondPage = GetComponent<RectTransform>();
        rectFirstPage = firstPage.rectPage;
        rectSecondPage = secondPage.rectPage;
        rectCap = captcha.rectCaptcha;
        captcha.HideCaptcha();
        rectSecondPage.localScale = Vector3.zero;
        //rectCap.localScale = Vector3.zero;
    }

    /*
    // Start is called before the first frame update
    void Start()
    {
        rectCap = captcha.rectCaptcha;
    }
    */

    // Update is called once per frame
    public void Update()
    {
        if (isDateClicked && isRSVClicked)
        {
            captcha.ShowCaptcha();
            isRSVClicked = false;
            isDateClicked = false;
        }

        if (Input.GetKeyDown(KeyCode.Return))
            checkCaptcha(fieldCaptcha.text);

        if (isSeatClicked && isFinishClicked)
        {
            NextScene();
            isSeatClicked = false;
            isFinishClicked = false;
            //Scene 넘기기
        }
    }

    public void ButtonDateClick()
    {
        Debug.Log("clickeddate");
        isDateClicked = true;
    }
    public void ButtonReservationClick()
    {
        Debug.Log("clickedRSV");
        isRSVClicked = true;
    }

    public void BUttonSeatClick()
    {
        Debug.Log("clicked seat");
        isSeatClicked = true;
    }

    public void ButtonFinishClick() {
        Debug.Log("clicked Finish");
        isFinishClicked = true;
    }

    public void checkCaptcha(string captchaText)
    {
        Debug.Log("check");
        if(captchaText == "PLUMJAM")
        {
            Debug.Log("checkif");
            HidePage1();   
        }
        else
            fieldCaptcha.text = "";
    }

    public void HidePage1()
    {
        Debug.Log("HidePage1");
        rectFirstPage.localScale = Vector3.zero;
        ShowPage2();
    }

    void ShowPage2()
    {
        rectSecondPage.localScale = Vector3.one;
    }

    public void NextScene()
    {
        Debug.Log("마지막 씬으로 이동");

    }
}
