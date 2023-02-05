using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zactivate : MonoBehaviour
{
    public GameObject benjaminbutton;
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        StartCoroutine(buttonincoming());
    }

    IEnumerator buttonincoming()
    {
        yield return new WaitForSeconds(4f);
        benjaminbutton.SetActive(true);

    }
    
}
