using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerStateMachine : StateMachine
{
    Animator animator;
    
    PlayerInput input;
    PlayerController Player;
    [SerializeField]public PlayerState[] states;  
     void Awake()
    {
        //得到玩家组件
        animator = GetComponent<Animator>();
        //移动组件
        input = GetComponent<PlayerInput>();
        Player = GetComponent<PlayerController>();
        //初始化玩家状态
        stateTable = new Dictionary<System.Type, Istate>(states.Length);

        foreach(PlayerState state in states)
        {
            state.Initialize(animator,Player,input, this);
            stateTable.Add(state.GetType(),state);
        }
    }
     void Start()
    {
        SwitchOn(stateTable[typeof(Player_Idel)]);
    }
}
