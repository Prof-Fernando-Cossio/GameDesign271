using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using Unity.VisualScripting;
using UnityEngine;

public class MetodosEjercicio : MonoBehaviour
{
    [SerializeField] private int _playerHealth;
    [SerializeField] private int _playerCurrentHealth;
    //1° Crea un método que reduzca la vida actual de un jugador. Recibe la cantidad de daño como parámetro.
    private void DamageToPlayer(int _damageEnemy)
    {
        _damageEnemy =- _playerCurrentHealth;
    }

    //2°Crea un método que verifique si el jugador está vivo según su vida actual
    /*
    private bool IsPlayerAlive (Player _myPlayer)
    {
        return Player.Health > 0;

        return _playerLife > 0;
        
    }
    */
    //3° Crear un metodo que calcule la distancia entre dos posiciones en el espacio

    private void DistanceOfTwoPoints(Vector3 _firstPoint, Vector3 _secondPoint)
    {
        Vector3.Distance(_firstPoint, _secondPoint);

    }

    //°4 Crea un método que devuelva la direccion normalizada desde un origen hasta su destino

    private Vector3 NormalizeDirection (Vector3 _originPoint, Vector3 _destinyPoint)
    {

        return Vector3.Normalize(_originPoint - _destinyPoint);
    }
    //5° Crea un método que devuelva el nombre actual del jugador
    /*
    private string GetPlayerName(Player _playerName) 
    { 
        return _playerName.Name;
    }
    */

    //6° Crea un metodo que cuente la cantidad de enemigos contenidos en una lista

    private void EnemyList(List<int> _enemyList)
    {
        foreach (int enemy in _enemyList) 
        {
            int _enemyNumber =+ 1 ;
        }
    }

    //7° Crea un metodo que encuentre al enemigo mas cercano al jugador dentro de una lista

    private void FindEnemy(List<Vector3> _enemyList, Vector3 _playerPoint)
    {
        foreach (Vector3 _enemy in _enemyList) 
        {
            float _enemyDistance = Vector3.Distance(_enemy, _playerPoint);

            float? _enemyNearby = null;
            if ( _enemyDistance < _enemyNearby)
            {
                _enemyNearby = _enemyDistance;
            }
        }
    }

    //8° Crea un metodo que reciba velocidad y dirección y mueva al jugador

    private void MovementPlayer(Vector3 _directionPlayer, float _velocityPlayer)
    {
        transform.position += _directionPlayer * _velocityPlayer * Time.deltaTime;
    }

    //9° Crea un metodo que convierta un angulo expresado en grados a radianes

    private void GradesToRadian (double _angleInGrades)
    {
        double _angleInRadian = _angleInGrades * 3.1416 / 180;
    }

    //10°Crear un metodo que intente obtener al jugador mas cercano dentro de un rango dado, indicando si se encontró uno y devolviendo el jugador obtenido

    private GameObject PlayerNearby(GameObject[] _playerList, float _inRange, out bool _playerFound)
    {

        GameObject _playerName = null;

        foreach (GameObject _player in _playerList) 
        {
            float _playerDistance = Vector3.Distance(transform.position, _player.transform.position);

            if (_playerDistance < _inRange)
            {
                _inRange = _playerDistance;
                _playerName = _player;
            }
        }
        _playerFound = _playerName != null;
        return _playerName;
    }

    //11° Crea un metodo que intente convertir un texto a entero, indicando si la conversión fue exitosa y devolviendo el valor obtenido

    private bool TextToInteger(string _originalText, out int _numberOut) 
    {
        return int.TryParse(_originalText, out _numberOut);
    }

    //12° Crea un metodo que reciba un ángulo en grados y devuelva la rotación correspondiente como cuaternion

    private Quaternion RotationInQuaternion(float _gradesInAngle)
    {
        return Quaternion.Euler(0, _gradesInAngle, 0);
    }

    //13° Crea un metodo que llene una lista con todos los enemigos que se encuentren en un area dada
    private void EnemyListInArea(GameObject[] _enemyList, int _inRange)
    {
        List<GameObject> _enemyInRange = new List<GameObject>();

        foreach (GameObject _enemy in _enemyList) 
        {
            float _enemyDistance = Vector3.Distance(transform.position, _enemy.transform.position);
            if (_enemyDistance < _inRange)
            {
                _enemyInRange.Add(_enemy);
            }
        }
    }
    //14° Crea un metodo que reinicie la posición del jugador a un punto de aparición.

    private void CheckPoint (GameObject _playerPosition, GameObject _checkPointPosition)
    {
        _playerPosition.transform.position = _checkPointPosition.transform.position;
    }
    //15° En una clase base, crear un metodo diseñado para ser redefinido por las clases hijas
    public class Character
    {
        public virtual void Attack()
        {
            int AttackValue = 10;
        }
    }
    //16° En una clase hija, redefine el método del ejercicio anterior para proporcionar un comportamiento en específico.
    public class Ninja : Character
    {
        public override void Attack()
        {
            int AttackValue = 5;
        }

        //17° En la clase hija llama al comportamiento original en el método definido en la clase base
    }
    public class Mage : Character
    {
        public override void Attack()
        {
            base.Attack();
        }
    }
    //18° Crea un metodo que devuelva un porcentaje de  vida actual del
    private int PlayerHealthPercentaje (int _actualHealth, int _maxHealth)
    {
        int _playerPercentaje;
        return _playerPercentaje = _actualHealth / _maxHealth * 100;
    }
    //19° Crea un método que determine si un enemigo puede esquivar un ataque con una probabilidad dada
    private void CanAvoid(int _enemyAvoid, int _hitPercentaje)
    {
        bool _canAvoid;

        if (_enemyAvoid > _hitPercentaje)
        {
            _canAvoid = true;
        }
        else
        {
            _canAvoid = false;
        }
    }
    //20° Crea un método que aplique una fuerza en una dirección a un RigidBody
    private void ForceToDirection(Rigidbody _rigidBody, float _forceOfImpact, Vector3 _directionOfImpact)
    {
        _rigidBody.AddForce(_directionOfImpact * _forceOfImpact);
    }


}
