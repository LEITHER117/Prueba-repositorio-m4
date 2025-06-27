using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawncubos : MonoBehaviour
{
    public GameObject PrefabCubo;
    public List<GameObject> ListaDeCubos;
    public float FactorDeEscalamiento;
    public int numCubos = 0;


    // Start is called before the first frame update
    void Start()
    {
        ListaDeCubos = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        numCubos++;
        GameObject tempGameObject = Instantiate<GameObject>(PrefabCubo);
        tempGameObject.name = "CuboNumero" + numCubos;
        Color c = new Color(Random.value, Random.value, Random.value);
        tempGameObject.GetComponent<MeshRenderer>().material.color = c;
        tempGameObject.transform.position = Random.insideUnitSphere;

        ListaDeCubos.Add(tempGameObject);
        List<GameObject> ObjetosParaEliminar = new List<GameObject>();
        foreach (GameObject go in ListaDeCubos)
        {
            float scale = go.transform.localScale.x;
            scale *= FactorDeEscalamiento;
            go.transform.localScale = Vector3.one * scale;

            if (scale <= 0.1)
            {
                ObjetosParaEliminar.Add(go);
            }
        }

        foreach (GameObject go in ObjetosParaEliminar)
        {
            ListaDeCubos.Remove(go);
            Destroy(go);
        }
    }
}
