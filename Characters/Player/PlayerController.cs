using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{

    PlayerInput input;
    Rigidbody rigidbody;
   void Awake()
    {
        input = GetComponent<PlayerInput>();
        rigidbody = GetComponent<Rigidbody>();
        
    }

     void Start()
    {
        input.EnableGamePalyInputs();
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
