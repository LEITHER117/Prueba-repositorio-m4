using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cuboOnEnable : MonoBehaviour
{
    public GameObject PrefabCubo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        GameObject tempGameObject = Instantiate<GameObject>(PrefabCubo);
    }
}
