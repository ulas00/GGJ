using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Tiger : MonoBehaviour
{
    private NavMeshAgent enemy;
    Transform playerTarget;
    public Animator anim;
    public float health = 3f;
    void Start()
    {
        playerTarget = GameObject.FindGameObjectWithTag("player").transform;
        enemy = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (health > 0)
        {
			enemy.SetDestination(playerTarget.position);
		}
    }
	public void TakeDamage(float damage)
	{
		health -= damage;
		if (health <= 0)
		{
			enemy.enabled = false;
			anim.SetBool("Die", true);
		}
	}
}
