using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public float bosshp = 4f;
    public GameObject kutlama;
    void Start()
    {
        
    }
    public void TakeDamage(float damage)
    {
        bosshp -= damage;
        if (bosshp <= 0)
        {
            kutlama.SetActive(true);
            Destroy(gameObject);
            
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
