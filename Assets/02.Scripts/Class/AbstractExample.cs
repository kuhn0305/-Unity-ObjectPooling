using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractExample : MonoBehaviour
{
    public abstract void Speak();
}

public class Dog : AbstractExample
{
    public override void Speak()
    {
        Debug.Log("¾ß¿Ë");
    }
}
