using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubo : MonoBehaviour
{
    public GameObject PrefabCubo;

    private void Awake()
    {
        GameObject  tempGameObject = Instantiate<GameObject>(PrefabCubo);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
