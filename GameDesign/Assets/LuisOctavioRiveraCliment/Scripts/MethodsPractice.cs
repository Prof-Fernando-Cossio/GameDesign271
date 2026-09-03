using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
using System;
using UnityEditor.ShaderGraph.Internal;

//15
public class Character : MonoBehaviour
{
    public string Name;
    public int Health;

    public int Level;

    public virtual void Print()
    {
        Debug.Log(Name);
        Debug.Log(Health);
    }
}

//16 && 17
public class Player : Character
{
    public override void Print()
    {
        base.Print();
        Debug.Log(Level);
    }
}

public class MethodsPractice : MonoBehaviour
{
    [SerializeField] private int _currentHealth;
    private Vector3 _originPoint;
    private Vector3 _targetPoint;

    //1
    private int DamageReceived(int damageDealt, int currentHealth)
    {
        return currentHealth - damageDealt;
    }


    //2
    private bool IsPlayerAlive(Player myPlayer)
    {
        return myPlayer.Health > 0;
    }

    //3
    private float CalculateDistance(Vector3 originPoint, Vector3 targetPosition)
    {
        return Vector3.Distance(originPoint, targetPosition);
    }

    //4
    private Vector3 NormalizedDirection(Vector3 originPoint, Vector3 targetPosition)
    {
        return Vector3.Normalize(targetPosition - originPoint);
    }

    //5
    private string GetPlayerName(Player myPlayer)
    {
        return myPlayer.Name;
    }

    //6
    private int CountActiveEnemies(List<GameObject> enemies)
    {
        return enemies.Count;
    }

    //7
    private void FindEnemyCloserToPlayer(List<GameObject> enemies, Player myPlayer)
    {
        float closestDistance = float.MaxValue;
        GameObject closerEnemy = null;
        foreach (GameObject enemy in enemies)
        {
            float distance = Vector3.Distance(myPlayer.transform.position, enemy.transform.position);
            if (distance < closestDistance)
            {
                closestDistance = distance;
                closerEnemy = enemy;
            }
        }
        Debug.Log(closerEnemy);
    }

    //8
    private void CharacterMovement(float speed, Vector3 direction, CharacterController playerController)
    {
        playerController.Move(direction * speed * Time.deltaTime);
    }

    //9
    private void ConvertToRadians(float degrees)
    {
        Debug.Log((Mathf.PI * degrees) / 180);
    }

    //10
    private Player FindEnemyCloserToPlayer(List<Player> players, Vector3 pointToGo, float rangeToAnalize)
    {
        float closestDistance = float.MaxValue;
        Player closerPlayer = null;
        foreach (Player player in players)
        {
            float distance = Vector3.Distance(player.transform.position, pointToGo);
            if (distance < closestDistance && distance < rangeToAnalize)
            {
                closestDistance = distance;
                closerPlayer = player;
            }
        }
        return closerPlayer;
    }

    //11
    private bool ConvertStringToInt(string textToConvert, out int resultValue)
    {
        return int.TryParse(textToConvert, out resultValue);
    }

    //12
    private Quaternion DegreeToQuaternion(Vector3 degree)
    {
        float sinAngle, cosAngle;

        Quaternion xQuaternion = Quaternion.identity;
        Quaternion yQuaternion = Quaternion.identity;
        Quaternion zQuaternion = Quaternion.identity;

        sinAngle = Mathf.Sin(Mathf.Deg2Rad * degree.x * 0.5f);
        cosAngle = Mathf.Cos(Mathf.Deg2Rad * degree.x * 0.5f);
        xQuaternion.Set(sinAngle, 0, 0, cosAngle);

        sinAngle = Mathf.Sin(Mathf.Deg2Rad * degree.y * 0.5f);
        cosAngle = Mathf.Cos(Mathf.Deg2Rad * degree.y * 0.5f);
        yQuaternion.Set(0, sinAngle, 0, cosAngle);

        sinAngle = Mathf.Sin(Mathf.Deg2Rad * degree.z * 0.5f);
        cosAngle = Mathf.Cos(Mathf.Deg2Rad * degree.z * 0.5f);
        zQuaternion.Set(0, 0, sinAngle, cosAngle);

        return (xQuaternion * yQuaternion * zQuaternion);
    }

    //13
    private List<GameObject> EnemiesInZone(List<GameObject> enemies, float distanceToCenter, Vector3 centerPoint)
    {
        List<GameObject> enemiesInZone = new List<GameObject> { };
        foreach(GameObject enemy in enemies)
        {
            float distance = Vector3.Distance(enemy.transform.position, centerPoint);
            if( distance <= distanceToCenter)
            {
                enemiesInZone.Add(enemy);
            }
        }
        return enemiesInZone;
    }

    //14
    private void ReturnPlayerToPoint(Player myPlayer, Vector3 pointToReturn)
    {
        myPlayer.transform.position = pointToReturn;
        myPlayer.transform.rotation  = Quaternion.identity;
    }

    //18
    private float CurrentHealthPercentage(int health, int currentHealth)
    {
        if (health <= 0)
        {
            return 0f;
        }

        return (float)currentHealth / health * 100;
    }

    //19
    private bool EnemyDodge(float dodgeProbability)
    {
        float attemptToDodge = UnityEngine.Random.value;
        return attemptToDodge <= Mathf.Clamp01(dodgeProbability);
    }

    //20
    private void ApplyForceToRigidBody(Rigidbody ragdollRigidBody, Vector3 direction, float force)
    {
        ragdollRigidBody.AddForce(force * direction, ForceMode.Impulse);
    }
}
