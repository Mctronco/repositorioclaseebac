using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class EjerciciosVariablesMod8 : MonoBehaviour
{
    sbyte miByteConSigno = 0;
    byte miByte = 0;
    short miShort = 0;
    ushort miShortSinSigno = 0;
    int miInt = 20;
    uint miIntSinSigno = 0;
    long miLong = long.MaxValue;
    ulong miLongSinSigno = 0;
    public string CambioColor;

    // Start is called before the first frame update
    void Start()
    {
        miLong = long.MaxValue;
        miInt = (int)miLong;
        Debug.Log("el valor de miInt es: " + miInt);


        float a, b;
        float f;
        int c, d, h;
        a = 10;
        b = 2;
        c = 20;
        d = 1;
        f = a / b;
        Debug.Log(f);
        
        miInt = Random.RandomRange(c, d);
        string miPar = "Par";
        string miNon = "Non";
        string miBlanco = "Blanco";
        string miNegro = "Negro";
        string non = $"El numero es: {miPar} Y su color es {miBlanco}";
        string par = $"El numero es: {miNon} Y su color es {miNegro}";
        

        if (miInt % 2 == 0)
        {
            GetComponent<MeshRenderer>().material.color = Color.white;
            Debug.Log("el numero" + miInt + "es par");
        }
        else
        {
            GetComponent<MeshRenderer>().material.color = Color.black;
            Debug.Log("el numero" + miInt + "es non");
        }

        

        switch (CambioColor)
        {
            case "blanco":
                
                Debug.Log("El color es blanco");
                GetComponent<MeshRenderer>().material.color = Color.white;
                break;
            case "negro":
                
                Debug.Log("el color es negro");
                GetComponent<MeshRenderer>().material.color = Color.black;
                break;
        }





        char e = '6';
        int valorEntero = 0;
        if (!int.TryParse(e.ToString(), out valorEntero))
        {
            Debug.LogError("ese no es un tipo de valor valido");
        }
        Debug.Log(valorEntero);

        char j = '9';
        int valorEntero2 = 0;
        if (int.TryParse(j.ToString(),out valorEntero2))
        {
            Debug.LogError("ese no es un tipo de valor valido");
        }
        Debug.Log(valorEntero2);

        int k;
        k = valorEntero * valorEntero2;
        Debug.Log(k);

        
        float g = 8.14558f;

        Debug.Log(g.ToString("F4"));




        string miString = "Hola a mi Tutor";
        char[] delimitador = { ' '};
        string[] espacios = miString.Split(delimitador);
        int i;
        for (i=0;i < espacios.Length; i++)
        {
            Debug.Log(espacios[i]);
        }


        
        string fraseEnPar = "Esta frase se separa en par";
        

        for(i = 0; i <fraseEnPar.Length; i++)
        {
                if (i % 2 == 0)
            {
                Debug.Log(fraseEnPar[i] + "");
            }
        }
        



        string miNombreCompleto = "Fernando Castellanos Lopez";
        string miNombre = miNombreCompleto.Substring(0, 8);
        string primerApellido = miNombreCompleto.Substring(9, 11);
        string segundoApellido = miNombreCompleto.Substring(21, 5);
        string salidaNombre = $"mi nombre es: {miNombre} y mis apellidos son: {primerApellido} {segundoApellido}";
        Debug.Log(salidaNombre);

        string miFrase = "Hola amigos";
        string miQuienes = miFrase.Substring(5, 6);
        Debug.Log(miQuienes);

        


        miShort += 3;
        Debug.Log(miShort);

       

        


    }

    // Update is called once per frame
    void Update()
    {

        int a, b;
        float f;
        a = 5;
        b = 10;

        f = a + b;

        f *= 3;
        Debug.Log(f);

        


    }
}
