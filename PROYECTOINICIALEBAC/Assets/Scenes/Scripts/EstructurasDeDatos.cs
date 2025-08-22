using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class EstructurasDeDatos : MonoBehaviour
{
    List<int> listaNumeros = new List<int>();
    List<string> listaStrings = new List<string>();
    HashSet<int> hashSetInts = new HashSet<int>();
    Queue<string> colaStrings = new Queue<string>();
    Stack<string> pilaString = new Stack<string>();
    Dictionary<string,float> poderArmas = new Dictionary<string,float>();


    // Start is called before the first frame update
    void Start()
    {
        DemoDictionary("escopeta");
        DemoDictionary("espada");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DemoListas()
    {
        for (int i = 0; i < 10; i++)
        {
            listaNumeros.Add(Random.Range(0, 20));
        }
        foreach (var numero in listaNumeros)
        {
            Debug.Log(numero);
        }
        //listaNumeros.Sort();
        var listaOrdenada = listaNumeros.OrderBy(p => p).ToList();
        var listaConValoresGrandes = listaNumeros.Where(p => p > 10).ToList();
        Debug.Log("lista base");
        foreach (var numero in listaNumeros)
        {
            Debug.Log(numero);
        }
        listaStrings.Add("Diego");
        listaStrings.Add("Sofia");
        listaStrings.Add("Daniel");
        listaStrings.Add("Javier");
        listaStrings.Add("Diana");
        foreach (var nombre in listaStrings)
        {
            Debug.Log(nombre);
        }
        listaStrings.RemoveAt(2);
        foreach (var nombre in listaStrings)
        {
            Debug.Log(nombre);
        }
    }

    public void DemoColas()
    {
        ///First in First Out => FIFO

        colaStrings.Enqueue("Proyectil 1");
        colaStrings.Enqueue("Proyectil 2");
        colaStrings.Enqueue("Proyectil 3");
        colaStrings.Enqueue("Proyectil 4");
        colaStrings.Enqueue("Proyectil 5");
        Debug.Log(colaStrings.Peek());
        colaStrings.Dequeue();
        Debug.Log(colaStrings.Peek());
        colaStrings.Dequeue();
        Debug.Log(colaStrings.Peek());
        colaStrings.Dequeue();
        Debug.Log(colaStrings.Peek());
        colaStrings.Dequeue();
    }

    public void DemoPilas()
    {

        ///First in Last Out=> FILO

        pilaString.Push("As");
        pilaString.Push("CincoEspadas");
        pilaString.Push("TresCorazones");
        pilaString.Push("CuatroTrebol");
        pilaString.Push("ReyEspadas");
        Debug.Log(pilaString.Peek());
        pilaString.Pop();
        Debug.Log(pilaString.Peek());
        pilaString.Pop();
        Debug.Log(pilaString.Peek());
        pilaString.Pop();
        Debug.Log(pilaString.Peek());
        pilaString.Pop();
    }
    public void DemoDictionary(string arma)
    {
        float temporal = 0;
        if (!poderArmas.ContainsKey("rifle"))
        {
            poderArmas.Add("rifle", 7.0f);
        }
        if (!poderArmas.ContainsKey("pistola"))
        {
            poderArmas.Add("pistola", 3.0f);
        }
        if (!poderArmas.ContainsKey("escopeta"))
        {
            poderArmas.Add("escopeta", 5.0f);
        }
        if (!poderArmas.ContainsKey("rifleFrancotirador"))
        {
            poderArmas.Add("rifleFrancotirador", 10.0f);
        }
        if (!poderArmas.ContainsKey("cuchillo"))
        {
            poderArmas.Add("cuchillo", 2.0f);
        }
        if (poderArmas.TryGetValue(arma, out temporal))
        {
            Debug.Log(temporal);
        }
        else
        {
            Debug.Log("esa arma no existe");
        }
    }

}
