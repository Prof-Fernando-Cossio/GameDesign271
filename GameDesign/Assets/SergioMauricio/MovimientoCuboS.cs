using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class MovimientoCuboS : MonoBehaviour
{
    public float movimiento;
    public float velocidad;

    private void Update()
    {
        plataforma();
    }

    void plataforma()
    {

       
        transform.position = new Vector3 (movimiento + 0, 0, 0);
        
        transform.position = new Vector3(0, 0, 0);
    }


}
