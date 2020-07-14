using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private float _spawnFrequency;
    [SerializeField] private Transform _spawnPoints;

    private float _runningTime;


    private void Update()
    {
        _runningTime += Time.deltaTime;
        if (_runningTime >= _spawnFrequency)
        {
            Vector3 newPositon = _spawnPoints.GetChild(Random.Range(0, _spawnPoints.childCount)).position;
            Instantiate(_enemy, newPositon, Quaternion.identity);
            _runningTime = 0;
        }
    }
}
