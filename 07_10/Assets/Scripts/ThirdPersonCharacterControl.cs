using UnityEngine;

public class ThirdPersonCharacterControl : MonoBehaviour
{
    public float speed = 6.0F;
    

    private Vector3 moveDirection = Vector3.zero;
    public CharacterController controller;

    private void Start()
    {
        // Store reference to attached component
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        Movimento();
    }

    private void Movimento()
    {
        // Character is on ground (built-in functionality of Character Controller)

        // Use input up and down for direction, multiplied by speed
        moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        moveDirection = transform.TransformDirection(moveDirection);
        if (Input.GetKey(KeyCode.LeftShift))
        {
            moveDirection *= speed * 2;
        }
        else
        {
            moveDirection *= speed;

        }


        // Move Character Controller
        controller.Move(moveDirection * Time.deltaTime);

    }
}