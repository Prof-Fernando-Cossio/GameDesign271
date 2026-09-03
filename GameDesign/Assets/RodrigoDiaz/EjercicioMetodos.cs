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
    //public void TakeDamage(int damage)
    //{
        //Debug.Log($"La vida del jugador se ve reducida {damage} puntos");
    //}

    //2.
    //public bool IsPlayerAlive(Player currentPlayer)
    //{
        //return currentPlayer.Health > 0;
    //}

    //3.
    //public float CalculateDistance(float position1, float position2)
    //{
        //float distance = position1 - position2;
        //return distance;
    //}

    //4.
    //public Vector3 GetNormalizedDirection(Vector3 origin, Vector3 goal)
    //{
        //return Vector3.Normalize(goal - origin);
    //}

    //5.
    //public string GetPlayerName(Player currentPlayer)
    //{
        //return currentPlayer.Name;
    //}

    //6.
    //public int EnemyAmmount(List<GameObject> Enemies)
    //{
        //int ammount = 0;
        //foreach (GameObject enemy in Enemies)
        //{
            //ammount++;
        //}
        //return ammount;
    //}

    //7.
    //public GameObject CLosestEnemy(List<GameObject> Enemies, Player currentPlayer)
    //{
        //GameObject closest = null;
        //float closestDistance = 10000000000f;

        //foreach (GameObject enemy in Enemies)
        //{
            //float distance = Vector3.Distance(enemy.Transform, currentPlayer.Transform);

            //if (distance < closestDistance)
            //{
                //closest = enemy;
                //closestDistance = distance;
            //}
        //}

        //return closest;
    //}

    //8.
    //public void MovePlayer(float speed, Vector3 direction, Player CurrentPlayer)
    //{
        //CurrentPlayer.Transform.Translate(direction * speed * Time.deltaTime);
    //}

    //9.
    //public float DegreestToRadians(float degrees)
    //{
        //float radians = degrees * (Mathf.PI / 180);

        //return radians;
    //}

    //10.
    //public bool FindClosestPlayerInRange(List<Player> Players, float range, out Player closestPlayer)
    //{
        //float closestDistance = 10000000000f;
        //Player closestPlayer = null;
        
        //foreach(Player player in Players)
        //{
            //float distance = Vector3.Distance(this.Transform.position - player.Transfrom.position);

            //if (distance <= range && distance < closestDistance)
            //{
                //closestDistance = distance;
                //closestPlayer = player;
            //}
        //}

        //return closestPlayer != null;
    //}

    //11.
    //public bool StringToInt(string number, out int numberConverted)
    //{
        //int numberConverted = int32.Parse(number);

        //return numberConverted;
    //}

    //12.
    //public Quaternion GetRotationInQuaternion(float degrees)
    //{
        //return Quaternion.Euler(0f, 0f, degrees);
    //}

    //13.
    //public List<GameObject> GetEnemiesInAre(List<GameObject> Enemies, Vector3 center, float area)
    //{
        //List<GameObject> EnemiesInArea = new List<GameObject>();

        //foreach(GameObject enemy in Enemies)
        //{
            //float distance = Vector3.Distance(enemy.Transform.Position, center);

            //if (distance <= area)
            //{
                //EnemiesInArea.Add(enemy);
            //}
        //}

        //return EnemiesInArea;
    //}

    //14.
    //public void ResetPlayerPosition(Transform spawnPoint, Player currentPlayer)
    //{
        //currentPlayer.Transform.position = spawnpoint.position;
    //}

    //18.
    //public float HealthPercentage(float currentHealth, float maxHealth)
    //{
        //return (currentHealth * 100f) / maxHealth;
    // }

    //19.
    //public bool CanEnemyDodge(int probability)
    //{
        //int randomNumber = Random.Range(0, 100);

        //return probability < randomNumber;
    //}

    //20.
    //public void ForceApplication(Rigidbody rigidbody, Vector3 direction)
    //{
        //rigidbody.AddForce(direction);
    //}

}

//public class Player : MonoBehaviour
//{
    //public int Health;
    //public string Name;
//}

//15.
//public class Enemy : MonoBehaviour
//{
    //public virtual void Attack()
    //{
        //Debug.Log("El enemigo ataca");
    //}
//}

//16.
//public class Dragon : Enemy
//{
    //17. 
    //base.Attack();

   // public Override void Attack()
    //{
        //Debug.Log("El enemigo tira fuego");
    //}

    
//}