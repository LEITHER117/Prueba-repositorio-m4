using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejerciciosdeciclosyarreglos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //ejercicio 1
        int num = 1;
        int[] a1 = new int[num];
        int[] a2 = new int[num];
        int[] a3 = new int[num];

        for (int i = 0; i < num; i++)
        {
            a1[i] = Random.Range(0, 10);
            a2[i] = Random.Range(0, 10);
            a3[i] = a1[i] + a2[i];
        }
        Debug.Log("numero 1: " + string.Join(", ", a1));
        Debug.Log("numero 2: " + string.Join(", ", a2));
        Debug.Log("resultado suma: " + string.Join(", ", a3));

        //ejercicio 2
        string[] palabras = { "hola", "soy", "emanuel", "y estudio", "en EBAC" };
        string oracion = "";

        foreach (string palabra in palabras)
        {
            oracion += palabra + " ";
        }
        Debug.Log("oracion completa: " + oracion.Trim());

        //ejercicio 3
        int[,] matriz = new int[2, 3]
        {
            {1,2,3},
            {4,5,6}
        };
        int[] vector = { 7, 8, 9 };
        int[] resultado = new int[2];
        for (int x = 0; x < 2; x++)
        {
            int suma = 0;
            for (int y = 0; y < 3; y++)
            {
                suma += matriz[x, y] * vector[y];
            }
            resultado[x] = suma;
        }
        Debug.Log("resultado de matriz * vector: " + string.Join(", ", resultado));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
