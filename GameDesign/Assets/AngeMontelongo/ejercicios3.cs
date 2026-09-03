using System.Collections.Generic;
using UnityEngine;

public class ejercicios3 : MonoBehaviour
{
    public float _playerLife = 100;
    public float _lifeMax = 100;
    public string _playerName = "Jugador";

    // 1
    public void RecibirDamage(float damage)
    {
        _playerLife = _playerLife - damage;
    }

    // 2
    public bool IsAlive()
    {
        return _playerLife > 0;
    }

    // 3
    public float CalculateDistance(Vector3 posicion1, Vector3 posicion2)
    {
        return Vector3.Distance(posicion1, posicion2);
    }

    // 4
    public Vector3 GetDirection(Vector3 origen, Vector3 destino)
    {
        return (destino - origen).normalized;
    }

    // 5
    public string GetPlayerName()
    {
        return _playerName;
    }

    // 6
    public int EnemiesCount(List<GameObject> enemigos)
    {
        return enemigos.Count;
    }

    // 7
    public GameObject EnemigoMasCercano(List<GameObject> enemigos)
    {
        GameObject enemigoCercano = null;
        float distanciaCercana = 99999;

        foreach (GameObject enemigo in enemigos)
        {
            float distancia = Vector3.Distance(transform.position, enemigo.transform.position);

            if (distancia < distanciaCercana)
            {
                distanciaCercana = distancia;
                enemigoCercano = enemigo;
            }
        }

        return enemigoCercano;
    }

    // 8
    public void PlayerMovement(float velocidad, Vector3 direccion)
    {
        transform.position = transform.position + direccion * velocidad;
    }

    // 9
    public float GradosARadianes(float grados)
    {
        return grados * Mathf.PI / 180;
    }

    // 10
    public bool TryGetJugadorCercano(List<GameObject> jugadores, float rango, out GameObject jugador)
    {
        jugador = null;
        float distanciaCercana = rango;

        foreach (GameObject player in jugadores)
        {
            float distancia = Vector3.Distance(transform.position, player.transform.position);

            if (distancia < distanciaCercana)
            {
                distanciaCercana = distancia;
                jugador = player;
            }
        }

        return jugador != null;
    }

    // 11
    public bool ConvertirTexto(string texto, out int valor)
    {
        return int.TryParse(texto, out valor);
    }

    // 12
    public Quaternion CrearRotacion(float grados)
    {
        return Quaternion.Euler(0, 0, grados);
    }

    // 13
    public List<GameObject> EnemiesArea(List<GameObject> enemigos, Vector3 centro, float rango)
    {
        List<GameObject> enemigosArea = new List<GameObject>();

        foreach (GameObject enemigo in enemigos)
        {
            float distancia = Vector3.Distance(centro, enemigo.transform.position);

            if (distancia <= rango)
            {
                enemigosArea.Add(enemigo);
            }
        }

        return enemigosArea;
    }

    // 14
    public void ReiniciarPosicion(Vector3 puntoAparicion)
    {
        transform.position = puntoAparicion;
    }

    // 18
    public float PorcentajeVida()
    {
        return (_playerLife / _lifeMax) * 100;
    }

    // 19
    public bool PuedeEsquivar(float probabilidad)
    {
        return Random.value < probabilidad;
    }

    // 20
    public void AplicarFuerza(Rigidbody rb, float fuerza, Vector3 direccion)
    {
        rb.AddForce(direccion * fuerza);
    }
}


// 15
public class ClaseBase
{
    public virtual void Comportamiento()
    {
        Debug.Log("Comportamiento original");
    }
}


// 16 y 17
public class ClaseHija : ClaseBase
{
    public override void Comportamiento()
    {
        base.Comportamiento();

        Debug.Log("Comportamiento de la clase hija");
    }
}