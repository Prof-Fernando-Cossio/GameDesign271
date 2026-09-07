using UnityEngine;

[Header("Serialized Fields")]
private float _movementSpeed;
[SerializeField] private float _stamina;
private float _volume;
private Rigidbody _rigidBody;
private List<string> _inventoryItems = new List<string>();
private Transform transform;

//1. Una propiedad de vida que cualquier sistema pueda leer pero solo el propio objeto pueda modificar
public int Health { get; private set; }

//2. Una propiedad calculada que determine si el jugador está muerto basado en la vida actual
public bool IsDead => Health <= 0;

//3. Una propiedad de nombre del jugador que solo pueda asignarse al crear el objeto
public string PlayerName { get; init; }

//4. Una propiedad pública de monedas que permita lectura y escritura
public int Coins { get; set; }

//5. Una propiedad de porcentaje de vida calculada automáticamante usando _currentHealth y _maxHealth
private float _currentHealth;
private float _maxHealth;
public float HealthPercent => (_currentHealth / _maxHealth) * 100f;

//6. Una propiedad que encapusle _movementSpeed usando un backing field
private float _movementSpeed
public float MovementSpeed => _movementSpeed;

//7. Una propiedad de daño que limite automáticamente el valor entre 0 y 100 usando validación personalizada
private int _damage;
public int Damage { get { return _damage; } set { _damage = Mathf.Clamp(value, 0, 100); }}

//8. Una propiedad estática que almacene la cantidad total de jugadores conectados
public static int TotalPlayersConnected { get; private set; }

//9. Una propiedad de experiencia que solo pueda modificarse internamente
public int Experience { get; private set; }

//10. Una propiedad de stamina visible públicamente pero respaldada por una variable serializada privada
[SerializeField] private float _stamina;
public float Stamina
{
    get => _stamina;
    set => _stamina = value;
} 

//11. Una propiedad booleana calculada que indique si el enemigo pude atacar dependiendo de la distancia al jugador
private float _distanceToPlayer;
private float _attackRange;
public bool CanAttack => _distanceToPlayer <= _attackRange;

//12. Una propiedad de volumen que use un full property para evitar valores negativos
public float Volume { get { return _volume; } set { _volume = Mathf.Max(0, value); }}

//13. Una propiedad readonly para la decha de creación del personaje
public string CharacterCreationDate { get; } = DateTime.Now;

//14. Una propiuedad calculada que determine si el inventario está lleno
private int _currentItemCount;
private int _maxInventoryCapacity;
public bool IsInventoryFull => _currentItemCount >= _maxInventoryCapacity;

//15. Una propiedad de nivel máximo configurable únicamente durante la inicialización usando init
public int MaxLevel { get; init; }

//16. Una propiedad de velocidad horizontal calculada usando la velocidad actual del rigidbody
public float HorizontalSpeed => new Vector2(_rigidBody.velocity.x, 0f, _rigidBody.velocity.z).magnitude;

//17. Una propiedad de energía que use private set
public float Energy { get; private set; }

//18. Una propiedad de posición actual que retorne directamente transform.position
public Vector3 ActualPosition => tranform.position;

//19. Una propiedad que exponga _inventoryItems como solo lectura externa
public List<Item> InventoryItems { get; private set; }
public List<Item> InventoryItems => new List<Item>(_inventoryItems);
public IReadOnlyList<Item> InventoryItems => _inventoryItems;

//20. Una prpieda calculada que determine si el personaje está corriendo dependiendo de la velocidad actual
public bool IsRunning => _rigidbody.velocity.magnitude >= _runSpeedThreshold;


public class Propiedades : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
