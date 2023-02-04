using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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
            StartCoroutine(ilkstagebitti());
            
            
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator ilkstagebitti()
    {
        Cursor.lockState = CursorLockMode.None;
        yield return new WaitForSeconds(6f);
        SceneManager.LoadScene("SoyAgaci");
        
    }


}
