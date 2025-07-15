using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variablesBooleanas : MonoBehaviour
{
    bool variable1;
    bool variable2;
    bool variable3;
    int valor1 = 5;
    int limiteInferior =0;
    int limiteSuperior =1;
    
    enum SeleccionColor
    {
        rojo,
        verde,
        azul,
        blanco,
        gris,
    }

    // a b c   or   and ((a or b) and c)  ((a or b) or c)
    // 1 1 1   1      1        1                 1
    // 1 1 0   1      0        0                 1
    // 1 0 1   1      0        1                 1
    // 1 0 0   1      0        0                 1
    // 0 1 1   1      0        1                 1
    // 0 1 0   1      0        0                 1
    // 0 0 1   1      0        0                 1
    // 0 0 0   0      0        0                 0

    // Start is called before the first frame update
    void Start()
    {
        variable1 = true;
        variable2 = false;
        variable3 = false;
        if ((variable1 || variable2) && variable3)
        {
            Debug.Log("la operacion 1 es verdadero");
        }
        if ((variable1 || variable2) || variable3)
        {
            if (variable1)
            {
                Debug.Log("la variable 1 es verdadera");
            }
            Debug.Log("la operacion 2 es verdadero");
        }
        if ((variable3 && variable2) || variable1)
        {
            Debug.Log("la operacion 3 es verdadera");
        }
        if (valor1<=5)
        {
            Debug.Log("el valor de la variable es menor a 5 o igual");
            
        }

        valor1 = Random.Range(limiteInferior, limiteSuperior);
        Debug.Log(valor1);
        //if (valor1 >= 0)
        //{
        //    Debug.Log("el valor es positivo");
        //}
        //else
        //{
        //    Debug.Log("el valor es negativo");
        //}

        string resultado = (valor1 >= 0) ? "el valor es positivo" : " el valor es negativo";
        Debug.Log(resultado);
        //switch(valor1)
        //{
        //    case (int) SeleccionColor.rojo:
        //        Debug.Log("el color seleccionado es rojo");
        //        break;
        //    case (int) SeleccionColor.verde:
        //        Debug.Log("el color seleccionado es verde");
        //        break;
        //    case (int) SeleccionColor.azul:
        //        Debug.Log("el color seleccionado es azul");
        //        break;
        //    case (int) SeleccionColor.blanco:
        //        Debug.Log("el color seleccionado es blanco");
        //        break;
        //    case (int) SeleccionColor.gris:
        //        Debug.Log("el color seleccionado es gris");
        //        break;
        //    default:
        //        Debug.Log("ese valor no existe");
        //        break;

        //}


    }
   

    // Update is called once per frame
    void Update()
    {
        
    }
}

