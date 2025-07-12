using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class color : MonoBehaviour
{ 
    public GameObject cubo;
    public bool v1;
    

    // Start is called before the first frame update
    void Start()
    {
       
    }
    private void FixedUpdate()
    {

        v1 = !v1;
        if (cubo != null)
        {
            Renderer renderer = cubo.GetComponent<Renderer>();
            if (v1 == true)
            {
                renderer.material.color = Color.white;
            }
            else
            {
                renderer.material.color = Color.black;
            }
            switch (v1)
            {
                case true:
                    Debug.Log("blanco");
                    break;
                case false:
                    Debug.Log("negro");
                    break;
            }
        }


    }

    // Update is called once per frame
    void Update()
    {
        //Color c = new Color(Random.value, Random.value, Random.value);
        //GetComponent<MeshRenderer>().material.color = c;

    }
}
