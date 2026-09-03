using JetBrains.Annotations;
using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
using Unity.Mathematics;
using Random = UnityEngine.Random;


public class Tarea2 : MonoBehaviour
{

    
    public class Player
    {
        public float health;
        public float actualhealth;
        public int DamageRecieved;
        public string Name;
        public Vector3 Position;
        public List<Player> Players;
    }

   public class Enemy:MonoBehaviour
    {
        public Vector3 Position;
        public List<Enemy> Enemies;
        public List<Enemy> enemiesFound;
        public float Dodge = 43f;

        //15
        public virtual void Attack()
        {
            Debug.Log("Attack");
        }
    }

    //1
    public float DamagedPlayer(float damageFromEnemy, Player Player)
    {

        Player.health -= damageFromEnemy;
        Debug.Log($"Recibió {damageFromEnemy} puntos de daño.");
        return damageFromEnemy;
    }

    //2
    public bool IsPlayerAlive(Player Player)
    {
        return Player.health > 0;


    }

    //3
    public float CalcularDistacia(int posicion1, int posicion2)
    {
        int distancia = posicion1 - posicion2;
        return distancia;
    }

    //4
    public Vector3 GetNormalizeDirection(Vector3 position1, Vector3 position2)
    {
        return (position2 - position1).normalized;
        
    }

    //5
    public string GetPlayerName(Player Player)
    {
        return Player.Name;
    }

    //6
    public int EnemyQuantity(List<string> Enemies)
    {
        return Enemies.Count;
    }

    //7
    public Enemy GetClosestEnemy(Player Player, List<Enemy> Enemies)
    {
        Enemy enemyClose = null;
        float minDistance = float.MaxValue;
        foreach (Enemy enemy in Enemies)
        {
            float distance = Vector3.Distance(Player.Position, enemy.Position);

            if(distance < minDistance)
            {
                minDistance = distance;
                enemyClose = enemy;
            }
        }

        return enemyClose;
    }

    //8
    public void MovePlayer(float velocity, Vector3 direction)
    {
        transform.position += direction.normalized * velocity * Time.deltaTime;
    }

    //9
    public float DegreesToRadiants(float degree)
    {
        float Radiants = Mathf.Deg2Rad * degree;
        return Radiants;
    }

    //10
    public bool FindEnemyInRange(Vector3 positions, List<Player> players, float range, out Player foundPlayer)
    {
        foundPlayer = null;
        foreach (Player player in players)
        {
            float disance = Vector3.Distance(positions, player.Position);

            if (disance < range)
            {
                foundPlayer = player;
                return true;
            }
        }

        return false;
    }

    //11
    public bool TryToConvertToInt(string text, out int number)
    {
        return int.TryParse(text, out number);
    }

    //12
    public Quaternion GetRotation(float degree)
    {
        return Quaternion.Euler(0f, degree, 0f);
    }

    //13
    public void GetEnemiesInArea(Vector3 center, float radius, List<Enemy> enemies, List<Enemy> enemiesfound)
    {
        enemiesfound.Clear();
        foreach (Enemy enemy in enemies)
        {
            float distance = Vector3.Distance(enemy.Position, center);

            if (distance <= radius)
            {
                enemiesfound.Add(enemy);
            }
        }
    }

    //14
    public void RestorePlayerPosition(Vector3 spawnpoint, Player Player)
    {
        Player.Position = spawnpoint;
    }

    //16 y 17
    public class EnemyBoss : Enemy
    {
        public override void Attack()
        {
            Debug.Log("Strong attack"); // 16

            base.Attack(); // 17
        }        
    }

    //18
    public float HealthPercentage(Player Player)
    {
        return (Player.actualhealth * Player.health) / 100f;
    }

    //19
    public bool CanDodgeEnemy(Enemy Enemy)
    {
        float probability = Random.Range(0f, 100f);

        return probability <= Enemy.Dodge;
    }

    //20
    public void AppliedForce(Rigidbody rigidbody, Vector3 direction, float force)
    {
        rigidbody.AddForce(direction.normalized * force, ForceMode.Impulse);
    }

}
