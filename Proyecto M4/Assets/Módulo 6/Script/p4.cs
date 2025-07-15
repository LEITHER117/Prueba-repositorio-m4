using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p4 : MonoBehaviour
{
    public p1 p1;
    public p2 p2;
    public GameObject esfera2;
    public bool v4;
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
        if (p1 != null || p2 != null)
        {
            v4 = p1.v1 || p2.v2;
            if (esfera2 != null)
            {
                esfera2.GetComponent<Renderer>().material.color = v4 ? Color.green : Color.red;
            }
        }
    }
}
