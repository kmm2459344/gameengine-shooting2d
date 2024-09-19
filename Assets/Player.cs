using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField, Header("移動速度")]
    private float Speed;
    [SerializeField, Header("弾オブジェクト")]
    private GameObject Bullet;
    [SerializeField, Header("弾を発射する時間")]
    //ここをアイテムを拾って0にするようにすれば極太ビームができる
    private float ShootTime;
    //[SerializeField, Header("体力")]
    //private int HP = SceneDirector.Player_HP;
    //TODO　アニメーション
    //[SerializeField, Header("爆発アニメーション")]
    //public GameObject prefabMyDie;

    private Vector2 inputVelocity;
    private Vector2 PlayerPos;
    private Rigidbody2D rb;
    private float ShootCount;


    // Start is called before the first frame update
    void Start()
    {
        inputVelocity = Vector2.zero;
        rb = GetComponent<Rigidbody2D>();

        ShootCount = 0;
        PlayerPos = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 force = Vector2.zero;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            force = new Vector2(0, Speed); // 上方向に動く
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            force = new Vector2(0, -Speed); // 下方向に動く
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            force = new Vector2(-Speed, 0); // 左方向に動く
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            force = new Vector2(Speed, 0); // 右方向に動く
        }

        rb.MovePosition(rb.position + force * Time.fixedDeltaTime);

        if (Input.GetKey(KeyCode.Space))
        {
            Shoot();
            //Debug.Log("スペース入力");
        }

        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    Shoot();
        //    //Debug.Log("スペース入力");
        //}
    }

    //弾の発射
    private void Shoot()
    {

        ShootCount += Time.deltaTime;
        if (ShootCount < ShootTime) return;

        GameObject bulletObj = Instantiate(Bullet);
        bulletObj.transform.position = transform.position + new Vector3(0f, transform.lossyScale.y / 2.0f, 0f);
        ShootCount = 0.0f;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "BulletEnemy")
        {
            SceneDirector.Player_HP -= 10;
            SceneDirector.Player_Special += 0.5f;
            if (SceneDirector.Player_HP <= 0)
            {
                Destroy(gameObject);
                //アニメーション
                //GameObject obj = Instantiate(prefabMyDie,gameObject.transform.position, Quaternion.identity);
                //Destroy(obj, 1.95f);
            }
        }
    }
}
