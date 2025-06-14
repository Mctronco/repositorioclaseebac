using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjericioModulo9 : MonoBehaviour
{

    int numeroRandom = 0;

    // Start is called before the first frame update
    void Start()
    {
        int[] miArreglo1 = new int[10];
        int[] miArreglo2 = new int[10];
        int[] miArreglo3 = new int[1];

        numeroRandom = Random.Range(0, 10);

        for (int i = 0; i < miArreglo1.Length; i++)
        {
            miArreglo1[i] = numeroRandom + i;
        }
        for (int i = 0; i < miArreglo2.Length; i++)
        {
            miArreglo2[i] = numeroRandom + i;
        }
        for (int i = 0; i < miArreglo3.Length; i++)
        {
            miArreglo3[i] = miArreglo1[i] * miArreglo2[i];
            Debug.Log(miArreglo3[i]);
        }

        
        string[] miFrase = new string[] { "Hola", "a", "mi", "tutor", "del", "curso", "de", "EBAC" };
        string miFraseCompleta = "";

        foreach (string frase in miFrase)
        {
            miFraseCompleta += frase + " ";
        }
        
        Debug.Log (miFraseCompleta);

        
        int[,] miMatrizMultidimensional = new int[2, 3] { 
            { 1, 2, 3 }, 
            { 4, 5, 6 } };
       
        int[] miMatrisUnidimensional = new int[] { 7, 8, 9 };

        int[] resultado = new int[miMatrizMultidimensional.GetLength(0)];

        
        for (int i = 0; i < miMatrizMultidimensional.GetLength(0); i++)
        {
            for (int j = 0; j < miMatrizMultidimensional.GetLength(1); j++)
            {
                resultado[i] += miMatrizMultidimensional[i, j] * miMatrisUnidimensional[j];
                Debug.Log(resultado[i]);
            }
           
        }
        
       

        











    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
