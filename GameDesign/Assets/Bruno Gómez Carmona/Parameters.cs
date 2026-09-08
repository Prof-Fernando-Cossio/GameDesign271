using System;
using System.Collections.Generic;
using UnityEngine;
namespace System.Runtime.CompilerServices
{
    public interface IsExternalInit { }
}
public class Parameters : MonoBehaviour
{
    
    [SerializeField]private float _stamina;
    [SerializeField]private float EnemyAttackRange;
    [SerializeField] private float _playerDistance;
    [SerializeField]private Rigidbody _rigidbody;
    private float _currentHealth;
    private float _maxHealth;
    private float _speed;
    private int _damage;
    private int _volume;
    private int _inventorySpaceAvaible = 20;
    public Transform Player;
    private List<Item> _inventoryItems = new List<Item>();
    
    private float _actualVelocity = 2f;

    //1.- Propiedad de vida que cualquier sistema pueda leer pero solo el propio objeto pueda modificar

    public int Health { get; private set; }

    //2.- Propiedad calculada que determine si el jugador esta muerto basado en la vida actual

    public bool IsDead => Health <= 0;

    //3.- Propiedad de nombre del jugador que solo pueda asignarse al crear el objeto

    public string PlayerName { get; init; }

    //4.- Propiedad publica de monedas que permita lectura y escritura

    public int Money { get; set; }

    //5.- Propiedad de porcentaje de vida calculada automaticamente usando _currentHealth y _maxHealth

    public float HealthPercentage => _maxHealth > 0 ? (float)_currentHealth / _maxHealth * 100f : 0f;

    //6.- propiedad que encapsule _movementSpeed usando un backing field

    public float Speed 
    { 
        get => _speed;
        set => _speed = value;
    }

    //7.- Propiedad de da�o que limite automaticamente el valor entre 0 y 100 usando validacion perzonalizada

    public int Damage 
    {
        get => _damage;
        set => _damage = Mathf.Clamp(value, 0, 100);
    }

    //8.- Propiedad estatica que almacene la calidad total total de jugadores conectados

    public static int PlayerConnected { get; private set;}

    //9.- Propiedad de experiencia que solo pueda modificarse internamente

    public int Experience { get; private set; }

    //10.- Propiedad de stamina visible p�blicamente pero respaldada por una variable serializada privada

    public float Stamina
    {
        get => _stamina;
        set => _stamina = value;
    }

    //11.- Propiedad booleana calculada que indique si el enemigo puede atacar dependiendo de la distancia del jugador

    public bool CanEnemyAttack => _playerDistance <= EnemyAttackRange;

    //12.- Propiedad de volumen que use un full property para evitar valores negativos

    public int Volume 
    {
        get => _volume;
        set => _volume = Mathf.Max(0, value);
    }

    //13.- Propiedad read only para la fecha creacion del personaje

    public DateTime PlayerCreateDate { get; } = DateTime.Now;

    //14.- Propiedad calculada que determine si el inventario esta lleno

    public bool InventoryMaxedOut => _inventoryItems.Count >= _inventorySpaceAvaible;

    //15.- Propiedad de nivel maximo configurable unicamente durante la inicializacion usando init

    public int MaxLevel { get; init; }

    //16.- Propiedad de velocidad horizontal calculada usando la velocidad actual del Rigidbody

    public float HorizontalSpeed => new Vector3(_rigidbody.linearVelocity.x, 0f, _rigidbody.linearVelocity.z).magnitude; 

    //17.- Propiedad de energia que use private set

    public int Energy { get; private set; }

    //18.- Propiedad de posicion actual que retorne directamente transform.position

    public Vector3 Position => transform.position;

    //19.- Propiedad que exponga _inventoryItems como solo lectura externa

    public List<Item> InventoryItems { get; private set; }
    //public List<Item> InventoryItems => new List<Item>(_inventoryItems);
    //public IReadOnlyList<Item> InventoryItems => _inventoryItems;

    //20.- Propiedad calculada que determine si el personaje esta corriendo dependiendo de la velocidad actual

    public bool IsPlayerRunning => _rigidbody.linearVelocity.magnitude >= _actualVelocity;
}


[Serializable]
public class Item
{
    public string ItemName;
}