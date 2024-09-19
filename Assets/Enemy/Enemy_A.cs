using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy_A : MonoBehaviour
{
    [SerializeField, Header("�e�I�u�W�F�N�g")]
    private GameObject _bullet;
    [SerializeField, Header("�e�𔭎˂��鎞��")]
    private float _shootTime;
    //[SerializeField, Header("�̗�")]
    //private int HP;

    private GameObject _player;
    private float _shootCount;


    // Start is called before the first frame update
    void Start()
    {
        _player = FindObjectOfType<Player>().gameObject;
        _shootCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        _shooting();
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
            //Debug.Log("�G:" + SceneDirector.Enemy_A_HP);
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
