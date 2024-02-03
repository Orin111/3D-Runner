using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public TMP_Text text;
    public ScoreManager miles;
    private void OnEnable()
    {
        text.text = "You run " + miles.miles + " m \nbefore turning into a fine mist.";
    }
}
