using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class MovimientoCuboS : MonoBehaviour
{
    public GameObject inicio;
    public GameObject[] puntos;
    public float movimiento;
    public float velocidad = 5f;
    public int puntosindex = 0;

    private void Start()
    {
        transform.position = inicio.transform.position;
    }

    private void Update()
    {
        plataforma();
    }

    void plataforma()
    {
        if (Vector3.Distance(transform.position, puntos[puntosindex].transform.position) < 0.1f)
        {
            puntosindex++;

            if (puntosindex >= puntos.Length)
            {
                puntosindex = 0;
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, puntos[puntosindex].transform.position, velocidad *Time.deltaTime);
    }


}
