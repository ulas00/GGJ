using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class S4Stop : MonoBehaviour
{
    public GameObject gameobject;
    public AudioSource audio1;
    public TMP_Text storyText;
    private string text1 = "Koray, Oray'ı perişan halde bulur. Ona \"Üzülme, o hergelenin canına okiycaz.\" der. \"Çözüm kayanın altında kardeşim.\" diye ekler.";
    void Start()
    {
        storyText.text = text1;
        Time.timeScale= 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Time.timeScale = 1;
            gameobject.SetActive(false);
        }
    }
}
