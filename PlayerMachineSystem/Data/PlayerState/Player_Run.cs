using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(menuName = "Data/StateMachine/PlayerState/Run", fileName = "Player_Run")]
public class Player_Run : PlayerState
{

    float runSpeed = 5f;
    public override void Enter()
    {
        animator.Play("Run");
    }

    public override void LogicUpdate()
    {
        if (!input.Move)
        {
            stateMachine.SwitchState(typeof(Player_Idel));//ÇÐ»»¿ÕÏÐ×´Ì¬
        }
    }

    public override void PhysicalUpdate()
    {
        Player.SetVelocityX(runSpeed);
    }
}
