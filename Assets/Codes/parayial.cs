using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class parayial : MonoBehaviour
{
    public TMP_Text parasayaci;
    public GameObject finalgorev;
    public GameObject dabancaktif;
    public Gorev grvsc;
    void Start()
    {
        
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0)&&grvsc.gorevsayaci == 3 )
        {
            parasayaci.text = "Para : 10000";
            finalgorev.SetActive(true);
            dabancaktif.SetActive(true);
            Destroy(gameObject);
        }
    }
    void Update()
    {
        
    }
}
