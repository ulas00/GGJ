using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cow : MonoBehaviour
{
    public float health = 3f;
    public Animator anim;
    public GameObject etpisir;
    public GameObject dabancadevredisi;
    public GameObject diyalog2;
    public void TakeDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            anim.SetBool("Die", true);
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Ocak")
        {
            StartCoroutine(inekpisir());
        }
    }
    IEnumerator inekpisir()
    {
        diyalog2.SetActive(true);
        yield return new WaitForSeconds(3f);
        etpisir.SetActive(true);
        dabancadevredisi.SetActive(false);
        diyalog2.SetActive(false);
        Destroy(gameObject);
        
    }
}
