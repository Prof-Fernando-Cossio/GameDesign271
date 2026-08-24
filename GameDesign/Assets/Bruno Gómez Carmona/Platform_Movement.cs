using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UIElements;

public class Platform_Movement : MonoBehaviour
{

    public float speed = 1.0f;
    public float distance;
    public Vector3 currentpos;
    public Vector3 targetpos;
    public GameObject gameObject;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentpos = this.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        //float distance = Vector3(currentpos,);

    }
}
