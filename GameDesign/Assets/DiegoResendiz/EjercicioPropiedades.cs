using System.Collections.Generic;
using System;
using UnityEngine;

public class EjercicioPropiedades : MonoBehaviour
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
    //1. Una propiedad de vida que cualquier sistema pueda leer pero solo el propio objeto pueda modificar.
    public int Life { get; private set; }
    //2. Una propiedad calculada que determine si el jugador está muerto basado en la vida actual.
    public bool IsDead => Life <= 0;
    //3. Una propiedad de nombre del jugador que solo pueda asignarse al crear el objeto.
    public string PlayerName { get; init; }
    //4. Una propiedad pública de monedas que permita lectura y escritura.
    public int Coins { get; set; }
    //5. Una propiedad de porcentaje de vida calculada automáticamente usando _currentHealth y _maxHealth.
    public float HealthPercent => _maxHealth > 0 ? (float)_currentHealth / _maxHealth * 100f : 0f;
    //6. Una propiedad que encapsule _movementSpeed usando un backing field.
    public float MovementSpeed
    {
        get =>_movementSpeed; 
        set => _movementSpeed = value;
    }
    //7. Una propiedad de daño que limite automáticamente el valor entre 0 y 100 usando validación personalizada.
    public int Damage
    {
        get => _damage;
        set => _damage = Mathf.Clamp(value, 0, 100);
    }
    //8. Una propiedad estática que almacene la cantidad total de jugadores conectados.
    public static int PlayerConnected { get; private set; }
    //9. Una propiedad de experiencia que solo pueda modificarse internamente.
    public int Experience { get; private set; }
    //10. Una propiedad de stamina visible públicamente pero respaldada por una variable serializada privada.
    public float Stamina
    {
        get => _stamina; 
        set => _stamina = value;
    }
    //11. Una propiedad booleana calculada que indique si el enemigo puede atacar dependiendo de la distancia al jugador.
    public bool CanAttack => _distanceToPlayer <= _attackRange;
    //12. Una propiedad de volumen que use un full property para evitar valores negativos.
    public float Volumen
    {
        get => _volume; 
        set => _volume = Mathf.Max(0f, value); 
    }
    //13. Una propiedad readonly para la fecha de creación del personaje.
    public DateTime CreationDate { get; } = DateTime.Now;
    //14. Una propiedad calculada que determine si el inventario está lleno.
    public bool IsInventoruFull => _inventoryItems.Count >= _maxInventorySize;
    //15. Una propiedad de nivel máximo configurable únicamente durante inicialización usando init.
    public int MaxLevel { get; init; }
    //16. Una propiedad de velocidad horizontal calculada usando la velocidad actual del Rigidbody.
    public float HorizontalSpeed => new Vector3(_rigidbody.linearVelocity.x, 0f, _rigidbody.linearVelocity.z).magnitude;
    //17. Una propiedad de energía que use private set.
    public float Energy { get; private set;}
    //18. Una propiedad de posición actual que retorne directamente transform.position.
    public Vector3 CurrentPosition => transform.position;
    //19. Una propiedad que exponga _inventoryitems como solo lectura externa.
    public IReadOnlyList<Item> InventoryItems => _inventoryItems;
    //20. Una propiedad calculada que determine si el personaje está corriendo dependiendo de la velocidad actual.
    public bool isRunnnig => _rigidbody.linearVelocity.magnitude >= _runSpeedThreshold;

}

[Serializable]
public class Item
{
    public string Name;
}

namespace System.Runtime.CompilerServices
{
    internal static class IsExternalInit {}
}
