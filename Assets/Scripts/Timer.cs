using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    float currentTime = 0;
    float startingTime = 60;

    [SerializeField] TextMeshProUGUI countdownText;


    void Start()
    {
        currentTime = startingTime;
    }

    void Update()
    {
        currentTime -= 1*Time.deltaTime;

        countdownText.text = currentTime.ToString("0");

        if(currentTime <= 0)
        {
            SceneManager.LoadScene("Win");
        }
    }
}
