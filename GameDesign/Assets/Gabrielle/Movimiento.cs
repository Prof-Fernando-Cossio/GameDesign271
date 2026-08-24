using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float speed = 5f;
    public float rotation = 200f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveZ = Input.GetAxis("Vertical");
        float rotateX = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * moveZ * speed * Time.deltaTime);
        transform.Rotate(Vector3.up * rotateX * rotation * Time.deltaTime);
    }
}
