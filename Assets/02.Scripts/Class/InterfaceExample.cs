using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public interface IAnimal
{
    void Shouting();
}

public interface IPerson
{
    void Speaking();
}

class Pig : IAnimal, IPerson
{
    public string name;

    public void Shouting()
    {
        Debug.Log("�߿�!");
    }

    public void Speaking()
    {
        Debug.Log("���!");
    }
}
