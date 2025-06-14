using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prueba : MonoBehaviour
{
    int x;
    // Start is called before the first frame update
    void Start()
    {
        x = 0;
        print("Algo pasó");
        
        Debug.LogWarning("Algo salió medianamente mal");
        Debug.LogError("Algo salió mal");
    }

    // Update is called once per frame
    void Update()
    {
        x = x + 1;
        Debug.Log(x);
    }
}
