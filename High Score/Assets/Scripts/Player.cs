using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    private GameManager gm;
    public float _moveSpeed;
    private Vector2 _movement;
    private bool _isLookRight;

    void Start() {
        gm = GameManager.FindObjectOfType<GameManager>();
    }
    void FixedUpdate()
    {   
        _movement.x = Input.GetAxisRaw("Horizontal");
        _movement.y = Input.GetAxisRaw("Vertical"); 
    }

    void Update() {
        rb.velocity = new Vector2(
            _movement.x * _moveSpeed,
            _movement.y * _moveSpeed
        );

        rb.velocity.Normalize();

        if(_movement.x < 0 && _isLookRight == false) {
            Flip();
        }
        else if(_movement.x > 0 && _isLookRight == true) {
            Flip();
        }
    }

    private void Flip() {
        _isLookRight = !_isLookRight;

        transform.Rotate(0f, 180, 0f);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag != "Enemy") {
            gm._score++;
            Destroy(other.gameObject);
        }
        else if(other.gameObject.tag == "Enemy") {
            gm.GameOver();
        }
    }
}
