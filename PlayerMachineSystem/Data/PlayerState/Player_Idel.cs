using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//��ΪPlayerState��ScriptableObject����Ŀ�д����ʲ��ļ�����ʹ��
[CreateAssetMenu(menuName ="Data/StateMachine/PlayerState/Idle",fileName= "Player_Idel")]
public class Player_Idel : PlayerState
{
    [SerializeField] float a = 5f;//���ٶ�
    public override void Enter()
    {
        base.Enter();
        currentSpeed = Player.moveSpeed;
        //Player.SetVelocityX(0f);
    }

    public override void LogicUpdate()
    {
        if (input.Move)
        {
            stateMachine.SwitchState(typeof(Player_Run));//�л��ܲ�״̬
        }

        currentSpeed = Mathf.MoveTowards(currentSpeed, 0f, a * Time.deltaTime);
        if (input.Jump)
        {
            stateMachine.SwitchState(typeof(Player_Jump));
        }
      /*  if(!Player.IsGorund)
        {
            stateMachine.SwitchState(typeof(Player_Fall));
        }*/
    }

    public override void PhysicalUpdate()
    {
        Player.SetVelocityX(currentSpeed * Player.transform.localScale.x);
    }
}
