using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float speed = 2f;
    public Vector3 targeted;


    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targeted, speed * Time.deltaTime);


    }
}
