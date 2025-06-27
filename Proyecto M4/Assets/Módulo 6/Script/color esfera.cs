using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coloresfera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Color c = new Color(Random.value, Random.value, Random.value);
        GetComponent<MeshRenderer>().material.color = c;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
