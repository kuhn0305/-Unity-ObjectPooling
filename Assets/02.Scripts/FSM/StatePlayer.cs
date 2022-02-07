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

        // ���� state�� �̵�����
        if (currentState != null)
        {
            // ������ ���°� �����ߴٸ� OnExit()ȣ��
            currentState.OnExit();
        }



        // ����state ����
        currentState = nextState;
        currentState.OnEnter(this);
    }
}
