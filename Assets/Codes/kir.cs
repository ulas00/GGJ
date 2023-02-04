using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kir : MonoBehaviour
{
    public bool fircalaniyor;
    public float fircalanmazamani = 3.0f;
    public int fircasayisi = 0;
    

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
                fircasayisi++;
                Destroy(gameObject);
            }


        }
        if(fircasayisi >= 4)
        {
            //18 saat sonra texti girecek
            Destroy(GameObject.FindGameObjectWithTag("kir"));
        }

    }
}
