using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
namespace System.Runtime.CompilerServices
{
    public interface IsExternalInit { }
}
public class Parameters : MonoBehaviour
{
    private float _currentHealth;
    private float _maxHealth;
    private float _speed;
    private float _damage;
    public float EnemyAttackRange;
    private int _volume;
    private int _inventorySpaceAvaible = 20;
    public Transform Player;
    private List<GameObject> _items = new List<GameObject>();
    private Rigidbody _rigidbody;
    private float _actualVelocity;

    //1.- Propiedad de vida que cualquier sistema pueda leer pero solo el propio objeto pueda modificar

    public int Health { get; private set; }

    //2.- Propiedad calculada que determine si el jugador esta muerto basado en la vida actual

    public bool IsDead => Health <= 0;

    //3.- Propiedad de nombre del jugador que solo pueda asignarse al crear el objeto

    public string PlayerName { get; init; }

    //4.- Propiedad publica de monedas que permita lectura y escritura

    public int Money { get; set; }

    //5.- Propiedad de porcentaje de vida calculada automaticamente usando _currentHealth y _maxHealth

    public float HealthPercentage => (float)_currentHealth / _maxHealth * 100f;

    //6.- propiedad que encapsule _movementSpeed usando un backing field

    public float Speed => _speed;

    //7.- Propiedad de daño que limite automaticamente el valor entre 0 y 100 usando validacion perzonalizada

    public int Damage { set { _damage = Mathf.Clamp(value, 0, 100); } }

    //8.- Propiedad estatica que almacene la calidad total total de jugadores conectados

    public static int PlayerConnected { get; set;}

    //9.- Propiedad de experiencia que solo pueda modificarse internamente

    public int Experience { get; private set; }

    //10.- Propiedad de stamina visible públicamente pero respaldada por una variable serializada privada

    [SerializeField] private int _stamina;
    public float Stamina => _stamina;

    //11.- Propiedad booleana calculada que indique si el enemigo puede atacar dependiendo de la distancia del jugador

    public bool CanEnemyAttack => Vector3.Distance(transform.position, Player.position) <= EnemyAttackRange;

    //12.- Propiedad de volumen que use un full property para evitar valores negativos

    public int Volume { set { _volume = Mathf.Clamp(value, 0, 100); } }

    //13.- Propiedad read only para la fecha creacion del personaje

    public string PlayerCreateDate { get; }

    //14.- Propiedad calculada que determine si el inventario esta lleno

    public bool InventoryMaxedOut => (int) _inventorySpaceAvaible == 0;

    //15.- Propiedad de nivel maximo configurable unicamente durante la inicializacion usando init

    public int MaxLevel { get; init; }

    //16.- Propiedad de velocidad horizontal calculada usando la velocidad actual del Rigidbody

    public float HorizontalSpeed => _rigidbody.linearVelocity.x; 

    //17.- Propiedad de energia que use private set

    public int Energy { get; private set; }

    //18.- Propiedad de posicion actual que retorne directamente transform.position

    public Vector3 Position { get { return transform.position; } }

    //19.- Propiedad que exponga _inventoryItems como solo lectura externa

    public List<GameObject> Items { get {return _items;} }

    //20.- Propiedad calculada que determine si el personaje esta corriendo dependiendo de la velocidad actual

    public bool IsPlayerRunning => _actualVelocity >= 5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
