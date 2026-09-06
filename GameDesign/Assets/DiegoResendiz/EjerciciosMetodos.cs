using System.Collections.Generic;
using UnityEngine;

public class EjerciciosMetodos : MonoBehaviour
{
    private float _vidaActual = 100f;
    private string _nombreJugador = "Player";
    //1. Crea un método que reduzca la vida actual de un jugador recibe la cantidad de daño como parámetro
    public void RestarVida(int cantidadDaño)
    {
        _vidaActual = cantidadDaño;
        
    }

    //2. Crea un método que verifique si el jugador está vivo segun su vida actual.
    public bool IsPlayerAlive(Player myPlayer)
    {
      return myPlayer.VidaJugador > 0;
    }

    //3. Crea un método que calcule la distancia entre dos posiciones en el espacio.
    public float CalcularDistancia(Vector3 x1, Vector3 x2)
    {
       return Vector3.Distance(x1, x2);
    }

    //4. Crea un método que devuelva la dirección normalizada desde un origen hacia un destino.
    public Vector3 ObtenerDireccion(Vector3 origen, Vector3 destino)
    {
        return (destino - origen).normalized;
    }

    //5. Crea un método que devuelva el nombre actual del jugador.
    public string ObtenerNombre()
    {
        return _nombreJugador;
    }

    //6. Crea un método que cuente la cantidad de enemigos contenidos en una lista.
    public int ContarEnemigos(List<GameObject> enemies)
    {
        return enemies.Count;
    }

    //7. Crea un método que encuentre el enemigo más cercano al jugador dentro de una lista.
    public GameObject EnemigoMasCercano(List<GameObject> enemigos)
    {
        GameObject enemigoCercano = null;
        float distanciaMinima = Mathf.Infinity;
        Vector3 posicionActual = transform.position;

        foreach (GameObject enemigo in enemigos)
        {
            if (enemigo != null)
            {
                float distancia = Vector3.Distance(posicionActual, enemigo.transform.position);
                if (distancia < distanciaMinima)
                {
                    distanciaMinima = distancia;
                    enemigoCercano = enemigo;
                }
            }
        }
        return enemigoCercano;
    }

    //8. Crea un método que reciba velocidad y dirección, y mueva al jugador.
    public void MoveJugador(Vector3 direccion, float velocidad)
    {
        transform.Translate(direccion.normalized * velocidad * Time.deltaTime);
    }

    //9. Crea un método que convierta un ángulo expresado en grados a radianes.
    public float CambioGradosaRadianes(float grados)
    {
        return grados * Mathf.Deg2Rad;
    }

    //10. Crea un método que intente obtener al jugador más cercano dentro de un rango dado, indicando si se encontró uno y devolviendo el jugador obtenido.
    public bool JugadorCercano(float rango, out GameObject jugadorEncontrado)
    {
        jugadorEncontrado = GameObject.FindGameObjectWithTag("Player");
        if (jugadorEncontrado != null && Vector3.Distance(transform.position, jugadorEncontrado.transform.position) <= rango)
        {
            return true;
        }
            jugadorEncontrado = null;
            return false;
    }

    //11. Crea un método que intente convertir un texto a entero, ind¡cando si la conversión fue exitosa y devolviendo el valor obtenido.
    public bool ConvertirTexto(string texto, out int valorObtenido)
    {
        return int.TryParse(texto, out valorObtenido);
    }

    //12. Crea un método que reciba un ángulo en grados y devuelva la rotación correspondiente como cuaternión.
    public Quaternion Angulos(float angulo)
    {
        return Quaternion.Euler(0, 0, angulo);
    }

    //13. Crea un método que llene una lista con todos los enemigos que se encuentren en un área dada.
    public List<GameObject> Enemigoscerca(Vector3 centro, float radio)
    {
        Collider[] colisiones = Physics.OverlapSphere(centro, radio);
        List<GameObject> enemigosDetectados = new List<GameObject>();
        
        foreach (Collider colision in colisiones)
        {
            enemigosDetectados.Add(colision.gameObject);
        }
        return enemigosDetectados;
    }
    //14. Crea un método que reinicie la posición del jugador a un punto de aparición.
    public void ReiniciarPosicion(Vector3 puntoAparicion)
    {
        transform.position = puntoAparicion;
    }

    //15. En una clase base, crea un método diseñado para ser redefinido por las clases hijas.
    public class EnemigoBase
    {
    public virtual void Atacar()
    {
        Debug.Log("Ataque normal de clase base");
    }
    }
    //16. En una clase hija, redefine el método del ejercicio anterior para proporcionar un comportamiento específico.
    //17. En la clase hija, llama al comportamiento original del método definido en la clase base.
    public class Jefe :EnemigoBase
    {
        public virtual void Atacar()
        {
            base.Atacar();
        }
    }

    //18. Crea un método que devuelva el porcentaje de vida actual de un jugador respecto a su vida máxima.
    public float PorcentajeVida(float vidaMaxima)
    {
        return (_vidaActual / vidaMaxima) * 100f;
    }

    //19. Crea un método que determine si un enemigo puede esquivar un ataque según una probabilidad dada.
    public bool Esquivar(float probabilidad)
    {
        return Random.value <= probabilidad;
    }

    //20. Crea un método que aplique una fuerza en una dirección a un Rigidbody.
    public void Fuerza(Rigidbody rigidbody, Vector3 direccionFuerza)
    {
        rigidbody.AddForce(direccionFuerza, ForceMode.Impulse);
    }
}

public class Player
{
    public int VidaJugador = 100;
}