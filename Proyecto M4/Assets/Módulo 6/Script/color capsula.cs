using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorcapsula : MonoBehaviour

{
    public GameObject capsula;
    public bool v1;
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate ()
    {
        v1 = !v1;
        if (capsula != null)
        {
            Renderer renderer = capsula.GetComponent<Renderer>();
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

        //Color c = new Color(Random.value, Random.value, Random.value);
        //GetComponent<MeshRenderer>().material.color = c;
    }

}
