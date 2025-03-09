using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboNuevo : MonoBehaviour
{
    public GameObject PrefabCubo;
    public List<GameObject> listaDeCubos;
    public float factorDeEscalamiento;
    public int numCubos = 0;

    public void Awake()
    {
        GameObject tempGameObjet = Instantiate<GameObject>(PrefabCubo);
        tempGameObjet.name = "CuboNumero" + numCubos;
        Color c = new Color(Random.value, Random.value, Random.value);
        tempGameObjet.GetComponent<MeshRenderer>().material.color = c;

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        numCubos++;
        GameObject tempGameObjet = Instantiate<GameObject>(PrefabCubo);
        tempGameObjet.name = "CuboNumero" + numCubos;
        Color c = new Color(Random.value, Random.value, Random.value);
        tempGameObjet.GetComponent<MeshRenderer>().material.color = c;
        tempGameObjet.transform.position = Random.insideUnitSphere;

        listaDeCubos.Add(tempGameObjet);
        List<GameObject> objetosParaEliminar = new List<GameObject>();
        foreach (GameObject go in listaDeCubos)
        {
            float scale = go.transform.localScale.x;
            scale *= factorDeEscalamiento;
            go.transform.localScale = Vector3.one * scale;

            if (scale <= 0.1)
            {
                objetosParaEliminar.Add(go);
            }
    
        }
        foreach (GameObject go in objetosParaEliminar)
        {
            listaDeCubos.Remove(go);
            Destroy(go);
        }
    }

    private void FixedUpdate()
    {
        GameObject tempGameObjet = Instantiate<GameObject>(PrefabCubo);
        tempGameObjet.name = "CuboNumero" + numCubos;
        Color c = new Color(Random.value, Random.value, Random.value);
        tempGameObjet.GetComponent<MeshRenderer>().material.color = c;
       
    }
    private void OnEnable()
    {
        Instantiate<GameObject>(PrefabCubo);

    }
    private void OnDisable()
    {
        Instantiate<GameObject>(PrefabCubo);

    }
}



