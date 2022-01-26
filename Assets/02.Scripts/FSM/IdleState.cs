using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : IState
{
    private StatePlayer player;
    public void OnEnter(StatePlayer player)
    {
        this.player = player;
    }

    public void OnExit()
    {

    }

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            player.SetState(player.moveState);
        }
    }
}
