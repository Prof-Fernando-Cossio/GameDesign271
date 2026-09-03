using System;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Serialization;
using RangeAttribute = UnityEngine.RangeAttribute;

public class Tarea : MonoBehaviour
{

    [SerializeField] private float _movementSpeed = 5f;
    internal int PlayerLevel;
    protected int BaseDamage = 10;
    private int _playerHealth;
    [SerializeField] protected Rigidbody rigidbody;
    private bool _isAlive;
    private List<int> _saveFile;
    [Range (0,100)][SerializeField] private float damage;
    internal string PlayerName;
    protected float MovementSpeedEnemy;
    private MeshRenderer _meshRenderer;
    [SerializeField] [Tooltip("Volumen del juego")]private int _gameVolume;
    private bool _canattackEnemy;
    public GameObject GameManager;
    private List<string> _inventoryItems;
    [FormerlySerializedAs("_speed")] [SerializeField] private float _Speed;
    private Vector3 _playerLocation;
    public int MaximumPlayers;
    [SerializeField]protected internal float _enemyDetection;
    [SerializeField] private AudioSource _audioSource;





    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
