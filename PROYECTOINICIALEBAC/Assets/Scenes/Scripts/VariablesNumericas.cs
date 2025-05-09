using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesNumericas : MonoBehaviour
{
    //           128 64 32 16 8 4 2 1
    //Byte =>   [0 0 0 0 0 0 0 0]
    //Short =>  [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0]
    //Int =>    [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0]
    //Long =>   [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0]

    sbyte miByteConSigno = 0;
    byte miByte = 0;
    short miShort = 1;
    ushort miShortSinSigno = 0;
    int miInt = 0;
    uint miIntSinSigno = 0;
    long miLong = long.MaxValue;
    ulong miLongSinSigno = 0;

    // Start is called before the first frame update
    void Start()
    {
        miByteConSigno = -25;
        miInt = miByteConSigno;
        Debug.Log("el valor de miByteConSigno es: " + miByteConSigno);
        Debug.Log("el valor de miInt es: " + miInt);
        miByte = 200;
        miIntSinSigno = miByte;
        miIntSinSigno = (uint)miByteConSigno;
        Debug.Log("el valor de miIntAinSigno es: " + miIntSinSigno);

        miLong = long.MaxValue;
        miInt = (int)miLong;
        Debug.Log("el valor de miInt es: " + miInt);

        int a, b, c;
        float f;
        a = 5;
        b = 10;
        c = a + b;
        Debug.Log(c);
        c = a * b;
        Debug.Log(c);
        c = a - b;
        Debug.Log(c);
        f = a / b;
        Debug.Log(f);
        
        
        if (miInt % 2 == 0)
        {
            Debug.Log("el numero" + miInt + "es par");
        }
        else
        {
            Debug.Log("el numero" + miInt + "es non");
        }


    }

    // Update is called once per frame
    void Update()
    {

        
    }
}
