using NUnit.Framework;
using System;
using System.Reflection.Metadata.Ecma335;
using System.Collections.Generic;
using UnityEngine;
namespace System.Runtime.CompilerServices
{
   internal static class IsExternalInit
    {

    }
}


public class Propiedades : MonoBehaviour
{

    //1° Una propiedad privada que cualquier sistema pueda leer, pero solo el propio objeto pueda modificar

    public int Lecture { get; private set; }

    //2° Una propiedad calculada que determine si el jugador está muerto basado en la vida actual

    public int ActualHealth;
    public bool IsDead => ActualHealth <= 0;

    //3° Una propiedad de nombre del jugador que solo pueda asignarse al crear el objeto

    public string PlayerName { get; init; }
    //4° Una propiedad publica de monedas que permita lectura y escritura

    public int Money { get; set; }

    //5° Una propiedad de porcentaje de vida calculada automaticamente usando _currentHealth y _maxHealth
    private float _currentHealth, _maxHealth;
    public float PercentajeHealth => (_currentHealth / _maxHealth) * 100f;

    //6° Una propiedad que encapsule _movementSpeed usando backing field

    private float _movementSpeed;
    public float Speed => _movementSpeed;

    //7° Una propiedad de porcentaje que limite automaticamente el valor entre 0 y 100 usando validación personalizada
    int _valor;
    public int Valor { get { return _valor; } set { _valor = Mathf.Clamp(value, 0, 100); } }

    //8° Una propiedad estática que almacene la cantidad total de jugadores conectados
    public static int PlayersConected { get; private set; }

    //9° Una propiedad de experiencia que solo pueda modificarse internamente
    public int Experience { get; private set; }

    //10° Una propiedad de stamina visible publicamente pero respaldada por una variable serializada privada
    [SerializeField] private float _stamina;
    public float Stamina => _stamina;

    //11° Una propiedad booleana calculada que indique si el enemigo puede atacar dependiendo de la distancia al jugador
    public float AttackRange;
    public float DistanceFromPlayer;
    public bool CanAttack => AttackRange <= DistanceFromPlayer;

    //12° Una propiedad de volumen que use un full property para evitar valores negativos
    private int _volume;
    public int Volume { get { return _volume; } set { _volume = Mathf.Max(value, 0); } }

    //13° Una propiedad readonly para la fecha de creación del personaje
    private DateTime _characterDateCreation;
    public DateTime CharacterDateCreation { get { return _characterDateCreation; } }

    //14° Una propiedad calculada que determine si el inventario está lleno
    private int _inventoryOccupiedSpace, _inventory;
    public bool InventoryFull => _inventory <= _inventoryOccupiedSpace;

    //15° Una propiedad de nivel máximo configurable unicamente unicamente durante inicialización unsando init
    public int MaxLevel { get; init; }

    //16° Una propiedad de velocidad horizontal calculada usando la velocidad actual del Rigidbody
    private Rigidbody _rigidBody;
    public float HorizontalVelocity { get { return new Vector3(_rigidBody.linearVelocity.x, 0f, _rigidBody.linearVelocity.z).magnitude; } }

    //17° Una propiedad de energía que use private set

    public int Energy { get; private set; }

    //18° Una propiedad de posicion actual que retorne directamente transform.position
    public Vector3 Position => transform.position;

    //19° Una propiedad que exponga _inventoryItems como solo lectura externa
    private List<string> _inventoryItems;
    public List<string> InventoryItems{ get { return _inventoryItems; } }

    //20° Una propiedad calculada que determine si el personaje está corriendo dependiendo de la velocidad actual
    private float _running;
    private float _actualSpeed;
    public bool Running => _actualSpeed >= _running;

}
