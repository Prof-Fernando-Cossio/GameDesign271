using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Ejercicio2 : MonoBehaviour
{
    public float _playerLife = 100f;
    private string _playerName = "Mistuki";
    public void ReceiveDamage(float damage)
    {
        _playerLife = _playerLife - damage;
    }
    public bool IsPlayerAlive()
    {
        return _playerLife > 0;
    }
    public float DistanceCalculate(Vector3 position1, Vector3 position2)
    {
        return Vector3.Distance(position1, position2);
    }
    public Vector3 GetDirection(Vector3 inicio, Vector3 fin)
    {
        return (fin - inicio).normalized;
    }
    public string GetPlayerName()
    {
        return _playerName; 
    }
    public int EnemiesCount(List<GameObject> enemies)
    {
        return enemies.Count;
    }
    public GameObject CloseEnemies(List<GameObject> enemies, Vector3 playerPosition)
    {
        GameObject closestEnemy = null;
        float closestDistance = Mathf.Infinity;
        foreach (GameObject enemy in enemies)
        {
            float distance = Vector3.Distance(playerPosition, enemy.transform.position);
            if (distance < closestDistance)
            {
                closestDistance = distance;
                closestEnemy = enemy;
            }
        }
        return closestEnemy;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
