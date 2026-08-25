using UnityEngine;

public class Plataformart : MonoBehaviour
{
    public float velocidad = 5f;
    public float posicióninicialX = 0f;
    public float distanciamaxX = 10f;
    private bool right = false;
    void Start()
    {
        
    }

    void Update()
    {
        direction();
        if (right == true)
        {
            avance();
        }
        else if (right == false)
        {
            regreso();
        }
    }
   
    private void direction()
    {
        if (transform.position.x <= posicióninicialX)
        {
            right = true;
        }
        else if (transform.position.x >= distanciamaxX)
        {
            Debug.Log("RIGHT ES FALSO");
            right = false;
        }
    }
private void avance()
    {
        transform.Translate(Vector3.right * velocidad * Time.deltaTime);
    }
    private void regreso()
    {
        transform.Translate(Vector3.left * velocidad * Time.deltaTime);
    }
}
