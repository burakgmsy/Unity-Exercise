using System;
using UnityEngine;

public class NewMovementPanel : MonoBehaviour
{
    //subject
    public static event Action OnForwardButtonClicked;
    public static event Action OnBackButtonClicked;
    public static event Action OnLeftButtonClicked;
    public static event Action OnRightButtonClicked;


    public static event Action<Vector3> OnButtonClick;

    public void ForwardOnClick()
    {
        //OnForwardButtonClicked?.Invoke();
        OnButtonClick?.Invoke(Vector3.forward);
    }
    public void BackOnClick()
    {
        //OnBackButtonClicked?.Invoke();
        OnButtonClick?.Invoke(Vector3.back);
    }
    public void RightOnClick()
    {
        //OnRightButtonClicked?.Invoke();
        OnButtonClick?.Invoke(Vector3.right);
    }
    public void LeftOnClick()
    {
        //OnLeftButtonClicked?.Invoke();
        OnButtonClick?.Invoke(Vector3.left);
    }
}
