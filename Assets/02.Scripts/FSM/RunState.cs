using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunState : IState
{
    private StatePlayer player;
    public void OnEnter(StatePlayer player)
    {
        this.player = player;

        this.player.transform.Translate(Vector3.forward * 50);

    }

    public void OnExit()
    {

    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            player.SetState(player.moveState);
        }
    }
}
