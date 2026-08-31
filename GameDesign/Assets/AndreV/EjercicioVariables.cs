using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;
using static UnityEditor.Progress;

public class EjercicioVariables : MonoBehaviour
{
    //1
    [SerializeField] private float _movementSpeed = 5f;
    //2
    public int PlayerLevel;
    //3
    protected int damageInicial = 10;
    //4
    private int vidaJugador;
    //5
    private Rigidbody rb;
    //6
    private bool isAlive;
    //7
    internal int saveIndex;
    // 8. 
    [SerializeField, Range(0f, 100f)] private float attackRange;
    // 9.
     public string playerName;
    // 10.
    protected float moveSpeed;
    // 11.
     private MeshRenderer meshRenderer;
    // 12.
    [SerializeField, Tooltip("Controla el volumen general del juego")] private float gameVolume;
    // 13.
    private bool canAttack;
    // 14.
    //public static GameManager Instance { get; private set; }
    // 15. 
    [SerializeField] private List<Item> inventoryItems = new List<Item>();
    // 16..
    [SerializeField, FormerlySerializedAs("_speed")] private float speed;
    // 17.
    private Vector3 playerPosition;
    // 18..
    public const int MaxPlayers = 4;
    // 19.
    //[SerializeField] protected float detectionDistance;
    // 20.
    //[SerializeField] private AudioSource audioSource;





    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
