using UnityEngine;
using System.Runtime.CompilerServices;

namespace System.Runtime.CompilerServices
{
    internal static class IsExternalInit { }
}

public class PropertiesPractice : MonoBehaviour
{
    private int _currentHealth, _maxHealth;
    //1
    public int Health { get; private set; }

    //2
    private bool _isAlive => Health <= 0;

    //3
    public string PlayerName { get; init; }

    //4
    public int Coins { get; set; }

    //5
    private float _lifePercentage => (float)_currentHealth / _maxHealth * 100f;

    //6
    private float _movementSpeed;
    public float MovementSpeed => _movementSpeed;
}
