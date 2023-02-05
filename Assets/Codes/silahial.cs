using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class silahial : MonoBehaviour
{
    public GameObject babadabanca;
    public GameObject babayial;
    public GameObject bababul;
    void Start()
    {
        
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            babayial.SetActive(true);
            babadabanca.SetActive(true);
            bababul.SetActive(false);
            Destroy(gameObject);

        }
    }
    void Update()
    {
        
    }
}
