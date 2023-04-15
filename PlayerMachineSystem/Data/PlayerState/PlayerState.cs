using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState : ScriptableObject, Istate
{
    [SerializeField] string stateName;
    [SerializeField,Range(0,1)] float duringTime=0.1f;//range可以使变量成为一个可拖动的

    private float stateStartTime;
    protected Animator animator;

    protected PlayerStateMachine stateMachine;//执行状态的切换

    protected PlayerInput input;
    protected PlayerController Player;

    protected float currentSpeed;

    protected float stateDuringTime=>Time.time - stateStartTime;
    protected bool IsAnimationFinish => (duringTime >= animator.GetCurrentAnimatorStateInfo(0).length);//动画持续时间是否大于当前动画长度来判断是否完成当前动画

    int stateHash;


    public void Initialize(Animator animator, PlayerController Player, PlayerInput input, PlayerStateMachine stateMachine)
    {
        this.animator = animator;
        this.stateMachine = stateMachine;
        this.input = input;
        this.Player = Player;
    }
    public void OnEnable()
    {
        stateHash = Animator.StringToHash(stateName);//将动画名称转换成哈希值
    }

    
    public virtual void Enter()
    {
        stateStartTime = Time.time;
        animator.CrossFade(stateHash,duringTime,0);
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
