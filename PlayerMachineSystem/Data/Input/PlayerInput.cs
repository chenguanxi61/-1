using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerInput : MonoBehaviour
{
    PlayerInputActions playerInputActions;
    private Vector2 axes => playerInputActions.GamePlay.Axes.ReadValue<Vector2>();
    public bool Jump => playerInputActions.GamePlay.Jump.WasPerformedThisFrame();//判断按下空格
    public bool StopJump => playerInputActions.GamePlay.Jump.WasReleasedThisFrame();//判断按下空格


    public bool Move=>AxisX!=0F;
    //判断是否移动
    public float AxisX => axes.x;
  
     void Awake()
    {
        playerInputActions = new PlayerInputActions();
    }

  public  void EnableGamePalyInputs()
    {
        playerInputActions.GamePlay.Enable();
    }
}
