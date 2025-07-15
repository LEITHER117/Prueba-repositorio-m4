using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p5 : MonoBehaviour
{
    public p3 p3;
    public p4 p4;
    public GameObject cilindro;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        if (p3 != null && p4 != null)
        {
            bool v5 = p3.v3 && p4.v4;
            if (cilindro != null)
            {
                cilindro.GetComponent<Renderer>().material.color = v5 ? Color.yellow : Color.black;
            }
        }
    }
}
