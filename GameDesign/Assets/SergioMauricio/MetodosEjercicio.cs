using System.Collections.Generic;
using System.Linq;
using Unity.IO.LowLevel.Unsafe;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class MetodosEjercicio : MonoBehaviour
{
    //1° Crea un método que reduzca la vida actual de un jugador. Recibe la cantidad de daño como parámetro.
    private void DamageToPlayer(int damageEnemy, int playerCurrentHealth)
    {
        damageEnemy =- playerCurrentHealth;
    }

    //2°Crea un método que verifique si el jugador está vivo según su vida actual
    
    private bool IsPlayerAlive (Player myPlayer)
    {
        return myPlayer.Health() > 0;
        
    }
    
    //3° Crear un metodo que calcule la distancia entre dos posiciones en el espacio

    private void DistanceOfTwoPoints(Vector3 firstPoint, Vector3 secondPoint)
    {
        Vector3.Distance(firstPoint, secondPoint);

    }

    //°4 Crea un método que devuelva la direccion normalizada desde un origen hasta su destino

    private Vector3 NormalizeDirection (Vector3 originPoint, Vector3 destinyPoint)
    {

        return Vector3.Normalize(originPoint - destinyPoint);
    }
    //5° Crea un método que devuelva el nombre actual del jugador
    
    private string GetPlayerName(Player playerName) 
    { 
        return playerName.Name();
    }
    

    //6° Crea un metodo que cuente la cantidad de enemigos contenidos en una lista

    private int EnemyList(List<GameObject> enemyList)
    {
        return enemyList.Count;
    }

    //7° Crea un metodo que encuentre al enemigo mas cercano al jugador dentro de una lista

    private void FindEnemy(List<GameObject> enemyList, Player myPlayer)
    {
        float closestDistance = float.MaxValue;
        GameObject closerEnemy = null;
        foreach (GameObject enemy in enemyList)
        {
            float distance = Vector3.Distance(myPlayer.transform.position, enemy.transform.position);
            if (distance < closestDistance)
            {
                closestDistance = distance;
                closerEnemy = enemy;
            }
        }
        Debug.Log(closerEnemy);
    }

    //8° Crea un metodo que reciba velocidad y dirección y mueva al jugador

    private void MovementPlayer(Vector3 directionPlayer, float velocityPlayer)
    {
        transform.position += directionPlayer * velocityPlayer * Time.deltaTime;
    }

    //9° Crea un metodo que convierta un angulo expresado en grados a radianes

    private void GradesToRadian (float angleInGrades)
    {
        Debug.Log((Mathf.PI * angleInGrades) / 180);
    }

    //10°Crear un metodo que intente obtener al jugador mas cercano dentro de un rango dado, indicando si se encontró uno y devolviendo el jugador obtenido

    private Player PlayerNearby(List<Player> playerList, Vector3 initialPoint, float rangeDetection)
    {
        float closestDistance = float.MaxValue;
        Player closerPlayer = null;
        foreach (Player player in playerList)
        {
            float distance = Vector3.Distance(player.transform.position, initialPoint);
            if (distance < closestDistance && distance < rangeDetection)
            {
                closestDistance = distance;
                closerPlayer = player;
            }
        }
        return closerPlayer;
    }

    //11° Crea un metodo que intente convertir un texto a entero, indicando si la conversión fue exitosa y devolviendo el valor obtenido

    private bool TextToInteger(string originalText, out int numberOut) 
    {
        return int.TryParse(originalText, out numberOut);
    }

    //12° Crea un metodo que reciba un ángulo en grados y devuelva la rotación correspondiente como cuaternion

    private Quaternion RotationInQuaternion(float gradesInAngle)
    {
        return Quaternion.Euler(0, gradesInAngle, 0);
    }

    //13° Crea un metodo que llene una lista con todos los enemigos que se encuentren en un area dada
    private void EnemyListInArea(List<GameObject> enemyList, int inRange)
    {
        List<GameObject> enemyInRange = new List<GameObject>();

        foreach (GameObject enemy in enemyList) 
        {
            float enemyDistance = Vector3.Distance(transform.position, enemy.transform.position);
            if (enemyDistance < inRange)
            {
                enemyInRange.Add(enemy);
            }
        }
    }
    //14° Crea un metodo que reinicie la posición del jugador a un punto de aparición.

    private void CheckPoint (GameObject _playerPosition, GameObject _checkPointPosition)
    {
        _playerPosition.transform.position = _checkPointPosition.transform.position;
    }
    //15° En una clase base, crear un metodo diseñado para ser redefinido por las clases hijas
    public class Character
    {
        public virtual void Attack()
        {
            int AttackValue = 10;
        }
    }
    //16° En una clase hija, redefine el método del ejercicio anterior para proporcionar un comportamiento en específico.
    public class Ninja : Character
    {
        public override void Attack()
        {
            int AttackValue = 5;
        }
    }
    //17° En la clase hija llama al comportamiento original en el método definido en la clase base
    public class Mage : Character
    {
        public override void Attack()
        {
            base.Attack();
        }
    }
    //18° Crea un metodo que devuelva un porcentaje de  vida actual del
    private int PlayerHealthPercentaje (int actualHealth, int maxHealth)
    {
        int playerPercentaje;
        return playerPercentaje = actualHealth / maxHealth * 100;
    }
    //19° Crea un método que determine si un enemigo puede esquivar un ataque con una probabilidad dada
    private void CanAvoid(float enemyAvoid, float hitPercentaje)
    {
        bool canAvoid;

        if (enemyAvoid > hitPercentaje)
        {
            canAvoid = true;
        }
        else
        {
            canAvoid = false;
        }
    }
    //20° Crea un método que aplique una fuerza en una dirección a un RigidBody
    private void ForceToDirection(Rigidbody rigidBody, float forceOfImpact, Vector3 directionOfImpact)
    {
        rigidBody.AddForce(directionOfImpact * forceOfImpact);
    }


}
