using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Subject : MonoBehaviour
{

    private List<Observer> _observes = null;
    [SerializeField] private SubjectType _subjectType;

    public SubjectType SubjectType => _subjectType;

    public void RegisterObserver(Observer observer)
    {
        if (_observes == null)
            _observes = new List<Observer>();

        _observes.Add(observer);
    }

    private void Start()
    {
        ObserverManager.Instance.RegisterSubjects(this);
    }

    public void Notify(NotificationType notificationType)
    {
        foreach (var observer in _observes)
        {
            observer.OnNotify(notificationType);
        }
    }
}
