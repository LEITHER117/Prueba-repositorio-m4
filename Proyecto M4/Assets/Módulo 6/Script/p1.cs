using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class p1 : MonoBehaviour
{
    public bool v1;
    public GameObject cubo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        v1 = !v1;

        if (cubo != null)
        {
            cubo.GetComponent<Renderer>().material.color = v1 ? Color.white : Color.black;
        }
    }
}
