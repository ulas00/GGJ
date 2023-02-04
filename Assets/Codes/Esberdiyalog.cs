using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esberdiyalog : MonoBehaviour
{
    public GameObject esberd1;
    public GameObject esberd2;
    public int diyalogsyc = 0;
    void Start()
    {
        
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0)&& diyalogsyc == 0)
        {
            StartCoroutine(esberlog1());
            
        }
        if (Input.GetMouseButtonDown(0) && diyalogsyc == 1)
        {
            StartCoroutine (esberlog2());
            
        }
    }
    void Update()
    {
        
    }
    IEnumerator esberlog1()
    {
        esberd1.SetActive(true);
        yield return new WaitForSeconds(4f);
        esberd1.SetActive(false);
        diyalogsyc = 1;
    }
    IEnumerator esberlog2()
    {
        esberd2.SetActive(true);
        yield return new WaitForSeconds(4f);
        esberd2.SetActive(false);
    }
}
