using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class CuboNuevoBoleano : MonoBehaviour
{

    int valor1 = 5;
    
    int limiteInferior = 0;
    
    int limiteSuperiro = 2;

    enum SeleccionColor
    {
        blanco,
        negro,
    }
    
    // Start is called before the first frame update
    void Start()
    {
        valor1 = Random.Range(limiteInferior, limiteSuperiro);
        Debug.Log(valor1);
        if (valor1 >= 0)
        {
            GetComponent<MeshRenderer>().material.color = Color.white;
            Debug.Log("la variable 1 es verdadera");
        }
        if (valor1 >= 1)
        {
            GetComponent<MeshRenderer>().material.color = Color.black;
            Debug.Log("el valor es negativo");
        }

        string resultado = (valor1 >= 0) ? "el valor es positivo" : "el valor es negativo";
        Debug.Log(resultado);
        switch (valor1)
        {
            case (int)SeleccionColor.blanco:
                Debug.Log("el color seleccionado es blanco");
                break;
            case (int)SeleccionColor.negro:
                Debug.Log("el color seleccionado es negro");
                break;


        }
       


    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
