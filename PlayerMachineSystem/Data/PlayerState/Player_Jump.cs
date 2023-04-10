using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[CreateAssetMenu(menuName = "Data/StateMachine/PlayerState/Jump", fileName = "Player_Jump")]
public class Player_Jump : PlayerState
{
    public override void Enter()
    {
        animator.Play("Idel");
    }

    public override void LogicUpdate()
    {
        
    }
}
