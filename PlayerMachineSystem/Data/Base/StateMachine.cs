using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
    //持有所有的状态，并实现更新  管理  切换
{
    Istate currentState;//当前状态
   protected Dictionary<System.Type, Istate> stateTable;
     void Update()
    {
        currentState.LogicUpdate();
    }
     void FixedUpdate()
    {
        currentState.PhysicalUpdate();
    }
    protected void SwitchOn(Istate newState )//状态启动
    {
        currentState = newState;
        currentState.Enter();
    }

    public void SwitchState(Istate newState)//状态切换
    {
        //退出状态
        currentState.Exit();
        SwitchOn(newState);
    } public void SwitchState(System.Type newStateType)//状态切换
    {
        //退出状态
        currentState.Exit();
        SwitchState(stateTable[newStateType]);
    }
}
