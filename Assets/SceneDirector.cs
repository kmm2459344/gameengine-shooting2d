using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SceneDirector : MonoBehaviour
{
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
    public GameObject Enemy_A;
    public static int Enemy_A_HP = 100;
    public static int Enemy_A_Power = 10;

    //Enemy_B
    public GameObject Enemy_B;
    public static int Enemy_B_HP = 200;
    public static int Enemy_B_Power = 20;

    //Enemy_C
    public GameObject Enemy_C;
    public static int Enemy_C_HP = 300;
    public static int Enemy_C_Power = 30;

    //BOSS
    public GameObject BOSS;
    public static int BOSS_HP = 100;
    public static int BOSS_Power = 100;

    public Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        slider.value = 100;
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = (float)Player_HP;
    }
}
