using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DisplaySettings : MonoBehaviour
{
  
    public Text speedDisplay;
    public static int speedValue;

    public Text sizeDisplay;
    public static int sizeDisplayValue;

    public Text timeLeftDisplay;
    public static float timeLeft = 60;


    // Start is called before the first frame update
    void Start()
    {
        sizeDisplay.fontSize = sizeDisplayValue;
        sizeDisplay.text = "Sample Size";

        speedDisplay.text = speedValue.ToString();
    }

    // Update is called once per frame
    void Update()
    {

        timeLeft -= Time.deltaTime;

        timeLeftDisplay.text = "" + timeLeft.ToString("00") + " Seconds";

        if (timeLeft < 0)
        {
            SceneManager.LoadScene("4Exit");
        }

    }
}
