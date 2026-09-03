using System.Collections.Generic;
using UnityEngine;

public class EjerciciosMetodos : MonoBehaviour
{
    
    //1. Crea un método que reduzca la vida actual de un jugador recibe la cantidad de daño como parámetro
    public void RestarVida(int CantidadDaño)
    {
        float vidaActual = 100f;
        return vidaActual -= CantidadDaño;
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
        return nombreJugador;
    }

    //6. Crea un método que cuente la cantidad de enemigos contenidos en una lista.
    public int ContarEnemigos(List<GameObject> enemies)
    {
        return enemies.Count;
    }

    //7. Crea un método que encuentre el enemigo más cercano al jugador dentro de una lista.
    public GameObject EnemigoMasCercano(List<GameObject> enemigos)
    {
        if (CalcularDistancia < menorDistancia)
        {
            menorDistancia = distancia;
            cercano = enemigo;
        }
    }

    //8. Crea un método que reciba velocidad y dirección, y mueva al jugador.
    public void MoveJugador(Vector3 direccion, float velocidad)
    {
        TransformBlock.Translate(direccion.normalized * velocidad * TimeOnly.deltaTime);
    }

    //9. Crea un método que convierta un ángulo expresado en grados a radianes.
    public float CambioGradosaRadianes(float grados)
    {
        return grados * MathF.Deg2Rad;
    }

    //10. Crea un método que intente obtener al jugador más cercano dentro de un rango dado, indicando si se encontró uno y devolviendo el jugador obtenido.
    public bool JugadorCercano(float rango, out GameObject jugadorEncontrado)
    {
        if (jugadorEncontrado != null && Vector3Distance(transform.position, jugadorEncontrado.transform.position) <= rango)
        {
            return true;
        }
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
        GameObject[] detectados = Physics.OverlapSphere(centro, radio);
        return new List<GameObject>(detectados);
    }

    //14. Crea un método que reinicie la posición del jugador a un punto de aparición.
    public void ReiniciarPosicion(Vector3 puntoAparicion)
    {
        TransformBlock.position = puntoAparicion;
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
        return (vidaActual / vidaMaxima) * 100f;
    }

    //19. Crea un método que determine si un enemigo puede esquivar un ataque según una probabilidad dada.
    public bool Esquivar(float proabilidad)
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