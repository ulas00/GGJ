using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kir : MonoBehaviour
{
    public bool fircalaniyor;
    public float fircalanmazamani = 3.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(fircalaniyor == true)
        {
            fircalanmazamani -= Time.deltaTime;
            if(fircalanmazamani < 0)
            {
                fircalanmazamani = 0;
                Destroy(gameObject);
            }


        }

    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "firca")
        {
            Debug.Log("fircalaniyo");
            fircalaniyor = true;
        }
        else
        {
            fircalaniyor = false;
        }
    }
}
