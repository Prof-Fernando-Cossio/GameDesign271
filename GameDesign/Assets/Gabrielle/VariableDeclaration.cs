using System.Runtime.CompilerServices;
using UnityEngine;

public class VariableDeclaration : MonoBehaviour
{
    // 1. Un valor de velocidad que solo este script usa
    // que sea editable desde el Inspector. Valor inicial de 5.

    [SerializeField] private float _movementSpeed = 5f;

    // 2. El nivel actual del jugador que otros sistemas del juego necesitan leer

    internal int PlayerLevel = 1;

    // 3. Un daño base que solo las clases derivadas pueden usar.
    //  valor inicial de 10

    protected int _baseDamage = 10;

    // 4. La vida actual del jugador. Ningún otro script debe poder modificarla directamente.

    private int _playerHealth = 100;

    // 5. Una referencia a Rigidbody que solo este script usa y que sea editable desde el Inspector.


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
