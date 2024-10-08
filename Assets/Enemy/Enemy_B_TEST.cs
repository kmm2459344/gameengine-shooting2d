using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy_B : MonoBehaviour
{
    [SerializeField, Header("弾オブジェクト")]
    private GameObject[] _bullet;
    [SerializeField, Header("弾を発射する時間")]
    private float _shootTime;
    //[SerializeField, Header("体力")]
    //private int HP;

    private GameObject _player;
    private Rigidbody2D rb;
    private float _shootCount;


    // Start is called before the first frame update
    //[System.Obsolete]
    void Start()
    {
        _player = FindObjectOfType<Player>().gameObject;
        _shootCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //_shooting();
    }

    private void _shooting()
    {
        if (_player == null) return;

        _shootCount += Time.deltaTime;
        if (_shootCount < _shootTime) return;

        //GameObject bulletObj = Instantiate(_bullet);
        //bulletObj.transform.position = transform.position;
        //Vector3 dir = _player.transform.position - transform.position;
        //bulletObj.transform.rotation = Quaternion.FromToRotation(transform.up, dir);
        //_shootCount = 0.0f;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "BulletPlayer")
        {
            SceneDirector.Enemy_B_HP -= SceneDirector.Player_Power;
            //Debug.Log("敵:" + SceneDirector.Enemy_B_HP);
            if (SceneDirector.Enemy_B_HP <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
