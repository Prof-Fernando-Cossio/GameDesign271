using System.Runtime.CompilerServices;
using UnityEngine;

public class VariableDeclaration : MonoBehaviour
{

    // 1. Un valor de velocidad que solo este script usa
    // que sea editable desde el Inspector. Valor inicial de 5.

    //[SerializeField]  
    //private float _movementSpeed = 5f;

    // 2. El nivel actual del jugador que otros sistemas del juego necesitan leer

    //internal int CurrentLevel;

    // 3. Un daño base que solo las clases derivadas pueden usar.
    // valor inicial de 10

    //protected float _baseDamage = 10f;

    // 4. La vida actual del jugador. Ningún otro script debe poder modificarla directamente.

    //private float _currentHealth;

    // 5. Una referencia a Rigidbody que solo este script usa y que sea editable desde el Inspector.

    //[SerializeField] 
    //private Rigidbody _rb;

    // 6. Un valor verdadero/falso que indique si el jugador sigue vivo. Solo este script lo usa.

    //private bool _isAlive;

    // 7. Un índice de guardado que ningún otro script fuera de este ensamblado pueda acceder

    //internal int _saveGame;

    // 8. Un rango de ataque que solo este script usa, editable desde el inspector y limitado entre 0 y 100.

    //[SerializeField, Range(0f, 100f)]  
    //private float _attackRange;

    // 9. El nombre actual del jugador que cualquier sistema del juego debe poder leer.

    //public static string PlayerName;

    // 10. Una velocidad de movimiento que las clases derivadas (enemigos, aliados, jefes, etc.) puedan reutilizar.

    //protected float _movSpeed;

    // 11. Una referencia a MeshRenderer que solo este script usa y que NO debe verse en el Inspector 

    //private MeshRenderer _meshRenderer;

    // 12. Un valor que controla el volumen del juego, editable desde el inspector y con un mensaje de ayuda

    //[SerializeField, Tooltip("Controla el volumen del juego")] 
    //private float _volume;

    // 13. Un valor de verdadero/falso que indica si el enemigo puede atacar. Solo este script lo usa

    //private bool _canAttack;

    // 14. La instancia global de GameManager a la que cualquier script pueda acceder sin crearla

    // public static GameManager GameManagerInstance;

    // 15. Una lista para almacenar objetos del inventario. Solo este script la modifica

    //private List<GameObject> _inventoryItem = new List<GameObject>();

    // 16. Un valor de velocidad que antes se llamaba "_speed". Debe ser editable desde el Inspector.

    ///[SerializeField, FormerlySerializedAs("_speed")]  
    //private float _movementSpeed;

    // 17. Una posición del jugador usando Vector3. Solo este script la usa.

    //private Vector3 _playerPosition;

    // 18. La canitdad máxima de jugadores permitidos en la partida, que cualquier sistema deba consultar.

    //public static int MaxPlayers;

    // 19. Una distancia de detección enemiga que las clases derivadas puedan reutilizar y que sea editable desde el Inpesctor

    // [SerializeField] 
    //protected float _detectionDistance;

    // 20. Una referencia a AudioSource que solo este script usa y que sea editable desde el Inspector

    // [SerializeField]  
    //private AudioSource _audioSource;

    //////EJERCICIOS 2////// 

    //1. Crea un método que reduzca la vida actual de un jugador. Recibe la cantidad de daño como parámetro
    public float ReduceHealth(float damage = 10)
    {
      Debug.Log("Health reduced by 10"); 
    }
    //2. Crea un método que verifique si el jugador está vivo según su vida actual
    public bool IsPlayerAlive() //(Player myPlayer)
    {
        //return myPlayer.Health > 0;
        return _playerHealth > 0; // return _playerLife > 0; 
    }
    //3. Crea un método que calcule la distancia entre dos posiciones en el espacio

    //4. Crea un método que devuelva la dirección normalizada desde un origen hacia un destino

    //5. Crea un método que devuelva el nombre actual del jugador

    //6. Crea un método que cuente la cantidad de enemigos contenidos en una lista.

    //7. Crea un método que encuentre el enemigo más cercano al jugador dentro de una lista.

    //8. Crea un método que reciba velocidad y dirección, y mueva al jugador.

    //9. Crea un método que convierta un ángulo expresado en grados a radianes.

    //10. Crea un método que intente obtener al jugador más cercano dentro de un rango dado, indicando si se encontró uno y devolviendo el jugador obtenido.

    //11. Crea un métodoque intente convertir un texto a entero, indicando si la conversación fue exitosa y devolviendo el valor obtenido.

    //12. Crea un método que reciba un ángulo en grados y devuelva la rotación correspondiente como cuaternión

    //13. Crea un método que llene una lista con todos los enemigos que se encuentren en un área dada.

    //14. Crea un método que reinicie la posición del jugador a un punto de aparición

    //15. En una clase base, crea un método diseñado para ser definido por las clases hijas

    //16. En una clase hija, redefine el méte

    //17. En la clase hija, llama al comportamiento original del método definido en la clase base.

    //18. Crea un método que devuelva el porcentaje de vida actual de un jugador respecto a su vida máxima.

    //19. Crea un método que determine si un enemigo puede esquivar un ataque según una probabilidad dada.

    //20. Crea un método que aplique una fuerza en una dirección a un Rigidbody.







    //NOTAS :v
    //lol

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    

}
