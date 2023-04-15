using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[CreateAssetMenu(menuName = "Data/StateMachine/PlayerState/Jump", fileName = "Player_Jump")]

public class Player_Jump : PlayerState
{
    [SerializeField] float jumpForce=7f;
    [SerializeField] float moveSpeed=5f;
    public override void Enter()
    {
        base.Enter();
        Player.SetVelocityY(jumpForce);
    }
    public override void LogicUpdate()
    {
        if(input.StopJump||Player.IsFalling)
        {
            stateMachine.SwitchState(typeof(Player_Fall));
        }
    }

    public override void PhysicalUpdate()
    {
        Player.Move(moveSpeed);
    }

}
