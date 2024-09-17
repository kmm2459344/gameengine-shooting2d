using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SceneDirector : MonoBehaviour
{
    public int Wave = 0;
    public int EnemyCount = 0;

    //プレイヤー
    public GameObject Player;
    public static int Player_HP = 100;
    public static int Player_Power = 10;

    //アイテム
    public GameObject Power;
    public static int PowerCount = 0;
    public GameObject Boom;
    public static int BoomCount = 0;
    public GameObject Coin;
    public static int CoinCount = 0;

    //Enemy_A
    [SerializeField, Header("Enemy_A")]
    public GameObject Enemy_A;
    public static int Enemy_A_HP = 100;
    public static int Enemy_A_Power = 10;

    //Enemy_B
    [SerializeField, Header("Enemy_B")]
    public GameObject Enemy_B;
    public static int Enemy_B_HP = 200;
    public static int Enemy_B_Power = 20;

    //Enemy_C
    [SerializeField, Header("Enemy_C")]
    public GameObject Enemy_C;
    public static int Enemy_C_HP = 300;
    public static int Enemy_C_Power = 30;

    //BOSS
    [SerializeField, Header("Boss")]
    public GameObject Boss;
    public static int Boss_HP = 100;
    public static int Boss_Power = 100;

    public Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        slider.value = 100;
        //プレイヤー初期位置
        Player.transform.position = new Vector2(0, -3.83f);

    }

    // Update is called once per frame
    void Update()
    {
        slider.value = (float)Player_HP;

        //switch (Wave)
        //{
        //    case　1:

        //        break;
        //    case 2:

        //        break;
        //    case 3:

        //        break;
        //    case 4:
        //        BOSS();
        //        break;

        //}

    }

    //Enemy_Aを三体表示1体真ん中表示
    //private void ENEMY_A_3()
    //{
    //    GameObject L1 = Instantiate(Enemy_A, new Vector3(-2, 9.5f, 0), Quaternion.identity);
    //    GameObject C1 = Instantiate(Enemy_A, new Vector3(0, 9.5f, 0), Quaternion.identity);
    //    GameObject R1 = Instantiate(Enemy_A, new Vector3(2, 9.5f, 0), Quaternion.identity);

    //    StartCoroutine(MoveEnemy(L1, 3.5f));
    //    StartCoroutine(MoveEnemy(C1, 2.0f));
    //    StartCoroutine(MoveEnemy(R1, 3.5f));
    //}

    //BOSS表示
    private void BOSS()
    {

    }



    //private IEnumerator MoveEnemy(GameObject enemy, float targetY)
    //{
    //    while (enemy.transform.position.y > targetY)
    //    {
    //        enemy.transform.position += new Vector3(0, -Time.deltaTime, 0);
    //        yield return null;
    //    }
    //}
}
