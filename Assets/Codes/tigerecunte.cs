using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class tigerecunte : MonoBehaviour
{
    public GameObject gameobject;
    public TMP_Text storyText;
    public AudioSource audio1;
    public int tigereCount;
    private string text1 = "Moray Bey aslanları püskürtmüştür. Ancak sevgili evladının ihanetini kaldıramadığı için vefat etmiştir.";
    void Start()
    {
        gameobject.SetActive(false);
        tigereCount = 0;
    }
    public void Update()
    {
        if(tigereCount == 5)
        {
            Time.timeScale = 0;
            gameObject.SetActive(true);
            storyText.text = text1;
            audio1.Play();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            Time.timeScale = 1;
            gameobject.SetActive(false);
        }
    }
}

