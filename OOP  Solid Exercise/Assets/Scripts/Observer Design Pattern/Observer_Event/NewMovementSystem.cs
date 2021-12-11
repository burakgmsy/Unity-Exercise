using UnityEngine;

public class NewMovementSystem : MonoBehaviour
{
    //Observer
    private void Start()
    {
        /*NewMovementPanel.OnForwardButtonClicked += MoveForward;
        NewMovementPanel.OnLeftButtonClicked += MoveLeft;
        NewMovementPanel.OnRightButtonClicked += MoveRight;
        NewMovementPanel.OnBackButtonClicked += MoveBack;*/

        NewMovementPanel.OnButtonClick += Move;
    }

    private void OnDestroy()
    {
        NewMovementPanel.OnButtonClick -= Move;
    }
    public void MoveForward() => transform.Translate(Vector3.forward);
    public void MoveBack() => transform.Translate(Vector3.back);
    public void MoveLeft() => transform.Translate(Vector3.left);
    public void MoveRight() => transform.Translate(Vector3.right);
    public void Move(Vector3 vector) => transform.Translate(vector);
}
