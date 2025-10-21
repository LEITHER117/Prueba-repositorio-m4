using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosEstructras : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var lista = LlenarListaAleatoria(15, 1, 10);
        Debug.Log("Lista aleatoria: " + string.Join(", ", lista));

        int[] ordenada = OrdenarDescendente(lista.ToArray());
        Debug.Log("Ordenada descendente: " + string.Join(", ", ordenada));

        var sinRepetidos = EliminarRepetidos(lista);
        Debug.Log("Sin repetidos: " + string.Join(", ", sinRepetidos));

        Stack<string> pila = new Stack<string>();
        pila.Push("Odin");
        pila.Push("Thor");
        pila.Push("Freya");
        pila.Push("Loki");
        PilaACola(pila);
    }

    List<int> LlenarListaAleatoria(int tamaño, int rangoInferior, int rangoSuperior)
    {
        var lista = new List<int>();
        var rnd = new System.Random();
        for (int i = 0; i < tamaño; i++) lista.Add(rnd.Next(rangoInferior, rangoSuperior + 1));
        return lista;
    }

    int[] OrdenarDescendente(int[] arreglo)
    {
        var copia = (int[])arreglo.Clone();
        System.Array.Sort(copia);
        System.Array.Reverse(copia);
        return copia;
    }

    HashSet<T> EliminarRepetidos<T>(List<T> lista)
    {
        return new HashSet<T>(lista);
    }

    void PilaACola(Stack<string> pila)
    {
        Queue<string> cola = new Queue<string>();
        Debug.Log("Pila:");
        foreach (var e in pila) Debug.Log(e);

        while (pila.Count > 0)
        {
            string elemento = pila.Peek();
            cola.Enqueue(elemento);
            pila.Pop();
        }

        Debug.Log("Cola:");
        while (cola.Count > 0)
        {
            Debug.Log(cola.Peek());
            cola.Dequeue();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
