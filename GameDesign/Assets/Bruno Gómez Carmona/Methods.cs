using NUnit.Framework;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;




public class Methods : MonoBehaviour
{
    private int _currentHealth = 100;
    private int _generalHealth = 100;

    public GameObject PosA;
    public GameObject PosB;


    public GameObject Enemies;


    public List<GameObject> enemies = new List<GameObject>();
    private int maxEnemiesSpawned;
    [SerializeField] private string _playerName;


    private GameObject _enemyPrefab;


    //1.- Un metodo que reduzca la vida actual del jugador. Recibe la cantidad de daño como parametro


    private void IsPlayerHit(int EnemyDamage)
    {
        _currentHealth = _generalHealth - EnemyDamage;
    }


    //2.- Un método que verifique si el jugador esta vivo segun su vida actual


    private bool PlayerAlive()
    {
        return _currentHealth > 0;
    }


    //3.- Un metodo que calcule la distancia entre dos posiciones en el espacio


    private float PositionDistances()
    {


        float distanceX = PosB.transform.position.x - PosA.transform.position.x;
        float distanceY = PosB.transform.position.y - PosA.transform.position.y;
        float distanceZ = PosB.transform.position.z - PosA.transform.position.z;


        float distance = Mathf.Sqrt((distanceX * distanceX) + (distanceY * distanceY) + (distanceZ * distanceZ));
        Debug.Log(distance);
        return distance;


    }


    //4.- Un metodo que devuelva la direccion normalizada desde un origen hacia un destino


    private float NormalizedDistance(Vector3 origin, Vector3 distance, float maxDistance)
    {
        float distanceX = distance.x - origin.x;


        return Mathf.Clamp01(distanceX / maxDistance);
    }


    //5.- Un metodo que devuelva el nombre actual del jugador


    private string PlayerName()
    {
        return _playerName;
    }


    //6.- Un metodo que cuente la cantidad de enemigos contenidos en una lista


    private void CountEnemies()
    {
        if (enemies.Count < maxEnemiesSpawned)
        {
            enemies.Add(Instantiate(_enemyPrefab, transform.position, Quaternion.identity));
        }
    }


    //7.- Un metodo que encuentre al enemigo más cercano al jugador dentro de una lista


    private GameObject FindCloseEnemy(Vector3 playerPosition, List<GameObject> enemies)
    {
        GameObject closestEnemy = null;
        float closestDistance = Mathf.Infinity;


        foreach (GameObject enemy in enemies)
        {
            float distance = Vector3.Distance(playerPosition, enemy.transform.position);


            if (distance < closestDistance)
            {
                closestEnemy = enemy;
                closestDistance = distance;
            }
        }


        return closestEnemy;
    }


    //8.- Un metodo que reciba velocidad y dirección, y mueva al jugador


    private GameObject Player(float speed, Vector3 direction)
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position += direction * speed * Time.deltaTime;


        }


        return null;
    }


    //9.- Un metodo que convierta un angulo expresado en grados a radianes


    private float AngleToRadians(float angleDegrees)
    {
        return angleDegrees * Mathf.Deg2Rad;
    }


    //10.- Un metodo que intente obtener al jugador más cercano dentro de un rango dado,
    //      indicando si se encontro uno y devolviendo al jugador obtenido


    private GameObject PlayerFinder(Vector3 position, LayerMask playerLayer, float detectionRadius, out GameObject playerTarget)
    {
        if (PlayerFinder(transform.position, playerLayer, detectionRadius, out playerTarget))
        {
            Debug.Log($"{playerTarget.name} found");
        }
        else
        {
            Debug.Log("No player found");
        }


        return null;
    }


    //11.- Un metodo que intente convertir un texto a entero,
    //      indicando si la conversion fue exitosa y devolviendo el valor obtenido


    private bool TextToInt(string text, out int value)
    {
        return int.TryParse(text, out value);
    }




    //12.- Un metodo que reciba un angulo en grados y devuelva la rotación correspondiente como cuaternion


    private Quaternion AngleToQuaternion(float angleDegrees)
    {
        return Quaternion.Euler(0f, angleDegrees, 0f);
    }


    //13.- Un metodo que llene una lista con todos los enemigos que se en un area dada


    private void EnemiesList(Vector3 center, float radius, LayerMask enemyLayer, List<GameObject> enemies)
    {
        Collider[] colliders = Physics.OverlapSphere(center, radius, enemyLayer);
        foreach (Collider collider in colliders)
        {
            enemies.Add(collider.gameObject);
        }
    }




    //14.- Un metodo que reinicie la posicion del jugador a un punto de aparicion


    private void ResetPlayerPosition(Vector3 respawnPoint, Rigidbody rigidBody)
    {
        transform.position = respawnPoint;
        transform.rotation = Quaternion.identity;


        if (rigidBody != null)
        {
            rigidBody.linearVelocity = Vector3.zero;
            rigidBody.angularVelocity = Vector3.zero;
        }
    }

    //18.- Un metodo que devuelva el porcentaje de vida actual de un jugador respecto a su vida maxima


    private float HealthPercentage()
    {
        return (float)_currentHealth / _generalHealth * 100f;
    }

    //19.- Un metodo que determine si un enemigo puede esquivar un ataque segun una probabilidad dada


    private bool EnemyCanDodge(float dodgeProbability)
    {
        return Random.value <= Mathf.Clamp01(dodgeProbability);
    }


    //20.- Un metodo que aplique una fuerza una direccion a un Rigidbody


    private void ApplyForce(Rigidbody rigidBody, float force, Vector3 position)
    {
        rigidBody.AddForce(position.normalized * force, ForceMode.Impulse);
    }
}


//15.- Un clase "base", crea un metodo diseñado para ser redefinido por las clases hijas
public class Interact : MonoBehaviour
{
    public virtual void InteractWithSomething()
    {
        Debug.Log("Interacting with something");
    }
}
//16.- Una clase hija, redefine el metodo del ejercicio anterior para proporcionar un comportamiento especifico


public class InteractingWithChest : Interact
{
    public override void InteractWithSomething()
    {
        //17.- En la clase hija, llama al comportamiento original del metodo definido en la clase base
        base.InteractWithSomething();
        Debug.Log("Interacting with the chest");
    }
}
