using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class finalscore : MonoBehaviour
{
    public Text FinalText;
    public Text Score;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        FinalText.text = "Score = " + Score.text;
        Score.enabled = false;
    }
}
