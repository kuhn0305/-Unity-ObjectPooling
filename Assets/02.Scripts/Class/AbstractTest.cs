using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbstractTest : MonoBehaviour
{
    List<Animal> animals = new List<Animal>();

    private Dog dog = new Dog();
    private Cat cat = new Cat();


    private void Start()
    {
        animals.Add(dog);
        animals.Add(cat);

        animals[0].Shouting();
        animals[1].Shouting();
    }
}
