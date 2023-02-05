using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class esbergorev : MonoBehaviour
{
    public GameObject esbergorev1;
    public GameObject esbergorev2;
    public GameObject esbergorev3;
    public GameObject esberfircasi;
    public bool gorev1yapildi = false;
    public bool gorev2yapildi = false;  
    
    void Start()
    {
        
    }
    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0)&&gorev1yapildi == false)
        {
            
            StartCoroutine(esberfirca());
            esberfircasi.SetActive(true);

        }
        
        if(Input.GetMouseButton(0)&& gorev1yapildi == true)
        {
            esbergorev2.SetActive(false);
            esbergorev3.SetActive(true);
            gameObject.SetActive(false);    
        }

    }

    void Update()
    {
        
    }
    IEnumerator esberfirca()
    {
        esbergorev1.SetActive(true);
        yield return new WaitForSeconds(4f);
        esbergorev1.SetActive(false);
    }

}
