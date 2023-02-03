using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cow : MonoBehaviour
{
    public float health = 3f;
    public Animator anim;

    public void TakeDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            anim.SetBool("Die", true);
        }
    }
}
