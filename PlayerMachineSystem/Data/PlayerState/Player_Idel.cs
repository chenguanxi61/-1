using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//��ΪPlayerState��ScriptableObject����Ŀ�д����ʲ��ļ�����ʹ��
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
            stateMachine.SwitchState(typeof(Player_Run));//�л��ܲ�״̬
        }
    }
}
