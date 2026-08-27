using System;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;
using RangeAttribute = UnityEngine.RangeAttribute;

public class Tarea : MonoBehaviour
{

    [SerializeField] private float _movementSpeed = 5f;
    internal int PlayerLevel;
    protected int BaseDamage = 10;
    private int _playerHealth;
    [SerializeField] protected Rigidbody rb;
    private bool _isAlive;
    private List<int> _saveFile;
    [Range (0,100)][SerializeField] private float damage;
    internal string PlayerName;
    protected float MovementSpeedEnemy;
    private MeshRenderer _meshRenderer;
    [SerializeField] [Tooltip("Volumen del juego")]private int _gameVolume;
    private bool _canAttackEnemy;
    




    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
