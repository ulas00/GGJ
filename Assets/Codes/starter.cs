using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starter : MonoBehaviour
{
    public GameObject canvas;
  
    // Update is called once per frame
    void Update()
    {
        Destroy(canvas,4f);
    }
}
