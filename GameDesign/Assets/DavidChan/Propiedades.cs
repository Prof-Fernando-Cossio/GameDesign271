using UnityEngine;

public class Propiedades : MonoBehaviour
{
    //1.Una propiedad de vida que cualquier sistema pueda leer pero solo el propio objeto pueda modificar
    public int Life { get; private set; }

    //2.Una propiedad calculada que determine si el jugador esta muerto basado en la vida actual
    public bool IsDead => CurrentHealth <= 0;

    //3.Una propiedad de nombre del jugador que solo pueda asignarse al crear el objeto

    public string Nombre { get; init; }

    //4.Una propiedad publica de monedas que permita lectura y escritura
    public int Monedas { get; set; }

    //5.Una propiedad de porcentaje de vida calculada automaticamente usando _currentHealth y _maxHealth
    public float HealthPercent => (float)_currentHealth / (float)_maxHealth;

    //6.Una propiedad que encapsule _movementSpeed usando backing field

    private float _movementSpeed;
    public float MovementSpeed => _movementSpeed;

    //7.Una propiedad de daño que limite automaticamente el valor entre 0 y 100 usando validacion personalizada

    public float Damage { get { return _damage; } private set { _damage = Mathf.Clamp(value, 0, 100); } }

    //8.Una propiedad estatica que almacene la cantidad total de jugadores conectados

    public static int TotalPlayers { get; private set; }

    //9.Una propiedad de experiencia que solo pueda modificarse internamente

    public int Experience { get; private set; }

    //10.Una propiedad de stamina visible publicamente pero respaldada por una variable serializada privada

    [SerializeField] private float _stamina;
    public float Stamina => _stamina;

    //11.Una propiedad booleana calculada que indique si el enemigo puede atacar dependiendo de la distancia al jugador
    
    public bool EnemyCanAttack => Vector3.Distance(transform.position, player.transform.position) <= attackRange;

    //12.Una propiedad de volumen que use un full property para evitar valores negativos
    
    public float Volume { get { return _volume; } private set { _volume = Mathf.Min(value, 0, 1); } }

    //13.Una propiedad read only para la fecha de creacion del personaje

    public string CreationDate { get; } = System.DateTime.Now.ToString("yyyy-MM-dd");

    //14.Una propiedad calculada que determine si el inventario esta lleno
    
    public bool IsInventoryFull => _inventoryItems.Count >= _maxInventorySize;

    //15.Una propiedad de nivel maximo configurable unicamente durante inicializacion usando init
   
    public int MaxLevel { get; init; }

    //16.Una propiedad de velocidad horizontal calculada usando la velocidad actual del Rigidbody

    public float HorizontalSpeed => Rigidbody.velocity.x <= 0; //Este no lo entendi -_-

    //17.Una propiedad de energia que use private set

    public float Energy { get; private set; }


    //18.Una propiedad de posicion actual que retorne directamente transform.position

    public Vector3 CurrentPosition { get { return transform.position; } set { transform.position = value; } }

    //19.Una propiedad que exponga _inventoryItems como solo lectura externa
    
    public List<Item> InventoryItems { get { return _inventoryItems; } }

    //20.Una propiedad calculada que determine si el personaje esta corriendo dependiendo de la velocidad actual

    public bool IsRunning => ActualSpeed <= 6;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
