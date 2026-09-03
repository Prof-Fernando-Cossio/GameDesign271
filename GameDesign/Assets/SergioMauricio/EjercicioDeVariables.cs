using UnityEditor.Build.Content;
using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using System;
using UnityEngine.Serialization;

public class EjercicioDeVariables : MonoBehaviour
{
    //1° Un valor de velocidad que solo este script usa que sea editable desde el Inspector. valor inicial de 5

    [SerializeField] private float _speedObject = 5f;

    //2° El nivel actual del jugador que otros sistemas del juego necesitan leer

    public int PlayerLevel;

    //3° Un daño base que solo las clases derivadas pueden usar, valor inicial de 10

    protected int _baseDamage = 10;

    //4° La vida actual del jugador. Ningun otro script debe poder modificarla directamente

    private int _actualHealth;

    //5° Una referencia a Rigidbody que solo este script usa y sea editable desde el inspector

    [SerializeField] private Rigidbody _rigidBody;

    //6° Un valor verdadero/falso que indique si el jugador sigue vivo. Solo este script lo usa.

    private bool _isAlive;

    //7° Un indice de guardado que ningun otro script fuera de este ensamblado pueda acceder.

    internal int _checkPoint;

    //8° Un rango de ataque que solo este script usa, es editable desde el Inspector y limitado entre 0 y 100

    [Range(0, 100)]
    [SerializeField] private float _rangeAttack = 10f;

    //9° El nombre atual del jugador que cualquier sistema del juego debe poder leer

    public string PlayerName;

    //10° Una velocidad de movimiento que las clases derivadas (enemigos, aliados, jefes, etc.) puedan reutilizar

    protected float _baseSpeed;

    //11°Una referencia a MeshRenderer que solo este script usa y que no debe verse en el inspector
    private MeshRenderer _meshRenderer;

    //12° Un valor que controla el volumen del juego, editable desde el inspector y con un mensaje de ayuda

    [Tooltip("Ajuste de volumen")]
    [SerializeField] internal float _volumeGame = 1f;

    //13° Un valor verdadero/falso que indica si el enemigo puede atacar. Solo este script lo usa
    private bool _canAttack;

    //14° La instancia global de GameManager a la que cualquier script puede acceder sin crearla

    public static GameManager Instance;

    //15° Una lista para almacenar objetos del inventario. Solo este script la modifica

    private List<Item> _playerInventory = new List<Item>();

    //16°Un valor de velocidad que antes se llamaba "_speed", debe ser editable desde el editor.

    [FormerlySerializedAs("_speed")]
    [SerializeField] public float _renamedSpeed = 5f;

    //17° Una posicion del jugador usando Vector3, solo este script la usa.

    private Vector3 _playerPosition;

    //18° La cantidad máxima de jugadores permitidos en la partida que un sistema deba consultar

    public int MaxPlayer;

    //19° Una distancia de detección enemiga que las clases derivadas puedan reutilizar y que sea editable desde el inspector

    [SerializeField] protected float _enemyDetection = 15f; 

    //20° Una referencia a AudioSource que solo este script usa y que sea editable desde el inspector.

    [SerializeField] private AudioSource _audioSource;

    public class GameManager : MonoBehaviour
    {

    }

    [System.Serializable]
    public class Item
    {
        public string Name;
    }
}
