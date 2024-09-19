using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet1 : MonoBehaviour
{
    [SerializeField, Header("弾の速度")]
    private float _speed;
    //[SerializeField, Header("弾の威力")]
    //private float _power;

    private Rigidbody2D _rb;
    AudioSource audioSource;
    public AudioClip ShootSE;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        _Move();

        //if (transform.position.y > 5.4)
        //{
        //    Destroy(gameObject);
        //}
    }

    private void _Move()
    {
        //audioSource.PlayOneShot(ShootSE);
        _rb.linearVelocity = transform.up * _speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "BulletEnemy")
        {
            Destroy(gameObject);
        }
    }

    void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}
