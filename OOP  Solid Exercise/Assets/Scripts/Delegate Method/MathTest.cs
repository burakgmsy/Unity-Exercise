using System;
using UnityEngine;

public class MathTest : MonoBehaviour
{
    public delegate int CalculateDelegate(int x1, int x2);

    public CalculateDelegate calculateDelegate;
    private void Start()
    {

        calculateDelegate += Addition;
        calculateDelegate += Subtraction;
        calculateDelegate += Multiplication;
        calculateDelegate += (int a, int b) => // lambda Expression
        {
            Debug.Log("Bölündü");
            return a / b;
        };

        //calculateDelegate(13, 3);
        Delegate[] funcs = calculateDelegate.GetInvocationList();
        for (int i = 0; i < funcs.Length; i++)
        {
            int result = ((CalculateDelegate)funcs[i]).Invoke(13, 3);
            Debug.Log(result);
        }
    }

    private int Addition(int a, int b)
    {
        Debug.Log("Toplandi");
        return a + b;
    }
    private int Subtraction(int a, int b)
    {
        Debug.Log("Çıkarıldı");
        return a - b;
    }
    private int Multiplication(int a, int b)
    {
        Debug.Log("Çarpıldı");
        return a * b;
    }
}
