using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayFinalStat : MonoBehaviour
{


    public Text finalScore;
    public Text finalLives;
    public Text finalName;

    // Start is called before the first frame update
    void Start()
    {
        finalName.text = "Name: " + GameManager.userName;
        finalScore.text = "Score: " + ScoreKeeper.newScore.ToString();
        finalLives.text = "Lives: " + LivesTracker.lives.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
