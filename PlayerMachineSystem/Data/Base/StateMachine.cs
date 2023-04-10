using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
    //�������е�״̬����ʵ�ָ���  ����  �л�
{
    Istate currentState;//��ǰ״̬
   protected Dictionary<System.Type, Istate> stateTable;
     void Update()
    {
        currentState.LogicUpdate();
    }
     void FixedUpdate()
    {
        currentState.PhysicalUpdate();
    }
    protected void SwitchOn(Istate newState )//״̬����
    {
        currentState = newState;
        currentState.Enter();
    }

    public void SwitchState(Istate newState)//״̬�л�
    {
        //�˳�״̬
        currentState.Exit();
        SwitchOn(newState);
    } public void SwitchState(System.Type newStateType)//״̬�л�
    {
        //�˳�״̬
        currentState.Exit();
        SwitchState(stateTable[newStateType]);
    }
}
