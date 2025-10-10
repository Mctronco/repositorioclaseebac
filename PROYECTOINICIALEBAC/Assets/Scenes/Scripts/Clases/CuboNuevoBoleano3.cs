using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboNuevoBoleano3 : MonoBehaviour
{
    bool CuboNuevoBoleano;
    bool CuboNuevoBoleano2;

    // A B  OR  AND
    // 1 1   1   1
    // 1 0   1   0
    // 0 1   1   0
    // 0 0   0   0
    // 

    // Start is called before the first frame update
    void Start()
    {
        CuboNuevoBoleano = true;
        CuboNuevoBoleano2 = false;
        if (CuboNuevoBoleano && CuboNuevoBoleano2)
        {
            GetComponent<MeshRenderer>().material.color = Color.white;
            Debug.Log("La operacion dio resultado Verdadero");
        }
        else
        {
            GetComponent<MeshRenderer>().material.color = Color.black;
            Debug.Log("La operacion dio resultado Falso");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
