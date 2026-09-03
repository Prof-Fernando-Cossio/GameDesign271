using UnityEngine;

public class EjerciciosPropiedades : MonoBehaviour
{
    // 1
    public int Health { get; private set; }

    // 2
    public bool IsDead => Health <= 0;

    // 3
    public string PlayerName { get; init; }

    // 4
    public int Coins { get; set; }

    // 5
    private float _currentHealth = 100;
    private float _maxHealth = 100;

    public float HealthPercent => (_currentHealth / _maxHealth) * 100;

    // 6
    private float _movementSpeed;
    public float MovementSpeed => _movementSpeed;

    // 7
    private int _damage;

    public int Damage
    {
        get { return _damage; }
        set { _damage = Mathf.Clamp(value, 0, 100); }
    }

    // 8
    public static int PlayerCount { get; private set; }

    // 9
    public int Experience { get; private set; }

    // 10
    [SerializeField] private float _stamina;
    public float Stamina => _stamina;

    // 11
    private float _distanceToPlayer;
    private float _attackRange = 5;

    public bool CanAttack => _distanceToPlayer <= _attackRange;

    // 12
    private float _volume;

    public float Volume
    {
        get { return _volume; }

        set
        {
            if (value < 0)
                _volume = 0;
            else
                _volume = value;
        }
    }

    // 13
    public System.DateTime CreationDate { get; } = System.DateTime.Now;

    // 14
    private int _inventoryItems;
    private int _maxInventoryItems = 10;

    public bool InventoryFull => _inventoryItems >= _maxInventoryItems;

    // 15
    public int MaxLevel { get; init; }

    // 16
    public Rigidbody rb;
    public float HorizontalSpeed => rb.velocity.x;

    // 17
    public float Energy { get; private set; }

    // 18
    public Vector3 CurrentPosition => transform.position;

    // 19
    public int InventoryItems => _inventoryItems;

    // 20
    public bool IsRunning => rb.velocity.magnitude > 0;
}