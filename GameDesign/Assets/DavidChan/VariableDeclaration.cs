using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

[RequireComponent(typeof(GameManager))]
public class VariableDeclaration : MonoBehaviour
{
    //1. Un valor de velocidad que solo este script usa
    //   que sea editable desde el Inspector. Valor inicial de 5

    [SerializeField] private float _movementSpeed = 5f;

    // 2. El nivel actual del jugador que otros sistemas del juego
    //    necesitan leer.

    public int PlayerLevel = 0;

    // 3. Un daño base que solo las clases derivadas pueden usar.
    //    Valor inicial de 10

    protected int _baseDamage = 10;

    // 4. La vida actual del jugador. Ningún Otro script 
    //    debe poder modificarla directamente.

    private int _playerHealth = 100;

    // 5. Una referencia a Rigidbody que solo este script usa
    //    y que sea editable desde el Inspector.

    [SerializeField] private Rigidbody _rigidbody;

    // 6. Un valor verdadero/falso que indique si el jugador
    //    sigue vivo. Solo este script lo usa

    private bool _isPlayerAlive;

    // 7. Un indice de guardado que ningun otro script fuera de
    //    este ensamblado puede acceder

    internal int _saveIndex = 0;

    // 8. Un rango de ataque que solo este srcipt usa, editable
    //    desde el Inspector y limitado entre 0 y 100

    [Range(0, 100)]
    [SerializeField] private int _atkRange;

    // 9. El nombre actual del jugador que cualquier
    //    sistema del juego debe poder leer

    public string PlayerName;

    // 10. una velocidad de movimiento que las clases derivadads
    //     (enemigos, aliados, jefes, etc.) puedan reutilizar.

    protected float _moveSpeed = 5f;

    // 11. Unaa referencia a MeshRenderer que solo este script usa
    //     y que NO debe verse en el Inspector

    private MeshRenderer _meshRenderer;

    // 12. Un valor que controla el volumen del juego editable
    //     desde el inspector y con un mensaje de ayuda.
    
    [Tooltip("Control del volumen del juego")]
    [SerializeField] private float _gameVolume;

    // 13. Un valor verdadero/falso que indica si el enemigo
    // puede atacar. Solo este script lo usa.

    private bool _canEnemyAttack;

    // 14. La instancia global de GameManager a la que cualquier
    //     script pueda acceder sin crearla
    
    public static GameManager GameManagerInstance;

    // 15. Una lista para almacenar objetos del inventario.
    //     Solo este script puede modificarla.

    private List<GameObject> _inventory = new List<GameObject>();

    // 16. Un valor de velocidad que antes se llamaba "_speed".
    //     Debe ser editable desde el Inspector.

    [FormerlySerializedAs("_speed")]
    [SerializeField] private float _newMovementSpeed = 5f;

    // 17. Una posicion del jugadpr usando Vector3.
    //     Solo este script lo usa.

    private Vector3 _playerPosition;

    // 18. La cantidad maxima de jugadores permitidos en la partida
    //     que cualquier sistema deba consultar

    public int MaxPlayers = 12;

    // 19. Una distancia de deteccion enemiga que las clases derivadas
    //     puedan reutilizar y que sea editable desde el Inspector.

    [SerializeField] protected float _enemyDetection = 8.5f;

    // 20. Una referencia a AudioSource que solo este script usa
    //     y que sea editable desde el Inspector.

    [SerializeField] private AudioSource _audioSource;

    // Variables del ejercicio de Metodos

    public Transform _player;
    void Start()
    {

    }


    void Update()
    {
    
    }

    // MÉTODOS, OUT VIRTUAL/OVERRIDE 

    //1. Crea un metodo que reduzca la vida actual de un jugador.
    //   Recibe la cantidad de daño como parámetro

    public int LoseHealth(int _baseDamage)
    {
        return _playerHealth = Mathf.Clamp(_playerHealth - _baseDamage, 0, 100);
    }

    //2. Crea un método que verifique si el jugador esta vivo según su vida actual.

    public bool IsPlayerAlive() //Poniendo parametro (Player currentPlayer)
    {

        //retun currentPlayer.Health > 0;

        //Sin parametro

        return _playerHealth > 0;
    }

    //3. Crea un método que calcule la distancia entre dos posiciones en el espacio

    public float CalculateDistance(Vector3 positionA, Vector3 positionB)
    {
        return Vector3.Distance(positionA, positionB);
    }

    //4. Crea un método que devuelva la dirección normalizada desde un origen hacia un destino.

    public Vector3 DirectionToPlayer()
    {
        Vector3 vectorToPlayer = _player.position - transform.position;

        return vectorToPlayer.normalized;
    }

    //5. Crea un metodo que devuelva el nombre actual del jugador.

    public string GetPlayerName()
    {
        return PlayerName;
    }

    //6. Crea un método que cuente la cantidad de enemigos contenidos en una lista.

    public int CountEnemiesInList(List<GameObject> enemies)
    {
        return enemies.Count;
    }

    //7. Crea un método que encuentre el enemigo más cercano al jugador dentro de una lista.

    public GameObject FindClosestEnemy(List<GameObject> enemies)
    {
        GameObject closestEnemy = null;
        float closestDistance = Mathf.Infinity;
        foreach (GameObject enemy in enemies)
        {
            float distance = Vector3.Distance(_player.position, enemy.transform.position);
            if (distance < closestDistance)
            {
                closestDistance = distance;
                closestEnemy = enemy;
            }
        }
        return closestEnemy;
    }

    //8. Crea un método que reciba la velocidad y dirección y mueva al jugador

    public void MovePlayer(Vector3 direction, float speed)
    {
        _rigidbody.MovePosition(_rigidbody.position + direction * speed * Time.deltaTime);
    }

    //9. Crea un método que convierta un ángulo expresado en grados a radianes.

    public float DegreesToRadians(float degrees)
    {
        return degrees * Mathf.Deg2Rad;
    }

    //10. Crea un método que intente obtener al jugador más cercano dentro de un rango dado, indicando si se encontró uno y devolviendo el jugador obtenido

    public bool TryGetClosestPlayer(List<GameObject> players, Vector3 playerPosition, float range, out GameObject closestPlayer)
    {
        closestPlayer = null;
        float closestDistance = Mathf.Infinity;
        foreach (GameObject player in players)
        {
            float distance = Vector3.Distance(playerPosition, player.transform.position);
            if (distance < closestDistance && distance <= range)
            {
                closestDistance = distance;
                closestPlayer = player;
            }
        }
        return closestPlayer != null;
    }

    //11. Crea un método que intente convertir un texto a entero, indicando si la conversión fue exitosa y devolviendo el valor obtenido.

    private bool TryParseInt(string text, out int value)
    {
        value = 0;
        if (int.TryParse(text, out value))
        {
            Debug.Log("Conversión exitosa.");
            return true;
        }
        return false;
    }

    //12. Crea un método que reciba un ángulo en grados y devuelva la rotación correspondiente como cuaternión

    public Quaternion DegreesToQuaternion(float degrees)
    {
        return Quaternion.Euler(0, degrees, 0);
    }

    //13. Crea un método que llene una lista con todos los enemigos que se encuentren en un área dada.

    public List<GameObject> GetEnemiesInArea(List<GameObject> enemies, Vector3 center, float radius)
    {
        List<GameObject> enemiesInArea = new List<GameObject>();
        foreach (GameObject enemy in enemies)
        {
            float distance = Vector3.Distance(center, enemy.transform.position);
            if (distance <= radius)
            {
                enemiesInArea.Add(enemy);
            }
        }
        return enemiesInArea;
    }

    //14. Crea un método que reinicie la posicion del jugador a un punto de aparición.

    public void RestartPlayerPosition(Vector3 spawnPoint)
    {
        _rigidbody.position = spawnPoint;
    }

    //15. En una clase base, crea un método diseñado para ser redefinido por las clases hijas.

    public class PlayerGun : MonoBehaviour 
    {
        public virtual void ChangeWeapon()
        {
            Debug.Log("Weapon changed to default.");
        }

        public virtual void BulletType()
        {
            Debug.Log("Bullet type is normal.");
        }
    }

    //16. En una clase hija, redefine el método del ejercicio anterior para proporcionar un comportamiento especifico.

    public class Shotgun : PlayerGun
    {
        public override void ChangeWeapon()
        {
            Debug.Log("Weapon changed to shotgun.");
        }

        //17. En la clase hija, llama al comportamiento original del método definido en la clase base.
        public override void BulletType()
        {
            base.BulletType();
            Debug.Log("Bullet type is explosive.");
        }
    }

    //18. Crea un método que devuelva el porcentaje de vida actual de un jugador respecto a su vida máxima.

    public int GetHealthPlayerPercentage(float currentPlayerHealth, float maxPlayerHealth)
    {
        return Mathf.RoundToInt((currentPlayerHealth / maxPlayerHealth) * 100);
    }

    //19. Crea un método que determine si un enemigo puede esquivar un ataque según una probabilidad dada.

    public bool CanEnemyDodge(float dodgeChance)
    {
        float randomValue = Random.Range(0f, 1f);
        return randomValue <= dodgeChance;
    }

    //20. Crea un método que aplique una fuerza en una direccion a un Rigidbody

    public void ApplyForceToRigidbody(Rigidbody rigidbody, Vector3 direction, float force)
    {
        rigidbody.AddForce(direction * force, ForceMode.Impulse);
    }

}
