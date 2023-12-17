using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{


void Start()
{
        //要素の個数が5の、int型の配列arrayを宣言して好きな値で初期化してください
        int[] array = new int[5];

        array[0] = 10;
        array[1] = 11;
        array[2] = 12;
        array[3] = 13;
        array[4] = 14;
        //for文を使い、配列の各要素の値を順番に表示してください

        for (int i=0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }

        for (int i = array.Length - 1; 0  <= i; i--) 

        {
            Debug.Log(array[i]);
        }


            //for文を使い、配列の各要素の値を逆順に表示してください

    }



    void Update()
    {
        
    }
}
