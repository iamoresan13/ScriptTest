using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{


void Start()
{
        //�v�f�̌���5�́Aint�^�̔z��array��錾���čD���Ȓl�ŏ��������Ă�������
        int[] array = new int[5];

        array[0] = 10;
        array[1] = 11;
        array[2] = 12;
        array[3] = 13;
        array[4] = 14;
        //for�����g���A�z��̊e�v�f�̒l�����Ԃɕ\�����Ă�������

        for (int i=0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }

        for (int i = array.Length - 1; 0  <= i; i--) 

        {
            Debug.Log(array[i]);
        }


            //for�����g���A�z��̊e�v�f�̒l���t���ɕ\�����Ă�������

    }



    void Update()
    {
        
    }
}
