using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p2 : MonoBehaviour
{
    public bool v2;
    public GameObject capsula;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        v2 = !v2;

        if (capsula != null)
        {
            capsula.GetComponent<Renderer>().material.color = v2 ? Color.white : Color.black;
        }
    }
}
