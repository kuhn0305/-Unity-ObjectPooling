using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Animal
{
    void Speak();

    string Name
    {
        get;
        set;
    }
}

class Cat : Animal
{
    public string name;

    public void Speak()
    {
        Debug.Log("¾ß¿Ë!");
    }

    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }
}
