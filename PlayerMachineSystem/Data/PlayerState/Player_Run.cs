using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(menuName = "Data/StateMachine/PlayerState/Run", fileName = "Player_Run")]
public class Player_Run : PlayerState
{

    [SerializeField]float runSpeed = 5f;//最大速度
    [SerializeField]float a = 5f;//加速度
    public override void Enter()
    {
        base.Enter();
        currentSpeed = Player.moveSpeed;
    }

    public override void LogicUpdate()
    {
        if (!input.Move)
        {
            stateMachine.SwitchState(typeof(Player_Idel));//切换空闲状态
        }
        currentSpeed = Mathf.MoveTowards(currentSpeed, runSpeed, a * Time.deltaTime);

        if (input.Jump)
        {
            stateMachine.SwitchState(typeof(Player_Jump));
        }

        if(!Player.IsGorund)
        {
            stateMachine.SwitchState(typeof(Player_Fall));
        }
    }

    public override void PhysicalUpdate()
    {
        Player.Move(currentSpeed);
    }
}
