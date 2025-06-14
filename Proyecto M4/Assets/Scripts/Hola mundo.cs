using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Holamundo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("HOLA DESDE UPDATE");
    }
    private void FixedUpdate()
    {
        Debug.LogError("HOLA DESDE FIXEDUPDATE");
    }
    private void LateUpdate()
    {
        Debug.Log("HOLA DESDE LATEUPDATE");
    }
    private void OnEnable()
    {
        Debug.LogWarning("HOLA DESDE ONENABLE");
    }
    private void OnDisable()
    {
        Debug.LogWarning("HOLA DESDE ONDISABLE");
    }
}
