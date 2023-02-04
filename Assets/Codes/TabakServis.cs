using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabakServis : MonoBehaviour
{
    public GameObject et;
    public Transform HoldingTransform2;
    public float range2 = 3f;
    public float Go2 = 100f;
    public Camera came;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            StartPickUp();
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            Drop();
        }
    }

    void StartPickUp()
    {
        RaycastHit hit;
        if (Physics.Raycast(came.transform.position, came.transform.forward, out hit, range2))
        {
            
            if (et != null)
            {
                PickUp();
            }
        }
    }

    void PickUp()
    {
        et.transform.SetParent(HoldingTransform2);
    }

    void Drop()
    {
        HoldingTransform2.DetachChildren();
    }
}
