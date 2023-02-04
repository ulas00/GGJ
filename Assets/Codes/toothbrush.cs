using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toothbrush : MonoBehaviour
{
    public GameObject nokta1;
    public GameObject nokta2;
    public float fircalamahizi = 3.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            transform.position = Vector3.Lerp(nokta1.transform.position, nokta2.transform.position, Mathf.PingPong(Time.time * fircalamahizi, 1.0f));
        }

    }
}
