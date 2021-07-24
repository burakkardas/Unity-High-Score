using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject _prefab;
    public float _duration;
    private float _time;
    public float _minX;
    public float _maxX;
    void Update()
    {
        if(_time <= 0 ) {
            _time = _duration;
            Spawn();
        }
        else {
            _time -= Time.deltaTime;
        }
    }

    public void Spawn() {
        GameObject instance = Instantiate(_prefab);
        instance.transform.position = new Vector2(
            Random.Range(_minX, _maxX),
            transform.position.y
        );

        instance.transform.SetParent(transform);
    }
}
