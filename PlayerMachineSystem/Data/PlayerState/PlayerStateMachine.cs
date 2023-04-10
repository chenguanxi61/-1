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
        //�õ�������
        animator = GetComponent<Animator>();
        //�ƶ����
        input = GetComponent<PlayerInput>();
        Player = GetComponent<PlayerController>();
        //��ʼ�����״̬
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
