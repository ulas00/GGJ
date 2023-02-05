using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startinggame : MonoBehaviour
{
    public GameObject warning;
    void Start()
    {
        StartCoroutine(startingwarning());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator startingwarning()
    {
        yield return new WaitForSeconds(4.0f);
       warning.SetActive(false);
    }

}
