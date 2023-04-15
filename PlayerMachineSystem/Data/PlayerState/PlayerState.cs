using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState : ScriptableObject, Istate
{
    [SerializeField] string stateName;
    [SerializeField,Range(0,1)] float duringTime=0.1f;//range����ʹ������Ϊһ�����϶���

    private float stateStartTime;
    protected Animator animator;

    protected PlayerStateMachine stateMachine;//ִ��״̬���л�

    protected PlayerInput input;
    protected PlayerController Player;

    protected float currentSpeed;

    protected float stateDuringTime=>Time.time - stateStartTime;
    protected bool IsAnimationFinish => (duringTime >= animator.GetCurrentAnimatorStateInfo(0).length);//��������ʱ���Ƿ���ڵ�ǰ�����������ж��Ƿ���ɵ�ǰ����

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
        stateHash = Animator.StringToHash(stateName);//����������ת���ɹ�ϣֵ
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
