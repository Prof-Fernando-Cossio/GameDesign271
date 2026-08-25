using UnityEngine;

public class Movimietno : MonoBehaviour
{
    public GameObject[] waypoints;

    public float speed = 5f;

    private int waypointIndex = 0;

    // Update is called once per frame
    void Update()
    {
        MPlataform();
    }


    void MPlataform()
    {
        if (Vector3.Distance(transform.position, waypoints[waypointIndex].transform.position) < 0.1f)
        {
            waypointIndex++;
            if (waypointIndex >= waypoints.Length)
            {
                waypointIndex = 0;
            }
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, waypoints[waypointIndex].transform.position, speed * Time.deltaTime);
        }
    }
}
