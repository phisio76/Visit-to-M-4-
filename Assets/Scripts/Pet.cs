using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; //подключить для меш-агента

public class Pet : MonoBehaviour
{
    [SerializeField] private NavMeshAgent _agent; // добавление меш -агента
    [SerializeField] private Transform _owner; // указание на персонажа, за которым бегать

    void Start()
    {
        // _agent.SetDestination(_owner.position); питомец подходит при старте. Пустой метод старт удалить
    }

    // Update is called once per frame
    void Update()
    {
        _agent.SetDestination(_owner.position);// питомец ходит за хозяином постоянно
    }
}
