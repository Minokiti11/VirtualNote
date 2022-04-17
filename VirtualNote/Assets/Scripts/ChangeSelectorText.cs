using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSelectorText : MonoBehaviour
{
    public Text text;
    string[] AllPlayers = new string[] { "GK", "CB1", "CB2", "RSB", "LSB", "CMF1", "CMF2", "DMF", "RWG", "LWG", "CF" }; // 4-3-3
    public int PlayerNum = 0;
    private string PlayerPosition;

    void Update()
    {
        text.text = AllPlayers[PlayerNum];
    }
    public void Plus()
    {
        if (PlayerNum == 10)
        {
            PlayerNum = 0;
        }
        else
        {
            PlayerNum ++;
        }
    }
    public void Minus()
    {
        if (PlayerNum == 0)
        {
            PlayerNum = 10;
        }
        else
        {
            PlayerNum --;
        }
    }
}
