using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IState
{
    void OnEnter(StatePlayer player);
    void Update();
    void OnCollisionEnter(Collision collision);
    void OnExit();
}
