using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPlayerDetails : MonoBehaviour
{
    private string input;

    public void StorePlayerName(string inputName){
        //Store player
        //input = inputName
        Debug.Log(inputName);

        MainManager.Instance.playerName = inputName;
    }
}
