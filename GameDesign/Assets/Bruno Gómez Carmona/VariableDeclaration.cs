using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class VariableDeclaration : MonoBehaviour
{

    //1.- Un valor de velocidad que solo este script usa que sea desde el inspector. Valor inicial de 5.

    [SerializeField] private float _speed = 5f;

    //2.- nivel actual del jugador que otros sistemas del juego necesitan leer.

    public int PlayerLevel;

    //3.-Una daño base que solo las clases derivadas puedan usar. Valor inicial de 10.

    protected int _baseDamage = 10;

    //4.- La vida actual del jugador. Ningun otro script debe poder modificarla directamente.

    private int _playerHP;

    //5.- Una referencia a Rigidbody que solo este script usa y que sea editable desde el inspector.

    [SerializeField] private Rigidbody _rigidBody;

    //6.- Un valor true/false que indique si el jugador sigue vivo. solo este script lo usa.

    private bool _currentlyAlive;

    //7.- Un indice de guardado que ningun otro script fuera de este ensamblado puede acceder.

    internal int _saveIndex;

    //8.- Un rango de ataque que solo este script usa, editable desde el Inspector y limitado entre 0 y 100.

    [UnityEngine.Range(0f, 100f)]
    [SerializeField] private float _attackRange;

    //9.- El nombre actual del jugador que cualquier sistema del juego debe poder leer.

    public string PlayerName;

    //10.- Una velocidad de movimiento que las clases derivadas (enemigos, aliados, jefe, etc.) puedan reutilizar.

    protected int _globalSpeed;

    //11.- Una referencia a MeshRender que solo este script usa y que no debe verse en el inspector

    [HideInInspector] private MeshRenderer _meshRender;

    //12.- Un valor que controla el volumen del juego, editable desde el Inspector y con un mensaje de ayuda.

    [SerializeField]
    [Tooltip("Esto modifica el volumen del juego")]
    [UnityEngine.Range(0f, 100f)]
    public float GameVolume;

    //13.- Un valor true/false que indica si el enemigo puede atacar. Solo este script lo usa.

    private bool _enemyCanAttack;

    //14.- La instancia global de GameManager a la que cualquier script pueda acceder sin crearla

    public static GameManager Instance;

    //15.- Una lista para almacenar objetos del inventario. solo este la modifica.

    private List<string> _inventory = new List<string>();

    //16.- Un valor de velocidad que antes se llamaba "_speed". Debe ser editable desde el inspector

    [FormerlySerializedAs("_speed")]
    [SerializeField] private float _velocity;

    //17.-Una posición del jugador usando Vector3. solo este script la usa.

    private Vector3 _playerPosition;

    //18.- La cantidad maxima de jugadores permitido en la partida que cualquier sistema deba consultar.

    public int MaxPlayersAllowed;

    //19.- Una distancia de detección enemiga que las clases derivadas puedan reutilizar y que sea editable desde el inspector.

    [SerializeField] protected float _detectionDistance;


    //20.- Una referencia a AudioSource que solo este script usa y que sea editable desde el inspector

    [SerializeField] private AudioSource _audioSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
