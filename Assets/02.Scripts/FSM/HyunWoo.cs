using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HyunWoo : StatePlayer
{
    // Start is called before the first frame update
    void Start()
    {
        SetState(idleState);
    }

    protected override void Update()
    {
        base.Update();
    }

    public override void SetState(IState nextState)
    {
        base.SetState(nextState);
    }
}
