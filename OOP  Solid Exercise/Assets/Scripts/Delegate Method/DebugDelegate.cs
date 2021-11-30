using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugDelegate : MonoBehaviour
{
    public delegate void DelegateDebug(); // tanımlama
    public DelegateDebug delegateDebug; // objeyi oluşturma
    private void Start()
    {
        delegateDebug += Debug1; //fonk. ekleme 

        AddMethod(Debug2);

        RemoveMethod(Debug1); // fonk. silme



        if (delegateDebug != null)
            delegateDebug();
    }

    private void Debug1()
    {
        Debug.Log("Debug 1");
    }
    private void Debug2()
    {
        Debug.Log("Debug 2");
    }
    public void AddMethod(DelegateDebug method)
    {
        delegateDebug += method;
    }
    public void RemoveMethod(DelegateDebug method)
    {
        delegateDebug -= method;
    }
}
