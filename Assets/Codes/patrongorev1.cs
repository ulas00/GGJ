using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class patrongorev1 : MonoBehaviour
{
    public GameObject dabanca;
    public GameObject diyalog1;
    public bool diyalogbasladi = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnMouseOver()
    {
        if (Input.GetMouseButton(0)&& diyalogbasladi == false)
        {
            diyalogbasladi=true;
            
            StartCoroutine(firstdialog());
        }
    }

    IEnumerator firstdialog()
    {
        diyalog1.SetActive(true);
        yield return new WaitForSeconds(5f);
        diyalog1.SetActive(false);
        dabanca.SetActive(true);
    }
}
