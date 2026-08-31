using UnityEngine;

public class MetodosEjercicio : MonoBehaviour
{
    [SerializeField] private int _playerHealth;
    [SerializeField] private int _playerCurrentHealth;
    //1° Crea un método que reduzca la vida actual de un jugador. Recibe la cantidad de daño como parámetro.
    private void DamageToPlayer(int _damageEnemy)
    {
        _damageEnemy =- _playerCurrentHealth;
    }

    //2°Crea un método que verifique si el jugador está vivo según su vida actual
    /*
    private bool IsPlayerAlive (Player _myPlayer)
    {
        return Player.Health > 0;

        return _playerLife > 0;
        
    }
    */
    //3° Crear un metodo que calcule la distancia entre dos posiciones en el espacio

    private void DistanceOfTwoPoints(Vector3 _firstPoint, Vector3 _secondPoint)
    {
        Vector3.Distance(_firstPoint, _secondPoint);

    }

    //°4 Crea un método que devuelva la direccion normalizada desde un origen hasta su destino

    private Vector3 NormalizeDirection (Vector3 _OriginPoint, Vector3 _destinyPoint)
    {

        return Vector3.Normalize(_OriginPoint - _destinyPoint);
    }
    //5° Crea un método que devuelva el nombre actual del jugador
    /*
    private string GetPlayerName(Player _playerName) 
    { 
        return _playerName.Name;
    }
    */
}
