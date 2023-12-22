using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _bossThrownRock : MonoBehaviour
{
    Transform _tfRock;
    Vector3 _direction;
    float _speed = 0.75f;
    float _lifeSpan = 10f;
    float _age = 0;
    Vector3 _shipPosition;
    
    // Start is called before the first frame update
    void Start()
    {
        _tfRock = GetComponent<Transform>();
        _direction = new Vector3(0, 0, -1);
        _shipPosition = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        _age += Time.deltaTime;
        _tfRock.Translate(_direction * _speed * Time.deltaTime);
        
        if(_age>_lifeSpan)
        {
            Destroy(_tfRock.gameObject);
        }
        if(_tfRock.position.z< _shipPosition.y)
        {
            Destroy(_tfRock.gameObject);
            Destroy(this);
        }
    }
}
