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
        Debug.Log("¾ß¿Ë!");
    }

    public void Speaking()
    {
        Debug.Log("Çï·Î!");
    }
}
