using UnityEngine;

class DelegateEventClass
{
    public delegate void DelegateMethod(string message);
    public event DelegateMethod EventMethod;
    public event DelegateMethod nonEventMethod;

    public void MultipleOf5(int number)
    {
        if (number % 5 == 0 && number != 0)
        {
            EventMethod(string.Format($"{number}�� 5�� ���"));
        }
    }
}

public class DelegateEventExample : MonoBehaviour
{
    void Start()
    {
        DelegateEventClass delegateEventClass = new DelegateEventClass();
        delegateEventClass.EventMethod += DebugLog;

        for (int i = 0; i < 30; i++)
            delegateEventClass.MultipleOf5(i);
    }

    void DebugLog(string message)
    {
        Debug.Log(message);
    }
}