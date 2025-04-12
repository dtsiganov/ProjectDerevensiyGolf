using System.Collections.Generic;
using System;
using UnityEngine;
using System.Diagnostics;

public class 2_3 : MonoBehaviour
{
    void Start()
    {
        short s = 0;
        int i = 0;
        long l = 0;
        float f = 0;
        double d = 0;
        object o = d;
        double d2 = (double)o;

        i = (int)l;
        l = i;
        ushort a = 100500;
        byte b = (byte)a;

        TestFunc(ref i);

        var c = 0f;

        if (o!= null)
        {
            int i2 = (int)o;
        }
        int[] array = new int[10000];

        List <int> ints = new List <int>(); 
    }
    /*
    public void Exp()
    {
        int i = 1;
        object o = i;
        int j = (int)o;
    }
    */

    public void TestFunc(ref int i)
    {
        i = 10;
        Debug.Log(i);

    }

 
}
