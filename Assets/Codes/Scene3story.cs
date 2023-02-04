using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Scene3story : MonoBehaviour
{
    public GameObject gameobject;
    public TMP_Text storyText;

    #region StoryTexts
    private string text1 = "Moray Bey'in lokanta zinciri çığ gibi büyümektedir. Nuray ile evlenir. Bu evlilikten nur gibi ikizleri Oray ve Koray doğar. ";
    private string text2 = "Moray Bey iyi niyetinden Eşber'i evlatlık edinir. Ona öz oğlu gibi bakar. Eşber Bey'in ona oyun oynadığından bihaberdir.\r\nEşber Bey, Moray Bey'e \"Tepeye kadar yarışalım babacım der\". Moray Bey tepeye koşar.";
    private string text3 = "Moray Bey aslanları püskürtmüştür. Ancak sevgili evladının ihanetini kaldıramadığı için vefat etmiştir.";
    private string text4 = "Yorulmuşum babacım, birazdan sana yetişirim";//geri donuste event text

    #endregion

    private void Start()
    {
        Time.timeScale = 0;
        storyText.text = text1;//giristeki hikaye
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))//sahne  text 2
        {
            gameobject.SetActive(true);
            storyText.text = text2;
            Time.timeScale = 0;
        }

        if (Input.GetKeyDown(KeyCode.U))//aslanlari kestikten sonra gelen text
        {
            gameobject.SetActive(true);
            storyText.text = text3;
            Time.timeScale = 0;
        }

        if (Input.GetKeyDown(KeyCode.L))//esbere donerse
        {
            gameobject.SetActive(true);
            storyText.text = text4;
            Time.timeScale = 0;
        }

        if (Input.GetKeyDown(KeyCode.Mouse0)) //cikis icin 
        {
            Time.timeScale = 1;
            gameobject.SetActive(false);
        }

    }
}
