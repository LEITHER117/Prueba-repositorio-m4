using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p3 : MonoBehaviour
{
    public p1 p1;
    public p2 p2;
    public GameObject esfera;
    public bool v3;
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
        if (p1 != null && p2 != null)
        {
            v3 = p1.v1 && p2.v2;
            if (esfera != null)
            {
                esfera.GetComponent<Renderer>().material.color = v3 ? Color.green : Color.red;
            }
        }
    }
}
