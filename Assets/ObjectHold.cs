using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHold : MonoBehaviour
{
    public GameObject Obj;
    public Transform HoldingTransform;
    public float range = 3f;
    public float Go = 100f;
    public Camera cam;
   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            StartPickUp();
        }
        if (Input.GetKeyUp(KeyCode.F))
        {
            Drop();
        }
    }

    void StartPickUp()
    {
        RaycastHit hit;
        if (Physics.Raycast(cam.transform.position,cam.transform.forward,out hit, range))
        {
            Cow target = hit.transform.GetComponent<Cow>();
            if (target != null && target.health <= 0)
            {
                PickUp();
            }
        }
    }
    
    void PickUp()
    {
        Obj.transform.SetParent(HoldingTransform);
    }
    
    void Drop()
    {
        HoldingTransform.DetachChildren();
    }
}
