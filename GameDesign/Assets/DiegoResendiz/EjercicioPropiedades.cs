using System;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioPropiedades : MonoBehaviour
{
    //1. Una propiedad de vida que cualquier sistema pueda leer pero solo el propio objeto pueda modificar.
    public int Life { get; private set; }
    //2. Una propiedad calculada que determine si el jugador está muerto basado en la vida actual.
    public bool IsDead
    {
        get { return Life <= 0; }
    }
    //3. Una propiedad de nombre del jugador que solo pueda asignarse al crear el objeto.
    public string PlayerName { get; init; }
    //4. Una propiedad pública de monedas que permita lectura y escritura.
    public int Coins { get; set; }
    //5. Una propiedad de porcentaje de vida calculada automáticamente usando _currentHealth y _maxHealth.
    private float _currentHealth = 50f;
    private float _maxHealth = 100f;

    public float LifePercent
    {
        get { return _currentHealth / _maxHealth; }
    }
    //6. Una propiedad que encapsule _movementSpeed usando un backing field.
    private float _movementSpeed;
    public float MovementSpeed
    {
        get{ return _movementSpeed; }
        set{ _movementSpeed = value; }
    }
    //7. Una propiedad de daño que limite automáticamente el valor entre 0 y 100 usando validación personalizada.
    private float _hurt;
    public float Hurt
    {
        get{ return _hurt; }
        set{ _hurt = Mathf.Clamp(value, 0f, 100f);}
    }
    //8. Una propiedad estática que almacene la cantidad total de jugadores conectados.
    public static int PlayerConnected { get; internal set; }
    //9. Una propiedad de experiencia que solo pueda modificarse internamente.
    public int Experience { get; set; }
    //10. Una propiedad de stamina visible públicamente pero respaldada por una variable serializada privada.
    [SerializeField] private float _stamina;
    public float Stamina
    {
        get { return _stamina; }
        set{ _stamina = value; }
    }
    //11. Una propiedad booleana calculada que indique si el enemigo puede atacar dependiendo de la distancia al jugador.
    [SerializeField] private Transform _player;
    [SerializeField] private float _attackDistance = 2f;

    public bool CanAttack
    {
        get
        {
            if (_player == null)
            {
                return false;
            }
            return Vector3.Distance(transform.position, _player.position) <= _attackDistance;
        }
    }
    //12. Una propiedad de volumen que use un full property para evitar valores negativos.
    private float _volume;
    public float Volumen
    {
        get { return _volume; }
        set { _volume = Mathf.Max(0f, value); }
    }
    //13. Una propiedad readonly para la fecha de creación del personaje.
    public DateTime CreationDate { get; } = DateTime.Now;
    //14. Una propiedad calculada que determine si el inventario está lleno.
    private List<string> _inventoryItems = new List<string>();
    private int _maxItems = 20;

    public bool FullInventory
    {
        get { return _inventoryItems.Count >= _maxItems;}
    }
    //15. Una propiedad de nivel máximo configurable únicamente durante inicialización usando init.
    public int MaxLevel { get; init; }
    //16. Una propiedad de velocidad horizontal calculada usando la velocidad actual del Rigidbody.
    [SerializeField] private Rigidbody2D _rigidBody2D;

    public float HorizonatlSpeed
    {
        get
        {
            if (_rigidBody2D != null)
            {
                return Mathf.Abs(_rigidBody2D.linearVelocity.x);
            }
            return 0f;
        }
    }
    //17. Una propiedad de energía que use private set.
    public float Energy { get; private set;}
    //18. Una propiedad de posición actual que retorne directamente transform.position.
    public Vector3 ActualPosition
    {
        get { return transform.position; }
    }
    //19. Una propiedad que exponga _inventoryitems como solo lectura externa.
    public IReadOnlyList<string> InventoryItems
    {
        get { return _inventoryItems.AsReadOnly(); }
    }
    //20. Una propiedad calculada que determine si el personaje está corriendo dependiendo de la velocidad actual.
    [SerializeField] private float _runVelocity = 5f;

    public bool isRunnnig
    {
        get { return HorizonatlSpeed > _runVelocity; }
    }

}
namespace System.Runtime.CompilerServices
{
    internal static class IsExternalInit { }
}
