using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableBool : MonoBehaviour
{
    public bool isTrue;
    



    // Start is called before the first frame update
    void Start()
    {
        if (isTrue == false) //Si "isTrue" es falso:
        {

            //Cambiar valor
            isTrue = true;

            //Cambio de color a blanco
            GetComponent<MeshRenderer>().material.color = Color.white;
            Debug.Log("el color seleccionado es blanco");
        }
        else //Si "isTrue" es verdadero:
        {
            //Cambiar valor
            isTrue = false;

            //Cambio de color a negro
            GetComponent<MeshRenderer>().material.color = Color.black;
            Debug.Log("el color seleccionado es negro");
        }



    }



    // Update is called once per frame
    void Update()
    {
       
        
        
    }
}
