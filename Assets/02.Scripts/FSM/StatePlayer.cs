using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class StatePlayer : MonoBehaviour
{
    public IdleState idleState = new IdleState();
    public MoveState moveState = new MoveState();
    public RunState runState = new RunState();

    IState currentState;

    protected virtual void Update()
    {
        currentState.Update();
    }

    private void OnCollisionEnter(Collision collision)
    {
        currentState.OnCollisionEnter(collision);
    }


    public virtual void SetState(IState nextState)
    {

        // 다음 state로 이동구현
        if (currentState != null)
        {
            // 기존의 상태가 존재했다면 OnExit()호출
            currentState.OnExit();
        }



        // 다음state 시작
        currentState = nextState;
        currentState.OnEnter(this);
    }
}
