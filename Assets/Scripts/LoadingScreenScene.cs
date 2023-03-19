using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class LoadingScreenScene: MonoBehaviour
{
    [SerializeField] private int loadingSpeed;
    [SerializeField] private Slider slider;
    [SerializeField] private TextMeshProUGUI percentage;
    private readonly float _startValue = 0f;
    private readonly float _endValue = 100f;
    private string scene;

    private void Start()
    {
        slider.value = _startValue;
    }

    private void Update()
    {
        scene = SceneManager.GetActiveScene().name;
        if (scene == "LoadingScene")
        {
            slider.value = Mathf.Lerp(_startValue, _endValue, Time.timeSinceLevelLoad/loadingSpeed);
            percentage.text =slider.value.ToString()+ " %";
        }
    }
}