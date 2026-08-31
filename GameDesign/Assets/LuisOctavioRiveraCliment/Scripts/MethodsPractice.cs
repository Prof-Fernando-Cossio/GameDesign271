using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class MethodsPractice : MonoBehaviour
{
    [SerializeField] private int _currentHealth;
    private Vector3 _originPoint;
    private Vector3 _targetPoint;

    //1
    private int DamageReceived(int _damageDealt, int _currentHealth)
    {
        return _currentHealth - _damageDealt;
    }

    //2
    /*
    private bool IsPlayerAlive(Player myPlayer)
    {
        return myPlayer.Health > 0;
    }
    */

    //3
    private float CalculateDistance(Vector3 _originPoint, Vector3 _targetPosition)
    {
        return Vector3.Distance(_originPoint, _targetPosition);
    }

    //4
    private Vector3 NormalizedDirection(Vector3 _originPoint, Vector3 _targetPosition)
    {

        return Vector3.Normalize(_targetPosition - _originPoint);
    }

    //5
    /*
    private string GetPlayerName(Player _myPlayer)
    {
        return _myPlayer.Name;
    }
    */

    //6
    private int CountActiveEnemies(List<GameObject> _enemies)
    {
        return _enemies.Count;
    }

    private void FindEnemyCloserToPlayer(List<GameObject> _enemies, Player _myPlayer)
    {
        float _closestDistance = 100f;
        GameObject _closerEnemy;
        foreach(GameObject _enemy in _enemies)
        {
            float distance = Vector3.Distance(_myPlayer.transform.position, _enemy.transform.position);
            if(distance > _closestDistance)
            {
                _closestDistance = distance;
                _closerEnemy = _enemy;
            }
        }
    }
}
