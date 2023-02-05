using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kir : MonoBehaviour
{
    public bool fircalaniyor;
    public float fircalanmazamani = 3.0f;
    public kirbabü kirBabü;
    


    void Update()
    {
        if(fircalaniyor == true)
        {
            fircalanmazamani -= Time.deltaTime;
            if(fircalanmazamani < 0)
            {
                fircalanmazamani = 0;
                kirBabü.kirsayac++;
                
                Destroy(gameObject);
            }
        }
    }
}
