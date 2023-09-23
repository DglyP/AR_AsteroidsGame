// Moves a GameObject forwards
using UnityEngine;

public class MoveForward : MonoBehaviour
    {
    [SerializeField] private float _moveSpeed = 5;
    private Transform _myTransform;

    void Start()
        {
        // store the reference of the GameObjectÅfs transform
        _myTransform = transform;
        }

    void Update()
        {
        // increment the _myTransform position vector by _moveSpeed and Time.deltaTime
        _myTransform.position += _myTransform.forward * (Time.deltaTime * _moveSpeed);
        }
    }