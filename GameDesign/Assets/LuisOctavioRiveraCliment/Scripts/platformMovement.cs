using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEditor.Build;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEngine.InputManagerEntry;

public class platformMovement : MonoBehaviour
{
    [Header("Variables")]
    public float distance = 5f;
    public float speed = 5f;
    public bool moveX = false;
    public bool moveZ = false;
    private int doX = 1, doZ = 1;

    [Header("Vectors")]
    Vector3 originalPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        originalPosition = transform.position;

        doX = moveX ? 1 : 0;
        doZ = moveZ ? 1 : 0;
    }

    // Update is called once per frame
    void Update()
    {
        bool outBoundX = transform.position.x >= (originalPosition.x + distance) || transform.position.x <= (originalPosition.x - distance);
        bool outBoundZ = transform.position.z >= (originalPosition.z + distance) || transform.position.z <= (originalPosition.z - distance);
        if (outBoundZ || outBoundX)
        {
            speed = -speed;

            Vector3 clampedPosition = transform.position;
            if(moveX) { clampedPosition.x = (Mathf.Clamp(clampedPosition.x, originalPosition.x - distance, originalPosition.x + distance)); }
            if (moveZ) { clampedPosition.z = (Mathf.Clamp(clampedPosition.z, originalPosition.z - distance, originalPosition.z + distance)); }
        }

        Vector3 movement = new Vector3(doX * speed * Time.deltaTime, 0, doZ * speed * Time.deltaTime);
        transform.position += movement;
    }
}
