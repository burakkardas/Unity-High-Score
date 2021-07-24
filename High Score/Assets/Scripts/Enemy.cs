using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float _randomSpeed;
    public float _lifeTime;
    void Start() {
        _randomSpeed = Random.Range(2, 6);
    }
    void Update()
    {
        transform.Translate(0f, -1 * _randomSpeed * Time.deltaTime, 0f);
        Destroy(gameObject, _lifeTime);
    }
}
