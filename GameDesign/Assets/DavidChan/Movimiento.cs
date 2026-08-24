using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float velocidad = 5;
    void Start()
    {
        
    }
    void Update()
    {
        float distance = velocidad * Time.deltaTime * Input.GetAxis("Horizontal");
            transform.Translate(Vector3.right * distance);
    }
}
