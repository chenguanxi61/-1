using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Data/StateMachine/PlayerState/Land", fileName = "Player_Land")]

public class Player_Land : PlayerState
{
    [SerializeField] float sTime = 0.2f;//Ó²Ö±Ê±¼ä
    public override void Enter()
    {
        base.Enter();
        Player.SetVelocity(Vector3.zero);
    }
    public override void LogicUpdate()
    {
        if(input.Jump)
        {
            stateMachine.SwitchState(typeof(Player_Jump));
        }
        if(stateDuringTime<sTime)
        {
            return;
        }
        if(input.Move)
        {
            stateMachine.SwitchState(typeof(Player_Run));
        }
        if(IsAnimationFinish)

        {
            stateMachine.SwitchState(typeof(Player_Idel));
        }
    }

    public override void PhysicalUpdate()
    {
        
    }
}
