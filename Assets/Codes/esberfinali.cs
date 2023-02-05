using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class esberfinali : MonoBehaviour
{
    public float esberhp = 5;
    public Animator esbermator;
    public GameObject bravoshinji;
    void Start()
    {
        
    }
    public void TakeDamage(float damage)
    {
        esberhp -= damage;
        if (esberhp <= 0)
        {
            esbermator.SetBool("ded", true);
            StartCoroutine(finalscenegecis());


        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator finalscenegecis()
    {
        bravoshinji.SetActive(true);
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene("SoyAgaciKapanis");
    }
}
