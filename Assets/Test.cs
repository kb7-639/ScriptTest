using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100; //�̗�
    private int power = 25; //�U����
    private int mp = 53; //MP

    public void Attack()
    {
        Debug.Log( this.power + "�̃_���[�W��^����");
    }

    public void Defence(int damage)
    {
        Debug.Log(damage + "�̃_���[�W���󂯂�");
        //�c��hp�����炷
        this.hp -= damage;
    }

    public void Magic()
    {
        for (int i = 0; i <= 10; i++)
        {
            if (mp >= 5)
            {
                this.mp -= 5;
                Debug.Log("���@�U���������B�c��MP��" + mp + "�B");
            }
            else
            {
                Debug.Log("MP������Ȃ����߁A���@���g���Ȃ��B");
            }
        }
    }
}


public class Test : MonoBehaviour
{

// Start is called before the first frame update
void Start()
    {
        /*�@�z��̉ۑ�@*/
        Debug.Log("�z��ۑ�");

        //�z��̏�����
        int[] numbers = { 8, 120, 200, 30, 70 };

        //�z��̒l�����Ԃɕ\������
        Debug.Log("�z��̒l�����Ԃɕ\������");
        for (int i = 0; i < numbers.Length; i++)
        {
            Debug.Log(numbers[i]);
        }

        //�z��̒l���t���ɕ\������
        Debug.Log("�z��̒l���t���ɕ\������");
        for (int i = numbers.Length - 1; i > -1; i--)
        {
            Debug.Log(numbers[i]);
        }


        /*�@���W�ۑ�@*/
        Debug.Log("���W�ۑ�");

        //Boss�N���X�̕ϐ���錾���ăC���X�^���X����
        Boss lastboss = new Boss();

        //���@�p�̊֐����Ăяo��
        lastboss.Magic();
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
