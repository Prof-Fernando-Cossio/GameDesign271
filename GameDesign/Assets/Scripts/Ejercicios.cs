using UnityEngine;

public class Ejercicios : MonoBehaviour
{
    [SerializeField] private float _movementspeed = 5.0f;
    public int PlayerLevel { get; private set; }
    protected int BaseDamage = 10;
    public float CurrentHealth { get; private set; }
    [SerializeField] private Rigidbody _rigidbody;
    private bool _isAlive;
    internal int SaveIndex;
    [SerializeField][Range(0f, 100f)] private float _attackRange;
    public string PlayerName;
    protected float MoveSpeed;
    private MeshRenderer _meshRenderer;
    [Tooltip("Ajusta el volumen del juego")][SerializeField] private float _gameVolume;
    private bool _canAttack;
    public static GameManager Instance;
    private List<string> _inventoryItems = new List<string>();
    [FormerlySerializedAs("_speed")][SerializeField] private float _movementSpeed;
    private Vector3 _playerPosition;
    public const int MaxPlayers = 4; (o public int MaxPlayers;)
[SerializeField] protected float detectionDistance;
    [SerializeField] private AudioSource _audioSource;
}
