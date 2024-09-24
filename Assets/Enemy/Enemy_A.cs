using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Splines;

public class Enemy_A : MonoBehaviour
{
    [SerializeField, Header("弾オブジェクト")]
    private GameObject _bullet;
    [SerializeField, Header("弾を発射する時間")]
    private float _shootTime;
    [SerializeField, Header("移動速度")]
    private float Speed = 5f;
    //[SerializeField, Header("体力")]
    //private int HP;

    private Rigidbody rb;
    public float LimtX = 2.3f; // 画面の端の位置
    private int direction = 1;
    //public Vector2 Pos = Vector2.zero;

    private GameObject _player;
    private float _shootCount;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //Pos = transform.position;
        _player = FindObjectOfType<Player>().gameObject;
        _shootCount = 0;
    }

    // Update is called once per frame
    void Update()
    { 
        _shooting();
        if(transform.position.y < 3.7f)
        {
            //Pos.x += 1;
            rb.linearVelocity = new Vector2(Speed * direction, rb.linearVelocity.y);

            if(transform.position.x > LimtX || transform.position.x < -LimtX)
            {
                //Pos.x *= -1;
                direction *= -1;
            }
            else
            {
                rb.linearVelocity = new Vector2(0, rb.linearVelocity.y);
            }
        }
    }

    private void _shooting()
    {
        if (transform.position.y < 3.7f) {

            if (_player == null) return;

            _shootCount += Time.deltaTime;
            if (_shootCount < _shootTime) return;

            GameObject bulletObj = Instantiate(_bullet);
            bulletObj.transform.position = transform.position;
            Vector3 dir = _player.transform.position - transform.position;
            bulletObj.transform.rotation = Quaternion.FromToRotation(transform.up, dir);
            _shootCount = 0.0f;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "BulletPlayer")
        {
            SceneDirector.Enemy_A_HP -= SceneDirector.Player_Power;
            //Debug.Log("敵:" + SceneDirector.Enemy_A_HP);
            SceneDirector.Player_Special += 2.0f;
            if (SceneDirector.Enemy_A_HP <= 0)
            { 
                Destroy(gameObject);

                int lottery = Random.Range(1, 10);
                Debug.Log("Enemy_A:" + lottery);
                //SceneDirector.ItemNo = lottery;

                switch (lottery)
                {
                    case 0:
                        Instantiate(SceneDirector.Power, new Vector2(0, 0), Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(SceneDirector.Boom, new Vector2(0, 0), Quaternion.identity);
                        break;
                    //case 6:
                    //    Instantiate(SceneDirector.Power, new Vector2(0, 0), Quaternion.identity);
                    //    break;
                }


            }
        }
    }
}
