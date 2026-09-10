using System;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;



public class Tarea3 : MonoBehaviour
{

    [Header("Serialized Fields")]
    [SerializeField] private float _stamina;
    [SerializeField] private float _distanceToPlayer;
    [SerializeField] private float _attackRange = 2f;
    [SerializeField] private Rigidbody _rigidbody;

    [Header("Backing Fields")]
    private int _currentHealth = 100;
    private int _maxHealth = 100;
    private float _movementSpeed;
    private int _damage;
    private float _volume;
    private int _maxInventorySize = 20;
    private List<Item> _inventoryItems = new List<Item>();
    private float _runSpeedThreshold = 5f;

    // 1. Una propiedad de vida que cualquier sistema pueda leer pero solo el propio objeto pueda modificar.
    public int Health { get; private set; }

    // 2. Una propiedad calculada que determine si el jugador est� muerto basado en la vida actual.
    public bool IsDead => Health <= 0;

    // 3. Una propiedad de nombre del jugador que solo pueda asignarse al crear el objeto.
    public string PlayerName { get; init; }

    // 4. Una propiedad p�blica de monedas que permita lectura y escritura.
    public int Coins { get; set; }

    // 5. Una propiedad de porcentaje de vida calculada autom�ticamente usando _currentHealth y _maxHealth.
    public float HealthPercent => _maxHealth > 0 ? (float)_currentHealth / _maxHealth * 100f : 0f;

    // 6. Una propiedad que encapsule _movementSpeed usando un backing field.
    public float MovementSpeed
    {
        get => _movementSpeed;
        set => _movementSpeed = value;
    }

    // 7. Una propiedad de da�o que limite autom�ticamente el valor entre 0 y 100 usando validaci�n personalizada.
    public int Damage
    {
        get => _damage;
        set => _damage = Mathf.Clamp(value, 0, 100);
    }
    
    // 8. Una propiedad est�tica que almacene la cantidad total de jugadores conectados.
    public static int TotalPlayers { get; private set; }

    // 9. Una propiedad de experiencia que solo pueda modificarse internamente.
    public int Experience { get; private set; }

    // 10. Una propiedad de stamina visible p�blicamente pero respaldada por una variable serializada privada.
    public float Stamina
    {
        get => _stamina;
        private set => _stamina = value;
    }

    // 11. Una propiedad booleana calculada que indique si el enemigo puede atacar dependiendo de la distancia al jugador.
    public bool CanAttack => _distanceToPlayer <= _attackRange;

    // 12. Una propiedad de volumen que use un full property para evitar valores negativos.
    public float Volume
    {
        get => _volume;
        set => _volume = Mathf.Max(0f, value);
    }

    // 13. Una propiedad readonly para la fecha de creaci�n del personaje.
    public DateTime CreationDate { get; } = DateTime.Now;

    // 14. Una propiedad calculada que determine si el inventario est� lleno.
    public bool IsInventoryFull => _inventoryItems.Count >= _maxInventorySize;

    // 15. Una propiedad de nivel m�ximo configurable �nicamente durante inicializaci�n usando init.
    public int MaxLevel { get; init; }

    // 16. Una propiedad de velocidad horizontal calculada usando la velocidad actual del Rigidbody.
    public float HorizontalSpeed => new Vector3(_rigidbody.linearVelocity.x, 0f, _rigidbody.linearVelocity.z).magnitude;

    // 17. Una propiedad de energ�a que use private set.
    public float Energy { get; private set; }

    // 18. Una propiedad de posici�n actual que retorne directamente transform.position.
    public Vector3 CurrentPosition => transform.position;

    // 19. Una propiedad que exponga _inventoryItems como solo lectura externa usando List<Item>.
    public List<Item> InventoryItems { get; private set; }

    //public List<Item> InventoryItems => new List<Item>(_inventoryItems);

    //public IReadOnlyList<Item> InventoryItems => _inventoryItems;

    // 20. Una propiedad calculada que determine si el personaje est� corriendo dependiendo de la velocidad actual.
    public bool IsRunning => _rigidbody.linearVelocity.magnitude >= _runSpeedThreshold;
}

[Serializable]
public class Item
{
    public string Name;
}

