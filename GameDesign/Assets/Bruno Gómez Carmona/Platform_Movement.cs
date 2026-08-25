using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UIElements;

public class Platform_Movement : MonoBehaviour
{

    public float speed = 1.0f;
    public  Transform posA, posB;
     Vector3 targetpos;
    
 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        targetpos = posB.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (Vector2.Distance(transform.position, posA.position) < 1f)
        {
            targetpos = posB.position;
        }

        if (Vector2.Distance(transform.position, posB.position) < 1f)
        {
            targetpos = posA.position;
        }

        transform.position = Vector3.MoveTowards(transform.position, targetpos, speed * Time.deltaTime);
    }
}
