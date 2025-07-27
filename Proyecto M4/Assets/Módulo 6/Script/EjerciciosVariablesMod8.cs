using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EjerciciosVariablesMod8 : MonoBehaviour
{
    public GameObject plane;
    int valor1 = 0;
    float valor2 = 1.2f;
    float resultado;
    int PoN = 0;

    // Start is called before the first frame update
    void Start()
    {
        // ejercicio 2
        float a, b;

        a = 5.3f;
        b = 3.6f;

        resultado = a + b;
        int r = (int)resultado;
        Debug.Log("El resultado es " + r);

        // ejercicio 5
        float pi = 3.14159265359f;
        string rpi = pi.ToString("f4");
        Debug.Log("El numero pi es " + rpi);

        // ejercicio 6
        string MiNombre = "José Emanuel Macías Gutiérrez";
        string PrimerNombre = MiNombre.Substring(0, 4);
        string SegundoNombre = MiNombre.Substring(5, 8);
        string Apellidos = MiNombre.Substring(13);
        Debug.Log("Primer Nombre: " + PrimerNombre);
        Debug.Log("Segundo Nombre: " + SegundoNombre);
        Debug.Log("Apellidos: " + Apellidos);
        
        string[] partes = MiNombre.Split(' ');
        Debug.Log(partes[0]);
        Debug.Log(partes[1]);
        Debug.Log(partes[2]);
        Debug.Log(partes[3]);

        // ejercicio 7
        string v1 = "15342";
        string v2 = "24875";
        int n1 = int.Parse(v1);
        int n2 = int.Parse(v2);
        int x = n1 + n2;
        Debug.Log("El resultado de la operación es: "+x);

        // ejercicio 8
        string frase = "Si la vida te da limones";
        for (int i = 0; i < frase.Length; i++)
        {
            if (i % 2 == 0)
            {
                Debug.Log(frase[i]);
            }
        }

        // ejercicio 9
        string j = "parangaracutirimicuaro";
        string k = j.Substring(5);
        Debug.Log("el resultado de j es: " + k);
    }

    void FixedUpdate()
    {
        // ejercicio 1
       valor1 ++;
        Debug.Log("valor1 es de "+valor1);
       
       valor2 *= valor2;
        Debug.Log("valor2 es de "+valor2);

        // ejercicio 3 y 4
        int x, y;
        x = 1;
        y = 50;
        
       PoN = Random.Range(x,y);
        
        string tipo = (PoN % 2 == 0) ? "Par" : "Non";
        Debug.Log(PoN + " es " +tipo);
        switch (tipo)
        {
            case "Par":
                gameObject.GetComponent<Renderer>().material.color = Color.yellow;
                break;
            case "Non":
                gameObject.GetComponent<Renderer>().material.color = Color.blue;
                break;
        }



    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
