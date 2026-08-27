using NUnit.Framework;
using System;
using UnityEngine;

public class VariableDeclarationS : MonoBehaviour
{
    //1° Un valor de velocidad que solo este script usa que sea editable desde el Inspector. Valor inicial de 5
    [SerializeField] private float _movementSpeed = 5f;

    //2° El nivel actual del jugador que otros sistemas del juego necesitan leer
    public int ActualLevel;

    //3° Un daño base que solo las clases derivadas pueden usar. Valor inicial de 10
    protected int _baseDamage = 10;

    //4° La vida actual del jugador. Ningun otro script debe poder modificarla directamente
    private int _actualHealthPlayer;

    //5° Una referencia a RigidBody que solo este script usa y sea editable desde el inspector
    [SerializeField] private Rigidbody _rb;

    //6° Un valor verdadero/falso que indique si el jugador sigue vivo. Solo este script lo usa.
    private bool _isAlive;

    //7° Un indice de guardado que ningun otro script fuera de este ensamblado puede acceder
    internal Array checkPoint;

    //8° Un rango de ataque que solo este scrip usa, editable desde el inspector y limitado entre 0 y 100
    [SerializeField] private int _rangeAttack;

    //9° El nombre actual del jugador que cualquier sistema del juego debe poder leer
    public string PlayerName;

    //10° Una velocidad de movimiento que las clases derivadas (enemigos, aliados, jefes, etc.) puedan reutilizar
    protected float _multipleSpeed;

    //11° Una referencia a MeshRender que solo este scripct usa y que No debe verse en el Inspector;
    private MeshRenderer _mh;

    //12° Un valor que controla el volumen del juego, editable desde el inspector y con mensaje de ayuda
    [Tooltip("Change Audio")][SerializeField] private float _volumeGame;

    //13° 
}
