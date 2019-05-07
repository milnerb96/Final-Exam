using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public Dropdown myDropdown;
    public Toggle myToggle;
    public Slider mySlider;
    public Text speedText;
    public Text sizeText;

    public static string sliderValue;
    public static string sizeDisplay;

    public InputField newInput;
    public static string userName;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (myToggle.isOn)
        {
            speedText.gameObject.SetActive(false);
            sizeText.gameObject.SetActive(false);
            myDropdown.gameObject.SetActive(false);
            mySlider.gameObject.SetActive(false);
        }

        else if(!myToggle.isOn)
        {
            speedText.gameObject.SetActive(true);
            sizeText.gameObject.SetActive(true);
            myDropdown.gameObject.SetActive(true);
            mySlider.gameObject.SetActive(true);
        }

        if (myDropdown.value == 0)
        {
            DisplaySettings.sizeDisplayValue= 50;
        }

        if (myDropdown.value == 1)
        {
            DisplaySettings.sizeDisplayValue = 75;
        }

        if (myDropdown.value == 2)
        {
            DisplaySettings.sizeDisplayValue = 100;
        }


    }

    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void StopGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }

    public void SaveUserName()
    {
        userName = newInput.text;
        Debug.Log(userName);
    }

    public void GetSliderValue()
    {
        mySlider.value = DisplaySettings.speedValue;
    }
}
