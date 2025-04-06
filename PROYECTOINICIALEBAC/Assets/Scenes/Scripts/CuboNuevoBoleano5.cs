using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboNuevoBoleano5 : MonoBehaviour
{
    bool CuboNuevoBoleano3;
    bool CuboNuevoBoleano4;

    // A B  OR  AND
    // 1 1   1   1
    // 1 0   1   0
    // 0 1   1   0
    // 0 0   0   0
    // 
    // Start is called before the first frame update
    void Start()
    {
        CuboNuevoBoleano3 = true;
        CuboNuevoBoleano4 = false;
        if (CuboNuevoBoleano3 && CuboNuevoBoleano4)
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
