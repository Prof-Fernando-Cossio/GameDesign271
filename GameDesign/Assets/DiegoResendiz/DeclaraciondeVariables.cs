using System;
using System.Collections.Generic;
using UnityEngine;

public class DeclaraciondeVariables : MonoBehaviour
{
    [SerializeField] private float _movementSpeed = 5f;
    public int NivelJugador;
    protected int _dañoJugador = 10;
    private int _vidaJugador;
    [SerializeField] private Rigidbody _rigidBody;
    private bool _isAlive;
    internal int _puntoGuardado;
    [Range(0, 100)] [SerializeField]private float _rangoAtaque;
    public string NombreJugador;
    protected float _velocidadMovimiento;
    private MeshRenderer _meshRenderer;
    [Tooltip("Ajuste de sonido")]
    [SerializeField] private float _volumenJuego = 1f;
    private bool _puedeAtacar;
    public static GameManager Instancia;
    private List<GameObject> _objetosInventario = new List<GameObject>();
    [Obsolete("_speed")]
    [SerializeField] private float _velocidadMov;
    private Vector3 _posicionJugador;
    public int CantidadMaxJugadores;
    [SerializeField] protected float _distanciaDeteccion = 10f;
    [SerializeField] private AudioSource _fuenteSonido;







}
