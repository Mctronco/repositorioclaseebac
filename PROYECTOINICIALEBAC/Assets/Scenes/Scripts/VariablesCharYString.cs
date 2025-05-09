using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesCharYString : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        char c = '6';
        int valorEntero = 0;
        if (!int.TryParse(c.ToString(), out valorEntero))
        {
            Debug.LogError("ese no es un tipo de valor valido");
        }
        Debug.Log(valorEntero);

        char miCaracter;
        string miString = "Hola desde EBAC";
        string miSegundoString = miString.ToUpper();
        string tercerString = miString + " " + miSegundoString;
        string ejemploEscape = "C:\\Users\\Diego\\Documentos";
        miCaracter = miString[13];
        string miNombre = "Diego";
        string misApellidos = "Hernandez Reyes";
        string primerApellido = misApellidos.Substring(0, 9);
        string salidasuma = "mi nombre es: " + miNombre + " y mis apellidos son " + misApellidos; 
        string salida = $"Mi nombre es: {miNombre} Y mis apellidos son {misApellidos}";
        int longitud = miString.Length;
        Debug.Log(salida);
        Debug.Log(primerApellido);

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
