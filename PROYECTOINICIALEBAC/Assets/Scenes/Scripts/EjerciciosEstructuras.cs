using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosEstructuras : MonoBehaviour

{
    
   

    // Start is called before the first frame update
    void Start()
    {
        List<int> miFuncion(int tamaño, int rangoInferior, int rangoSuperior)
        {
            List<int> listaNumeros = new List<int>();

            for (int i = 0; i < tamaño; i++)
            {
                // Especifica UnityEngine.Random
                listaNumeros.Add(UnityEngine.Random.Range(rangoInferior, rangoSuperior));
            }

            return listaNumeros;
        }
        List<int> miLista = miFuncion(10, 0, 20);
        Debug.Log(string.Join(", ", miLista));

        int[] OrdenarDescendente(int[] arreglo)
        {
            int[] copia = (int[])arreglo.Clone();
            Array.Sort(copia);
            Array.Reverse(copia);
            return copia;
        }
        int[] misNumeros = { 3, 8, 1, 5 };
        int[] ordenados = OrdenarDescendente(misNumeros);
        Debug.Log("Original: " + string.Join(", ", misNumeros));
        Debug.Log("Ordenados (descendente): " + string.Join(", ", ordenados));

        List<string> listaStrings = new List<string> { "Capa", "Mascara", "Botas", "Short", "Muñequeras", "Mascara", "Short" };
        HashSet<string> QuitarRepetidos(List<string> lista) { return new HashSet<string>(lista); }
        HashSet<string> sinRepetidos = QuitarRepetidos(listaStrings);
        Debug.Log(string.Join(", ", sinRepetidos));

        Stack<string> miPila = new Stack<string>();
        miPila.Push("Ataque 1");
        miPila.Push("Ataque 2");
        miPila.Push("Defensa 1");
        miPila.Push("Defensa 2");
        miPila.Push("Remate Final");

        ProcesarPilaYCola(miPila);
    }
    void ProcesarPilaYCola(Stack<string> pilaOriginal)
    {
        Queue<string> cola = new Queue<string>();

        while (pilaOriginal.Count > 0)
        {
            string elemento = pilaOriginal.Peek();
            Debug.Log("De pila (Peek): " + elemento);

            elemento = pilaOriginal.Pop();
            Debug.Log("De pila (Pop): " + elemento);

            cola.Enqueue(elemento);
        }

        while (cola.Count > 0)
        {
            Debug.Log("De cola (Peek): " + cola.Peek());
            Debug.Log("De cola (Dequeue): " + cola.Dequeue());
        }




        // Update is called once per frame
        void Update()
        {

        }



    }
}
