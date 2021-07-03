using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turrel : MonoBehaviour
{
    [SerializeField] private Transform _rotatePoint;
    [SerializeField] private SphereCollider _visionCollider;
    [SerializeField] private float _speedRotate;
    [SerializeField] private float _distance;
    [SerializeField] private float _angle;

    [SerializeField] private Transform _player;

    [SerializeField] private GameObject _prefabBullet;
    [SerializeField] private Transform _shootPoint;

    // Start is called before the first frame update
    void Start()
    {
        _visionCollider.radius = _distance;
    }

    // Update is called once per frame
    void Update()
    {
        if (_player != null)
        {
            _rotatePoint.LookAt(_player);


        }
        else
            _rotatePoint.Rotate(Vector3.up * Time.deltaTime * 50f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            _player = other.transform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            _player = null;
        }
    }



}
