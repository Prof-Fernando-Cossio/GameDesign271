using UnityEngine;

public class move : MonoBehaviour
{
    private float Velocidad;
    public float direccion = 5.0f;
    public float distancia = 5.0f;
    float origen;
    private void Start()
    {
        origen = transform.position.x;
        Velocidad = -direccion;
    }

    private void Update()
    {
        if (origen - transform.position.x> distancia)
        {
            Velocidad = direccion;
        }
        else if (origen - transform.position.x < -distancia) 
        {
            Velocidad = -direccion;
        }
        transform.Translate(Velocidad * Time.deltaTime, 0, 0);
    }

}