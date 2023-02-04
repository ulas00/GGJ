using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class FamilyTree : MonoBehaviour
{
    public int questcounter = 0;
    public Button firstq;
    public Button secondq;
    public Button thirdq;
    public GameObject ft;
    void Start()
    {
        if (questcounter == 0)
        {
            firstq.onClick.AddListener(() => firstqueststarter());
        }
        if (questcounter == 1)
        {
            secondq.onClick.AddListener(() => secondqueststarter());
        }
        //if (questcounter == 2)
        //{
        //    third.onClick.AddListener(() => thirdqueststarter());
        //}

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void firstqueststarter()
    {
        SceneManager.LoadScene(2, LoadSceneMode.Additive);
        questcounter = 1;
        ft.SetActive(false);

    }
    public void secondqueststarter()
    {
        SceneManager.LoadScene("S2", LoadSceneMode.Additive);
    }
    //public void thirdqueststarter()
    //{
    //SceneManager.LoadScene("S3", LoadSceneMode.Additive);
    //}
}
