using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class singwithme : MonoBehaviour
{
    public GameObject kratosvideo;
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "player")
        {
            kratosvideo.SetActive(true);
            StartCoroutine(kratosfallvideo());
        }

    }

    void Update()
    {
        
    }
    
    IEnumerator kratosfallvideo()
    {

        yield return new WaitForSeconds(27f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


}
