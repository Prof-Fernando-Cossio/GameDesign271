using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float speed = 2.0f;
    public float distance = 5.0f;

    private Vector3 startPosition;
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float movimiento = Mathf.PingPong(Time.time * speed, distance * 2) - distance;
        transform.position = startPosition + new Vector3(movimiento, 0f, 0f);
    }
}
