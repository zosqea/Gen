using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float speedF = 5f;
    public float speed = 5f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;
    public GameObject menu;
    public GameObject plC;

    public Transform groundCheck;
    public float groundDistance = 0.4F;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;

    // Start is called before the first frame update
    public void SpeedU(int mN)
    {
        speedF = speed * mN;
    }
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (menu.activeSelf == false)
            {
                Time.timeScale = 0;
                Cursor.lockState = CursorLockMode.Confined;
                menu.SetActive(true);
                plC.SetActive(false);
            }
            else
            {
                Cursor.lockState = CursorLockMode.Locked;
                Time.timeScale = 1;
                menu.SetActive(false);
                plC.SetActive(true);
            }
        }

        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x= Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speedF * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }
}
