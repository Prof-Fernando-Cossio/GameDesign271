using System.Data;
using System.Runtime.CompilerServices;
using TMPro.Examples;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class ejercicios4 : MonoBehaviour
{
    private float _currentHealth = 100f;
    private float _maxHealth = 100f;
    private float _movementSpeed;
    private int _damage;
    private float _distancetoPlayer;
    private float _attackRange = 5;
    private float _volume;
    [SerializeField] private float _stamina;




    public int Health { get; private set; }
    public bool IsDead => Health <= 0;
    public string PlayerName { get; init; }
    public int Coins { get; set; }
    public float HeathPercentage => _currentHealth / _maxHealth * 100f;
    public float MovementSpeed => _movementSpeed;
    public int Damage
    {
        get {  return _damage; }
        set { _damage = Mathf.Clamp(value, 0, 100); }
    }
    public static int PlayerCount { get; private set; }
    public int Experience { get; private set; }
    public float Stamina => _stamina;
    public bool CanAttack => _distancetoPlayer <= _attackRange;
    public float Volume
    {
        get { return _volume; }
        set {
            if (value < 0) Volume = 0;
            else _volume = value;
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
