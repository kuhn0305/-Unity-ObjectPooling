using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractExample : MonoBehaviour
{
    protected abstract void Speak();
}


public class Dog : Animal
{
    public float size = 0.5f;

    public override void Shouting()
    {
        Debug.Log("�۸�!");
    }

    protected override void Move()
    {
        Debug.Log("�߿�");
    }

    protected override void Attack()
    {
        Debug.Log("�߿�");
    }

    public void Speak()
    {

    }
}

public class Cat : Animal
{
    float age = 0.5f;

    public override void Shouting()
    {
        Debug.Log("�߿�");
    }

    protected override void Move()
    {
        Debug.Log("�߿�");
    }

    protected override void Attack()
    {
        Debug.Log("�߿�");
    }
}



public abstract class Animal
{
    protected abstract void Move();
    public abstract void Shouting();
    protected abstract void Attack();

    protected virtual void aaa()
    {
        Debug.Log("1234");
    }
}

public abstract class Person
{
    protected abstract void Move();
    public abstract void Shouting();
    protected abstract void Attack();
}
