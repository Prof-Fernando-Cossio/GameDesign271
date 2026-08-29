using Unity.VisualScripting;
using UnityEngine;

public class VariableDeclaration : MonoBehaviour
{
    //1. Un valor de velocidad que solo este sript usa
    //   que sea editable desde el Inspector. Valor inicial de 5

    [SerializeField] private float _movementSpeed = 5f;

    // 2. El nivel actual del jugador que otros sistemas del juego
    //    necesitan leer.

    internal int playerLevel = 0;

    // 3. Un daño base que solo las clases derivadas pueden usar.
    //    Valor inicial de 10

    protected float baseDamage = 10f;

    // 4. La vida actual del jugador. Ningún Otro script 
    //    debe poder modificarla directamente.

    private float _playerHealth = 100f;

    // 5. Una referencia a Rigidbody que solo este script usa
    //    y que sea editable desde el Inspector.

    [SerializeField] private Rigidbody _rb;

    // 6. Un valor verdadero/falso que indique si el jugador
    //    sigue vivo. Solo este script lo usa

    private bool _isPlayerAlive;

    // 7. Un indice de guardado que ningun otro script fuera de
    //    este ensamblado puede acceder

    private int _saveIndex = 0;

    // 8. Un rango de ataque que solo este srcipt usa, editable
    //    desde el Inspector y limitado entre 0 y 100

    [Range(0, 100)]
    [SerializeField] private float _atkRange;

    // 9. El nombre actual del jugador que cualquier
    //    sistema del juego debe poder leer

    public string PlayerName;
    public string PlayerNameTest = "Default Name";

    // 10. una velocidad de movimiento que las clases derivadads
    //     (enemigos, aliados, jefes, etc.) puedan reutilizar.

    public float MovementSpeed = 5f;

    // 11. Unaa referencia a MeshRenderer que solo este script usa
    //     y que NO debe verse en el Inspector

    [HideInInspector] private MeshRenderer _meshRenderer;

    // 12. Un valor que controla el volumen del juego editable
    //     desde el inspector y con un mensaje de ayuda.
    [Tooltip("Control del volumen del juego")]
    //[Range(0, 100)]
    [SerializeField] public float GameVolume;

    // 13. Un valor verdadero/falso que indica si el enemigo
    // puede atacar. Solo este script lo usa.
    
    private bool _canEnemyAttack;

    // 14. La instancia global de GameManager a la que cualquier
    //     script pueda acceder sin crearla

    [RequireComponent(typeof(GameManager))]
    public GameManager GameManagerInstance;

    // 15. Una lista para almacenar objetos del inventario.
    //     Solo este script puede modificarla.

    private List<GameObject> _inventoryItems;

    // 16. Un valor de velocidad que antes se llamaba "_speed".
    //     Debe ser editable desde el Inspector.

    [FormerlySerializedAs("_speed")]
    [SerializeField] private float _movementSpeed;

    // 17. Una posicion del jugadpr usando Vector3.
    //     Solo este script lo usa.

    private Vector3 _playerPosition;

    // 18. La cantidad maxima de jugadores permitidos en la partida
    //     que cualquier sistema deba consultar

    protected internal int MaxPlayers = 12;

    // 19. Una distancia de deteccion enemiga que las clases derivadas
    //     puedan reutilizar y que sea editable desde el Inspector.

    [SerializeField]protected float _enemyDetection = 8.5f;

    // 20. Una referencia a AudioSource que solo este script usa
    //     y que sea editable desde el Inspector.

    [SerializeField] private AudioSource _audioSource;


    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
