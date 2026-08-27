using Unity.VisualScripting;
using UnityEngine;

public class VariableDeclaration : MonoBehaviour
{
    //1. Un valor de velocidad que solo este sript usa
    //   que sea editable desde el Inspector. Valor inicial de 5

    [SerializeField] private float _movementSpeed = 5f;

    // 2. El nivel actual del jugador que otros sistemas del juego
    //    necesitan leer.

    internal int playerLevel = 0;

    // 3. Un daño base que solo las clases derivadas pueden usar.
    //    Valor inicial de 10

    protected float baseDamage = 10f;

    // 4. La vida actual del jugador. Ningún Otro script 
    //    debe poder modificarla directamente.

    private float _playerHealth = 100f;

    // 5. Una referencia a Rigidbody que solo este script usa
    //    y que sea editable desde el Inspector.

    [SerializeField] private Rigidbody _rb;

    // 6. Un valor verdadero/falso que indique si el jugador
    // sigue vivo. Solo este script lo usa

    private bool _isPlayerAlive;

    // 7. Un indice de guardado que ningun otro script fuera de
    // este ensamblado puede acceder


    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
