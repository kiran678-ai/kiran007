using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playermovement : MonoBehaviour
{
    Vector2 movementInput;
    public float movementspeed = 0.1f;


    public void IAMovement (InputAction.CallbackContext context)
    {
        movementInput = context.ReadValue<Vector2>();
    }


   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(movementInput.x * movementspeed * Time.deltaTime, 0, movementInput.y * movementspeed * Time.deltaTime);

    }
}
