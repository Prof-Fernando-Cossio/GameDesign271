using NUnit.Framework;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class EjercicioMetodos : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    
    //1.
    public void TakeDamage(int damage)
    {
        Debug.Log($"La vida del jugador se ve reducida {damage} puntos");
    }

    //2.
    public bool IsPlayerAlive(Player currentPlayer)
    {
        return currentPlayer.Health > 0;
    }

    //3.
    public float CalculateDistance(float position1, float position2)
    {
        float distance = position1 - position2;
        return distance;
    }

    //4.
    public Vector3 GetNormalizedDirection(Vector3 origin, Vector3 goal)
    {
        return Vector3.Normalize(goal - origin);
    }

    //5.
    public string GetPlayerName(Player currentPlayer)
    {
        return currentPlayer.Name;
    }

    //6.
    public int EnemyAmmount(List<GameObject> Enemies)
    {
        int ammount = 0;
        //foreach (enemy in Enemies)
        {
            ammount++;
        }
        return ammount;
    }
}

public class Player : MonoBehaviour
{
    public int Health;
    public string Name;
}