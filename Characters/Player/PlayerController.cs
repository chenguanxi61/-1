using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{

    PlayerInput input;
    Rigidbody rigidbody;
    PlayerGroundDetector groundDetector;

    public float moveSpeed=>Mathf.Abs(rigidbody.velocity.x);//取绝对值
    public bool IsGorund => groundDetector.IsGround;//判断是否在地面
    public bool IsFalling => rigidbody.velocity.y < 0 && !IsGorund;//是否下落
    void Awake()
    {
        groundDetector = GetComponentInChildren<PlayerGroundDetector>();
        input = GetComponent<PlayerInput>();
        rigidbody = GetComponent<Rigidbody>();
        
    }

     void Start()
    {

        input.EnableGamePalyInputs();
    }


    public void Move(float speed)
    {
        if (input.Move )
        {
            transform.localScale = new Vector3(input.AxisX, 1, 1);
           
        }
        SetVelocityX(speed * input.AxisX);

    }

   //改变速度
    public void SetVelocity(Vector3 velocity)
    {
        rigidbody.velocity = velocity;
    }

    public void SetVelocityX(float velocityX)
    {
        rigidbody.velocity = new Vector3(velocityX, rigidbody.velocity.y);
    }public void SetVelocityY(float velocityY)
    {
        rigidbody.velocity = new Vector3(rigidbody.velocity.x, velocityY);
    }
}
