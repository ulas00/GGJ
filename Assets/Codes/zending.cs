using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class zending : MonoBehaviour
{
    public Button endsieg;

    
    void Start()
    {
        endsieg.onClick.AddListener(() => gobackmenu());    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void gobackmenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
