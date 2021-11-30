using UnityEngine;

public class EventTest : MonoBehaviour
{
    public delegate void OnClicked();

    public static event OnClicked onLeftClicked;
    public static event OnClicked onRightClicked;

    private void Start()
    {
        onLeftClicked += PrintLeft;
        onRightClicked += PrintRight;
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (onLeftClicked != null)
                onLeftClicked();
        }
        else if (Input.GetMouseButtonDown(1))
        {
            if (onLeftClicked != null)
                onRightClicked();
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

}
