using System.Collection.Generic;
using UnityEngine.Serialization;
using UnityEngine;

public class VariableDeclaration : MonoBehaviour
{

    // 1. Un valor de velocidad que solo este script usa
    // que sea editable desde el Inspector. Valor inicial de 5.
    [SerializeField] private float _movementSpeed = 5f;

    // 2. El nivel actual del jugador que otros sistemas del juego necesitan leer
    public int CurrentLevel;

    // 3. Un daño base que solo las clases derivadas pueden usar.
    // valor inicial de 10
    protected int _baseDamage = 10;

    // 4. La vida actual del jugador. Ningún otro script debe poder modificarla directamente.
    private int _currentHealth;

    // 5. Una referencia a Rigidbody que solo este script usa y que sea editable desde el Inspector.
    [SerializeField] private Rigidbody _rigidbody;

    // 6. Un valor verdadero/falso que indique si el jugador sigue vivo. Solo este script lo usa.
    private bool _isAlive;

    // 7. Un índice de guardado que ningún otro script fuera de este ensamblado pueda acceder
    internal int _saveGame;

    // 8. Un rango de ataque que solo este script usa, editable desde el inspector y limitado entre 0 y 100
    [Range(0, 100)][SerializeField] private int _attackRange;

    // 9. El nombre actual del jugador que cualquier sistema del juego debe poder leer.
    public string PlayerName;

    // 10. Una velocidad de movimiento que las clases derivadas (enemigos, aliados, jefes, etc.) puedan reutilizar.
    protected float _moveSpeed;

    // 11. Una referencia a MeshRenderer que solo este script usa y que NO debe verse en el Inspector 
    private MeshRenderer _meshRenderer;

    // 12. Un valor que controla el volumen del juego, editable desde el inspector y con un mensaje de ayuda
    [Tooltip("Controla el volumen del juego")]
    [SerializeField] private float _masterVolume = 1f;

    // 13. Un valor de verdadero/falso que indica si el enemigo puede atacar. Solo este script lo usa
    private bool _canAttack;

    // 14. La instancia global de GameManager a la que cualquier script pueda acceder sin crearla
    public static GameManager Instance;

    // 15. Una lista para almacenar objetos del inventario. Solo este script la modifica
    private List<Item> _inventory = new List<Item>();

    // 16. Un valor de velocidad que antes se llamaba "_speed". Debe ser editable desde el Inspector.
    [FormerlySerializedAs("_speed")]
    [SerializeField] private float _renamedMovementSpeed = 5f;

    // 17. Una posición del jugador usando Vector3. Solo este script la usa.
    private Vector3 _playerPosition; 

    // 18. La canitdad máxima de jugadores permitidos en la partida, que cualquier sistema deba consultar.
    public int MaxPlayers;

    // 19. Una distancia de detección enemiga que las clases derivadas puedan reutilizar y que sea editable desde el Inpesctor
    [SerializeField] protected float _detectionDistance = 10f;

    // 20. Una referencia a AudioSource que solo este script usa y que sea editable desde el Inspector
   [SerializeField]  private AudioSource _audioSource;

    public class GameMnager : MonoBehaviour
    {
    }

    [System.Serializable]
    public class Item
    {
        public string Name;
    }





    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    

}
