using System.Collections;
using System.Collections.Generic;

using System.Runtime.ConstrainedExecution;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class coloresfera : MonoBehaviour
{
    public GameObject cubo;
    public GameObject capsula;
    public GameObject esfera;
    
    // Start is called before the first frame update
    void Start()
    {
      

        //Color c = new Color(Random.value, Random.value, Random.value);
        //GetComponent<MeshRenderer>().material.color = c;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (cubo != null &&  capsula != null)
        {
            bool a = cubo.GetComponent<color>().v1;
            bool b = capsula.GetComponent<colorcapsula>().v1;
            Renderer render = esfera.GetComponent<Renderer>();
            if (a && b)
            {
                render.material.color = Color.green;
            }
            else
            {
                render.material.color = Color.red;
            }
        }
    
    }
}
