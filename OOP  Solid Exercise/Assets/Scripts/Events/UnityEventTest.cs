using System;
using UnityEngine;
using UnityEngine.Events;

public class UnityEventTest : MonoBehaviour
{

    [Serializable] public class OnClicked : UnityEvent { }
    [Serializable] public class OnPrint : UnityEvent<int> { }

    public OnClicked onLeftClicked;
    public OnClicked onRightClicked;
    public OnPrint onPrint;


    private void Start()
    {
        onRightClicked.AddListener(PrintRight);
        onPrint.AddListener(PrintValue);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) // left click
        {
            onLeftClicked.Invoke();
        }
        else if (Input.GetMouseButtonDown(1)) // right click
        {
            onRightClicked.Invoke();
            onPrint.Invoke(11);
        }
    }
    public void PrintRight()
    {
        Debug.Log("RIGHT");
    }

    public void PrintLeft()
    {
        Debug.Log("LEFT");
    }
    public void PrintValue(int value)
    {
        Debug.Log(value);
    }
}
