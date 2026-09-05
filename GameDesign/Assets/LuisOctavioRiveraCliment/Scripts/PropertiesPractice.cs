using UnityEngine;
using System.Runtime.CompilerServices;
using TMPro;
using NUnit.Framework;
using System.Collections.Generic;

namespace System.Runtime.CompilerServices
{
    internal static class IsExternalInit { }
}

public class PropertiesPractice : MonoBehaviour
{
    private int _damage;
    private float _attackRange;
    private int _gameVolume;
    private int _availableSpaces;
    Player _player;
    Rigidbody _rigidBody;
    private List <string> _inventoryItems = new List<string>();
    [SerializeField]private float _runningVelocity;

    private int _currentHealth, _maxHealth;

    //1
    public int Health { get; private set; }

    //2
    private bool _isAlive => Health <= 0;

    //3
    public string PlayerName { get; init; }

    //4
    public int Coins { get; set; }

    //5
    private float _lifePercentage => (float)_currentHealth / _maxHealth * 100f;

    //6
    private float _movementSpeed;
    public float MovementSpeed => _movementSpeed;

    //7
    public int Damage { get { return _damage; } set { _damage = Mathf.Clamp(value, 0, 100); } }

    //8
    public static int PlayerCount {  get; private set; }

    //9
    public float Experience { get; private set; }

    //10
    [SerializeField] private int _stamina;
    public int Stamina => _stamina;

    //11
    private bool _canAttack => Vector3.Distance(_player.transform.position, this.transform.position) <= _attackRange;

    //12
    public int GameVolume { get { return _gameVolume; } set { _gameVolume = Mathf.Clamp(value, 0, 100);} }

    //13
    public string CharacterCreationDate { get; }

    //14
    private bool _isInventoryFull => (int)_availableSpaces == 0;

    //15
    public int MaxLevel { get; init; }

    //16
    private float _actualVelocityX => _rigidBody.linearVelocity.x;

    //17
    public float Energy { get; private set; }

    //18
    public Vector3 ActualPosition { get { return transform.position; } }

    //19
    public List<string> InventoryItems { get { return _inventoryItems; }}

    //20
    private bool _isCharacterRunning => _rigidBody.linearVelocity.magnitude >= _runningVelocity;
}
