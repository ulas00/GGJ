using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toothbrush : MonoBehaviour
{
    public GameObject nokta1;
    public GameObject nokta2;
    public Camera cam;
    public float fircalamahiz = 4.0f;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            transform.position = Vector3.Lerp(nokta1.transform.position, nokta2.transform.position, Mathf.PingPong(Time.time * fircalamahiz, 1.0f));
			RaycastHit hit;
			if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, 50f))
			{
                if (hit.transform.CompareTag("kir"))
                {
                    hit.transform.GetComponent<kir>().fircalaniyor = true;
                }

			}
		}
        

    }
    
}
