using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEngine.InputManagerEntry;

public class platformMovement : MonoBehaviour
{
    [Header("Variables")]
    public float distance = 5;
    public float speed = 5;
    public bool moveX = false;
    public bool moveY = false;
    private int doX = 1, doZ = 1;

    [Header("Vectors")]
    Vector3 originalPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        originalPosition = this.transform.position;

        if (moveX == true)
        {
            doX = 1;
        }
        else
        {
            doX = 0;
        }
        if (moveY == true)
        {
            doZ = 1;
        }
        else
        {
            doZ = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.x == (originalPosition.x + distance) || this.transform.position.z == (originalPosition.z + distance))
        {
            speed = -speed;
        }

        Vector3 movement = new Vector3(doX * speed * Time.deltaTime, 0, doZ * speed * Time.deltaTime);
        this.transform.position = movement;
    }
}
