using UnityEngine;

public class Métodos : MonoBehaviour
{
    private float _currentHealth = 100f;
    private float _maxHealth = 100f;
    private string _playerName = "Lol";

    //1. Crea un método que reduzca la vida actual de un jugador. Recibe la cantidad de daño como parámetro
    public float ReduceHealth(float damageAmount = 10f)
    {
        _currentHealth -= damageAmount;
        _currentHealth = Mathf.Max(_currentHealth, 0f);
        Debug.Log("Health reduced by 10");
    }
    //2. Crea un método que verifique si el jugador está vivo según su vida actual
    public bool IsPlayerAlive()
    {
        return _currentHealth > 0f;
    }
    //3. Crea un método que calcule la distancia entre dos posiciones en el espacio
    public float GetDistance(Vector3 positionA, Vector3 positionB)
    {
        return Vector3.Distance(positionA, positionB);
    }
    //4. Crea un método que devuelva la dirección normalizada desde un origen hacia un destino
    public Vector3 GetDirection(Vector3 origin, Vector3 destination)
    {
        Vector3 direction = destination - origin;
        return direction.normalized;
    }
    //5. Crea un método que devuelva el nombre actual del jugador
    public string GetPlayerName()
    {
        return _playerName;
    }
    //6. Crea un método que cuente la cantidad de enemigos contenidos en una lista.
    public int CountEnemies(List<GameObject> enemies)
    {
        if (enemies != null)
        {
            return enemies.Count;
        }
        else
        {
            return 0;
        }
    }
    //7. Crea un método que encuentre el enemigo más cercano al jugador dentro de una lista.
    public GameObject GetClosestEnemy(Vector3 playerPosition, List<GameObject> enemies)
    {
        if (enemies == null)
        {
            return null;
        }
        GameObject closestEnemy = null;
        float shortestDistance = Mathf.Infinity;
        foreach (GameObject enemy in enemies)
        {
            if (enemy != null)
            {
                float distance = Vector3.Distance(playerPosition, enemy.transform.position);
                if (distance < shortestDistance)
                {
                    shortestDistance = distance;
                    closestEnemy = enemy;
                }
            }
        }

        return closestEnemy;
    }
    //8. Crea un método que reciba velocidad y dirección, y mueva al jugador.
    public void MovePlayer(Transform playerTransform, Vector3 direction, float speed)
    {
        Vector3 movement = direction.normalized * speed * Time.deltaTime;
        playerTransform.Translate(movement, Space.World);  //le indica al motor que el movimiento, la rotación o la transformación deben calcularse utilizando el sistema de coordenadas globales
    }
    //9. Crea un método que convierta un ángulo expresado en grados a radianes.
    public float DegreesToRadians(float degrees)
    {
        return degrees * Mathf.Deg2Rad;
    }
    //10. Crea un método que intente obtener al jugador más cercano dentro de un rango dado, indicando si se encontró uno y devolviendo el jugador obtenido.
    public bool TryGetPlayerInRange(Vector3 origin, float range, out GameObject player)
    {
        player = GameObject.FindWithTag("Player");
        if (player != null)
        {
            float distance = Vector3.Distance(origin, player.transform.position);
            if (distance <= range)
            {
                return true;
            }
        }
        player = null;
        return false;
    }
    //11. Crea un métodoque intente convertir un texto a entero, indicando si la conversación fue exitosa y devolviendo el valor obtenido.
    public bool TryParseTextToInt(string textToConvert, out int convertedValue)
    {
        return int.TryParse(textToConvert, out convertedValue);
    }
    //12. Crea un método que reciba un ángulo en grados y devuelva la rotación correspondiente como cuaternión
    public  Quaternion GetRotationFromAngle(float angleInDegrees)
    {
        return Quaternion.Euler(0f, angleInDegrees, 0f);
    }
    //13. Crea un método que llene una lista con todos los enemigos que se encuentren en un área dada.
    public void GetEnemiesInArea(Vector3 center, float radius, List<GameObject> enemyList)
    {
        enemyList.Clear();
        Collider[] colliders = Physics.OverlapSphere(center, radius);
        foreach (Collider col in colliders)
        {
            if (col.CompareTag("Enemy"))
            {
                enemyList.Add(col.gameObject);
            }
        }
    }    
    //14. Crea un método que reinicie la posición del jugador a un punto de aparición
    public void RespawnPlayer(Transform playerTransform, Vector3 spawnPoint)
    {
        playerTransform.position = spawnPoint;
    }
    //15. En una clase base, crea un método diseñado para ser definido por las clases hijas
    public class CharacterBase
    {
        public virtual void ReceiveDamage(int damageAmount)
        {
            Debug.Log("Daño en la clase base: " + damageAmount);
        }
    }
    //16. En una clase hija, redefine el método del ejercicio anterior para proporcionar un comportamiento específico.
    public class EnemyCharacter : CharacterBase
    {
        public override void RecieveDamage(int damageAmount)
        {
            Debug.Log("El enemigo hace animación de daño");
            //17. En la clase hija, llama al comportamiento original del método definido en la clase base.
            base.ReceiveDamage(damageAmount);
        }
    }

    //18. Crea un método que devuelva el porcentaje de vida actual de un jugador respecto a su vida máxima.
    public float GetHealthPercentage(float currentHealth, float maxHealth)
    {
        if (maxHealth <= 0)
        {
            return 0f;
        }

        return (currentHealth / maxHealth) * 100f;
    }
    //19. Crea un método que determine si un enemigo puede esquivar un ataque según una probabilidad dada.
    public bool CanDodgeAttack(float dodgeChamce)
    {
        return Random.value <= dodgeChamce;
    }
    //20. Crea un método que aplique una fuerza en una dirección a un Rigidbody.
    public void ApplyForce(Rigidbody rigidbody, Vector3 direction, float forceAmount)
    {
        if (rigidbody != null)
        {
            rigidbody.AddForce(direction.normalized * forceAmount, ForceMode.Impulse);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
