using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Boss : MonoBehaviour
{
    public FamilyTree ft;
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
            Destroy(gameObject);
            
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator ilkstagebitti()
    {
        ft.questcounter = 1;
        yield return new WaitForSeconds(6f);
        SceneManager.LoadScene("SoyAgaci");    
    }


}
