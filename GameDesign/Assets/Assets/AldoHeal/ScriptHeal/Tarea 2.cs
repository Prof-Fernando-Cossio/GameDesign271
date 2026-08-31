using JetBrains.Annotations;
using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class Tarea2 : MonoBehaviour
{

    
    public class Player
    {
        public int health;
        public int DamageRecieved;
        public string Name;
    }

   


    public float DamagedPlayer(float damageFromEnemy)
    {

        float damageRecieve = 5f;
        Debug.Log($"Recibió {damageRecieve} puntos de daño.");
        return damageRecieve;
    }

    public bool IsPlayerAlive(Player Player)
    {
        return Player.health > 0;


    }

    public float CalcularDistacia(int posicion1, int posicion2)
    {
        int distancia = posicion1 - posicion2;
        return distancia;
    }

    public Vector3 GetNormalizeDirection(Vector3 position1, Vector3 position2)
    {
        return Vector3.Normalize(position2 - position1);
        
    }

    public string GetPlayerName(Player Player)
    {
        return Player.Name;
    }

    public int EnemyQuantity(List<string> Enemies)
    {
        return Enemies.Count;
    }




    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
