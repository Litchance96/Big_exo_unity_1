using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerControl : MonoBehaviour
{

    //public InputActions actions;

    public InputActionAsset actions;
    
    [SerializeField] int forceSaut = 1;
    [SerializeField] float speed =1f;
    private InputAction xAxis;
    private InputAction jump;

    void Awake()
    {
        xAxis = actions.FindActionMap("CubeActionsMap").FindAction("XAxis");
        jump = actions.FindActionMap("CubeActionsMap").FindAction("Jump");
        MoveZ();
    }

    void Start()
    {
   
    }
    void OnEnable()
    {
        actions.FindActionMap("CubeActionsMap").Enable();
    }

    void OnDisable()
    {
        actions.FindActionMap("CubeActionsMap").Disable();

 
        
    }

    void Update()
    {
        MoveX();
        MoveZ();
        Jump();


    }

    private void MoveX()
    {
        float xMove = xAxis.ReadValue<float>();
        transform.position += speed * Time.deltaTime * xMove * transform.right;

    }

    private void MoveZ()
    {
        
        transform.position += speed * Time.deltaTime * transform.forward;

    }
    private bool jumping = false;

    

 
    private void Jump()
    {
        float saut = jump.ReadValue<float>();

        transform.position += speed * Time.deltaTime * saut * Vector3.up *forceSaut;


     

    }





    // private void OnTheGround()
    // {
    //     transform.position = Position.y
    // }


}
