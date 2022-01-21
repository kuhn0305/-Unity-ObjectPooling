using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassExample : MonoBehaviour
{
    public int value1;

    protected int value2;

    private int value3;

    public int Value3
    {
        get { return value3; }
    }

    private void Start()
    {
        SampleMethod();

        SingletonExample.Instance.Method1();
    }

    public int GetValue3()
    {
        return value3;
    }

    public virtual void SampleMethod()
    {
        Debug.Log("Parent Method!");
    }

    public void SampleMethod_2()
    {
        Debug.Log("Parent Method!");
    }
}
