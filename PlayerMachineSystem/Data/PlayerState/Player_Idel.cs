using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//因为PlayerState是ScriptableObject在项目中创建资产文件才能使用
[CreateAssetMenu(menuName ="Data/StateMachine/PlayerState/Idle",fileName= "Player_Idel")]
public class Player_Idel : PlayerState
{
    public override void Enter()
    {
        animator.Play("Idle");
    }

    public override void LogicUpdate()
    {
        if (input.Move)
        {
            stateMachine.SwitchState(typeof(Player_Run));//切换跑步状态
        }
    }
}
