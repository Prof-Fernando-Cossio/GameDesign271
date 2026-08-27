using UnityEngine;

public class PlataformMovement : MonoBehaviour
{
    public float Speed = 5f;
    private Vector3 direction = Vector3.up;
    public int maxY = 5;
    public int minY = 1;

    void Start()
    {

    }

    void Update()
    {
        if (transform.position.y <= minY)
        {
            direction = Vector3.up;
        }


        if (transform.position.y >= maxY)
        {
            direction = Vector3.down;
        }
        transform.Translate(direction * Time.deltaTime * Speed);
    }
}
