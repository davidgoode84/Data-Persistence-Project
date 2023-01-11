using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIBestScore : MonoBehaviour
{
    public TextMeshProUGUI bestScoreText;
    // Start is called before the first frame update
    void Start()
    {
        MainManager.Instance.LoadHighScore();

        Debug.Log("high score is " + MainManager.Instance.highScore);

        if(MainManager.Instance != null){
            if(MainManager.Instance.highScore != 0){
                DisplayHighScore();
            }
            else{
                DisplayName();
            }
        }
        else{
            bestScoreText.text = "Hello, set a high score!";
        }
    }

    void DisplayHighScore(){
        bestScoreText.text = MainManager.Instance.playerName + ", can you beat the high score " 
        + MainManager.Instance.highScore + " by " + MainManager.Instance.highScoreName + "?";
    }

    void DisplayName(){
        bestScoreText.text = MainManager.Instance.playerName + ", set a high score!";
    }
}
