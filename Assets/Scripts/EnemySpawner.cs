using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject _prefabBonus;
    [SerializeField] private GameObject _prefabEnemy;
    [SerializeField] private Transform[] _spawnPoint;

    private GameObject _enemy;


    void Start()
    {
        int index = Random.Range(0, _spawnPoint.Length);
        _enemy = Instantiate(_prefabEnemy, _spawnPoint[index].position, _spawnPoint[index].rotation);

        //enabled = false;

        index = Random.Range(0, _spawnPoint.Length);
        Instantiate(_prefabBonus, _spawnPoint[index].position, _spawnPoint[index].rotation);
    }

    // Update is called once per frame
    void Update()
    {
        _enemy.transform.Translate(transform.forward * Time.deltaTime);
    }
}
