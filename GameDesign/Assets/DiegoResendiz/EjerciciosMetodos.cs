using UnityEngine;

public class EjerciciosMetodos : MonoBehaviour
{
    //1. Crea un método que reduzca la vida actual de un jugador recibe la cantidad de daño como parámetro
    public void RestarVida(int CantidadDaño)
    {
        int VidaJugador = 100;
        int VidaActual = VidaJugador - CantidadDaño;
        Debug.Log("Vida perdida del jugador: " + VidaActual);


    }

    //2. Crea un método que verifique si el jugador está vivo segun su vida actual.
    //public bool IsPlayerAlive(Player myPlayer)
    //{
      // return myPlayer.Health > 0;
    //}
}
