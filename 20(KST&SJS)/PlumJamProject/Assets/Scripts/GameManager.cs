using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public TextSet textSet;
    public int stageIndex;

    public int coin;

    //몇번째 Scene인지
    public static int SceneNum = 1;
    public void nextStage()
    {
        SceneManager.LoadScene(SceneNum);
        SceneNum++;

    }
}
