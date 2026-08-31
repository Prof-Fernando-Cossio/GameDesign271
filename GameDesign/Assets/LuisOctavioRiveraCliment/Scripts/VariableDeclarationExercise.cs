using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.Serialization;

public class VariableDeclarationExercise : MonoBehaviour
{
    //1.-
    [SerializeField] private float _movementSpeed = 5f;

    //2.-
    public int ActualLevel;

    //3.- 
    protected int _baseDamage = 10;

    //4.-
    private int _currentPlayerHealth;

    //5.-
    [SerializeField] private Rigidbody _rB;

    //6.-
    private bool _isAlive;

    //7.-
    internal int GuardingIndex;

    //8.-
    [UnityEngine.Range(0, 100)]
    [SerializeField] private int _attackRange;

    //9.-
    public string CurrentPlayerName;

    //10.-
    protected float _baseMovementSpeed;

    //11.-
    private MeshRenderer _meshRenderer;

    //12.-
    [Tooltip("Modifies the game volume")]
    [Min(0.001f)] public float GameVolume;

    //13.-
    private bool _enemyCanAttack;

    //14.- 
    public static GameObject GameManager;

    //15.-
    private List<string> _inventoryObjects = new List<string> {};

    //16.-
    [FormerlySerializedAs("_speed")]
    [SerializeField] private float _newSpeed;

    //17.-
    private Vector3 _playerPosition;

    //18.-
    public int MaxPlayers;

    //19.-
    [SerializeField] protected float _enemyDetectionDistance;

    //20.-
    [SerializeField] private AudioSource _audioSource;
}
