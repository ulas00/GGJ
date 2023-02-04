using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Camera cam;
	public Animator anim;
	public Cow cowSc;
    public float damage = 1f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
			anim.SetTrigger("Shoot");
			RaycastHit hit;
			if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, 50f))
			{
				if (hit.transform.name == "Cow")
				{
					cowSc.TakeDamage(damage);
				}
			}
		}
    }
}
