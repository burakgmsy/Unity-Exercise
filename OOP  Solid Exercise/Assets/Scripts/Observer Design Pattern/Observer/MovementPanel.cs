using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPanel : Subject
{
    public void ForwardClick()
    {
        Notify(NotificationType.ForwardButton);
    }
    public void BackClick()
    {
        Notify(NotificationType.BackButton);
    }
    public void RightClick()
    {
        Notify(NotificationType.RightButton);
    }
    public void LeftClick()
    {
        Notify(NotificationType.LeftButton);
    }
}
