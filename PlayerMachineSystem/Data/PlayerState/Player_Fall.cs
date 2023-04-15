using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Data/StateMachine/PlayerState/Fall", fileName = "Player_Fall")]
public class Player_Fall : PlayerState
{
    [SerializeField] AnimationCurve speedCurve;
    public override void LogicUpdate()
    {
        
        if(Player.IsGorund)
        {
            stateMachine.SwitchState(typeof(Player_Land));
        }
    }

    public override void PhysicalUpdate()
    {
        Player.SetVelocityY(speedCurve.Evaluate(stateDuringTime));
    }
}
