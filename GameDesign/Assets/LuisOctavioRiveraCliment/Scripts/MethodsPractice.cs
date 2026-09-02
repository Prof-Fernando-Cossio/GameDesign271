using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
using System;

public class Player : MonoBehaviour
{
    public string Name;
    public int Health;
}

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
    private bool IsPlayerAlive(Player myPlayer)
    {
        return myPlayer.Health > 0;
    }

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
    private string GetPlayerName(Player _myPlayer)
    {
        return _myPlayer.Name;
    }

    //6
    private int CountActiveEnemies(List<GameObject> _enemies)
    {
        return _enemies.Count;
    }

    //7
    private void FindEnemyCloserToPlayer(List<GameObject> _enemies, Player _myPlayer)
    {
        float _closestDistance = 100f;
        GameObject _closerEnemy = _enemies[0];
        foreach (GameObject _enemy in _enemies)
        {
            float distance = Vector3.Distance(_myPlayer.transform.position, _enemy.transform.position);
            if (distance < _closestDistance)
            {
                _closestDistance = distance;
                _closerEnemy = _enemy;
            }
        }
        Debug.Log(_closerEnemy);
        Debug.Log(_closestDistance);
    }

    //8
    private void CharacterMovement(float _speed, Vector3 _direction, CharacterController _playerController)
    {
        _playerController.Move(_direction * _speed * Time.deltaTime);
    }

    //9
    private void ConvertToRadians(float _degrees)
    {
        Debug.Log((Mathf.PI * _degrees) / 180);
    }

    //10
    private Player FindEnemyCloserToPlayer(List<Player> _players, Vector3 _pointToGo, float _rangeToAnalize)
    {
        float _closestDistance = 100f;
        Player _closerPlayer = _players[0];
        foreach (Player _player in _players)
        {
            float _distance = Vector3.Distance(_player.transform.position, _pointToGo);
            if (_distance < _closestDistance && _distance < _rangeToAnalize)
            {
                _closestDistance = _distance;
                _closerPlayer = _player;
            }
        }
        return _closerPlayer;
    }

    //11
    private bool ConvertStringToInt(string _textToConvert)
    {
        return Int32.TryParse(_textToConvert, out _);
    }

    //12

}
