using UnityEngine;

public class DeclaraciondeVariables : MonoBehaviour
{
    [SerializeField] private float _movementSpeed = 5f;
    public int NivelJugador;
    protected float dañoJugador = 10f;
    internal int _vidaJugador;
    [SerializeField] private Rigidbody _rigidBody;
    private bool _isAlive;
    internal int puntoGuardado;
    [SerializeField] [Range(0f, 100f)] private float _rangoAtaque;
    public string NombreJugador;
    protected float VelocidadMovimiento;
    private MeshRenderer _meshRenderer;
    
    [SerializeField] private float _volumenJuego;





}
