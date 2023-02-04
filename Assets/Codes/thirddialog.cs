using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thirddialog : MonoBehaviour
{
    public GameObject maas;
    public GameObject diyalog3;
    public Gorev grsc;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0) && grsc.gorevsayaci == 2)
        {
            maas.SetActive(true);
            StartCoroutine(diyaloguc());
            grsc.gorevsayaci = 3;
        }
    }
    IEnumerator diyaloguc()
    {
        diyalog3.SetActive(true);
        yield return new WaitForSeconds(3f);
        diyalog3.SetActive(false);
    }
}
