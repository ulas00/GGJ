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
    public Button fourthq;
    public GameObject ft;
    void Start()
    {
        firstq.onClick.AddListener(() => firstqueststarter());

        secondq.onClick.AddListener(() => secondqueststarter());

        thirdq.onClick.AddListener(() => thirdqueststarter());

        fourthq.onClick.AddListener(() => fourthqueststarter());


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void firstqueststarter()
    {
        SceneManager.LoadScene(2, LoadSceneMode.Single);
        questcounter = 1;
        ft.SetActive(false);

    }
    public void secondqueststarter()
    {
        SceneManager.LoadScene("S2", LoadSceneMode.Single);
    }
    public void thirdqueststarter()
    {
        SceneManager.LoadScene("S3", LoadSceneMode.Single);
    }
    public void fourthqueststarter()
    {
        SceneManager.LoadScene("S4", LoadSceneMode.Single);
    }
}
