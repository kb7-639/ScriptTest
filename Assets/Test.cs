using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100; //体力
    private int power = 25; //攻撃力
    private int mp = 53; //MP

    public void Attack()
    {
        Debug.Log( this.power + "のダメージを与えた");
    }

    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        //残りhpを減らす
        this.hp -= damage;
    }

    public void Magic()
    {
            if (mp >= 5)
            {
                this.mp -= 5;
                Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");
            }
            else
            {
                Debug.Log("MPが足りないため、魔法が使えない。");
            }
    }
}


public class Test : MonoBehaviour
{

// Start is called before the first frame update
void Start()
    {
        /*　配列の課題　*/
        Debug.Log("配列課題");

        //配列の初期化
        int[] array = { 8, 120, 200, 30, 70 };

        //配列の値を順番に表示する
        Debug.Log("配列の値を順番に表示する");
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        //配列の値を逆順に表示する
        Debug.Log("配列の値を逆順に表示する");
        for (int i = array.Length - 1; i > -1; i--)
        {
            Debug.Log(array[i]);
        }


        /*　発展課題　*/
        Debug.Log("発展課題");

        //Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        //魔法用の関数を呼び出す
        for (int i = 0; i <= 10; i++)
        {
            lastboss.Magic();
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
