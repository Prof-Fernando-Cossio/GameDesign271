using NUnit.Framework;
using System;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.Serialization;

public class EjercicioVariables : MonoBehaviour
{
    [SerializeField] private float _movementSpeed = 5f;
    internal int level = 0;
    protected int baseDamage = 10;
    private int _playerHealth = 100;
    [SerializeField] private Rigidbody rb;
    private bool _isAlive = true;
    //private Array<> 
    //[SerializeField][Min(0)] private float _damegeRange = 100;
    internal string playerName;
    protected float movementSpeed = 1.0f;
    private MeshRenderer rbMesh;
    [Tooltip("Esta variabel modifica el volumen de los sonidos del juego")][SerializeField] private int _gameVolume = 100;
    private bool _canAttack = false;
    public static GameManager Instance { get; private set; }
    private List<> _inventoryItems;
    [FormerlySerializedAs("_speed")][SerializeField] private float speed = 1f;

}
