using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class esber3end : MonoBehaviour
{
    public GameObject video;

    void Start()
    {
        StartCoroutine(videostarter());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator videostarter()
    {

        yield return new WaitForSeconds(1.5f);
        video.SetActive(true);
        StartCoroutine(scenender());

    }

    IEnumerator scenender()
    {

        yield return new WaitForSeconds(4.2f);
        SceneManager.LoadScene("SoyAgaci");
        Cursor.lockState = CursorLockMode.None;
    }

}
