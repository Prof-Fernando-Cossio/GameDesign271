using System;
using System.Collections.Generic;
using UnityEngine;



public class Tarea3 : MonoBehaviour
{

public class Player : MonoBehaviour
{
    private int health;
    private int actualHealth;
    private string name;
    private int coins;
    private float _currentHealth;
    private float _maxHealth;
    private float _movementSpeed;
    private float damage;
    private static int connectedPlayers;
    private int experience;

    [SerializeField]
    private float stamina;

    private Transform player;
    private float attackDistance = 5f;

    private float volume;
    private DateTime creationDate = DateTime.Now;

    private List<string> inventoryItems = new List<string>();
    private int inventoryCapacity = 10;

    private int maxLevel;

    private Rigidbody rigidbody;

    private float energy;

    // 1
    public int Health
    {
        get
        {
            return health;
        }

        private set
        {
            health = value;
        }
    }

    // 2
    public bool IsDead
    {
        get
        {
            return actualHealth <= 0;
        }
    }

    // 3
    public string Name
    {
        get
        {
            return name;
        }

        init
        {
            name = value;
        }
    }

    // 4
    public int Coins
    {
        get
        {
            return coins;
        }

        set
        {
            coins = value;
        }
    }

    // 5
    public float HealthPercentage
    {
        get
        {
            return (_currentHealth / _maxHealth) * 100f;
        }
    }

    // 6
    public float MovementSpeed
    {
        get
        {
            return _movementSpeed;
        }

        set
        {
            _movementSpeed = value;
        }
    }

    // 7
    public float Damage
    {
        get
        {
            return damage;
        }

        set
        {
            if (value < 0)
            {
                damage = 0;
            }
            else if (value > 100)
            {
                damage = 100;
            }
            else
            {
                damage = value;
            }
        }
    }

    // 8
    public static int ConnectedPlayers
    {
        get
        {
            return connectedPlayers;
        }

        set
        {
            connectedPlayers = value;
        }
    }

    // 9
    public int Experience
    {
        get
        {
            return experience;
        }

        private set
        {
            experience = value;
        }
    }

    // 10
    public float Stamina
    {
        get
        {
            return stamina;
        }

        set
        {
            stamina = value;
        }
    }

    // 11
    public bool CanAttack
    {
        get
        {
            float distance = Vector3.Distance(transform.position, player.position);

            return distance <= attackDistance;
        }
    }

    // 12
    public float Volume
    {
        get
        {
            return volume;
        }

        set
        {
            if (value < 0)
            {
                volume = 0;
            }
            else
            {
                volume = value;
            }
        }
    }

        // 13
        public DateTime CreationDate 
    {
        get
        {
            return creationDate;
        }
    }

    // 14
    public bool IsInventoryFull
    {
        get
        {
            return inventoryItems.Count >= inventoryCapacity;
        }
    }

    // 15
    public int MaxLevel
    {
        get
        {
            return maxLevel;
        }

        init
        {
            maxLevel = value;
        }
    }

    // 16
    public float HorizontalVelocity
    {
        get
        {
            return rigidbody.linearVelocity.x;
        }
    }

    // 17
    public float Energy
    {
        get
        {
            return energy;
        }

        private set
        {
            energy = value;
        }
    }

    // 18
    public Vector3 CurrentPosition
    {
        get
        {
            return transform.position;
        }
    }

    // 19
    public IReadOnlyList<string> InventoryItems
    {
        get
        {
            return inventoryItems;
        }
    }

    // 20
    public bool IsRunning
    {
        get
        {
            return Mathf.Abs(rigidbody.linearVelocity.x) > 0.1f;
        }
    }

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }
}
}
