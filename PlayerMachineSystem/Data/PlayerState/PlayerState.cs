using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState : ScriptableObject, Istate
{

    protected Animator animator;

    protected PlayerStateMachine stateMachine;//Ö´ÐÐ×´Ì¬µÄÇÐ»»

    protected PlayerInput input;
    protected PlayerController Player;

    public void Initialize(Animator animator, PlayerController Player, PlayerInput input, PlayerStateMachine stateMachine)
    {
        this.animator = animator;
        this.stateMachine = stateMachine;
        this.input = input;
        this.Player = Player;
    }
    public virtual void Enter()
    {
        
    }

    public virtual void Exit()
    {
        
    }

    public virtual void LogicUpdate()
    {
        
    }

    public virtual void PhysicalUpdate()
    {
        
    }
}
