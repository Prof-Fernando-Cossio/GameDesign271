using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_Plataform : MonoBehaviour
{
    public GameObject[] waypoints;
    public float plataformSpeed = 2;
    public int waypointsIndex = 0;


    void Update()
    {

    }

    void MovePlataform()
    {

        if (Vector3.Distance(transform.position, waypoints[waypointsIndex].transform.position) < 0.1f)
        {
            waypointsIndex++;
            if (waypointsIndex >= waypoints.Length)
            {
                waypointsIndex = 0;
            }
        }

        transform.position = Vector3.MoveTowards(transform.position, waypoints[waypointsIndex].transform.position, plataformSpeed * Time.deltaTime);
    }
}