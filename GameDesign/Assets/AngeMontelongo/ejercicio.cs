using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.Serialization;

public class ejercicio : MonoBehaviour
{
    [SerializeField] private float _movementSpeed = 5f;
    public int NivelActual { get; private set;  }
    protected int baseDamage = 10;
    public int VidaActual { get; private set; }
    [SerializeField] Rigidbody playerRigidbody;
    private bool _isAlive;
    internal int saveIndex;
    [SerializeField][Range(0, 100)] private float _attackRange;
    public string PlayerName { get; private set; }
    protected float movementSpeed;
    private MeshRenderer _meshRenderer;
    [SerializeField] [Tooltip("Controlador de Volumen del Juego")] private float _audioSource;
    private bool _canAttack;
    public static ejercicio Instance { get; private set; }
    private List<GameObject> _inventoryItems = new List<GameObject>();
    [FormerlySerializedAs("_speed")][SerializeField] private float _speed;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
