using System.Collections;
using System.Collections.Generic;
using Unity.AI.Navigation;
using UnityEngine;
using UnityEngine.UI;

public class Boton : MonoBehaviour
{
    public GameObject puente;
    public NavMeshSurface navMesh;


    void Start()
    {
        Debug.Log("Ponemos el puente inactivo");
        puente.SetActive(false); //desactivamos el puente
    }

    private void OnTriggerEnter(Collider collider)
    {
        Debug.Log("Se produce colision");
        if (collider.CompareTag("Player"))
        {
            puente.SetActive(true);
            navMesh.BuildNavMesh();
        }
    }
   
}
