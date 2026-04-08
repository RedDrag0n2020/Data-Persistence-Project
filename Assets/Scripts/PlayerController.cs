using UnityEngine;
using UnityEngine.InputSystem;
//using UnityEngine.SceneManagement; //new

public class PlayerMovement : MonoBehaviour
{
    private PlayerInput input; // new
    private InputSystem_Actions controls;
    private Vector2 moveInput;
    private Vector2 lookInput;

    public float moveSpeed = 5f;
    public float turnSpeed = 180f;

    public Transform cameraTransform;

    private void Awake()
    {
        controls = new InputSystem_Actions();

        //input = GetComponent<PlayerInput>(); //new
        //SceneManager.sceneLoaded += OnSceneLoaded; //new

    }

    private void OnEnable()
    {
        controls.Player.Enable();

        controls.Player.Move.performed += ctx => moveInput = ctx.ReadValue<Vector2>();
        controls.Player.Move.canceled += ctx => moveInput = Vector2.zero;

        controls.Player.Look.performed += ctx => lookInput = ctx.ReadValue<Vector2>();
        controls.Player.Look.canceled += ctx => lookInput = Vector2.zero;
    }

    private void OnDisable()
    {
        controls.Player.Disable();
    }

    private void Update()
    {
        // Rotate player horizontally
        float turnAmount = lookInput.x * turnSpeed * Time.deltaTime;
        transform.Rotate(0, turnAmount, 0);

        // Camera-relative movement
        Vector3 forward = cameraTransform.forward;
        Vector3 right = cameraTransform.right;

        forward.y = 0;
        right.y = 0;

        forward.Normalize();
        right.Normalize();

        Vector3 moveDir = forward * moveInput.y + right * moveInput.x;

        transform.Translate(moveDir * moveSpeed * Time.deltaTime, Space.World);
    }

    //private void OnSceneLoaded(Scene scene, LoadSceneMode mode) //new method
    //{
    //    if (input == null)
    //        input = GetComponent<PlayerInput>();

    //    if (input != null)
    //    {
    //        input.enabled = false;
    //        input.enabled = true;
    //    }
    //    else
    //    {
    //        Debug.LogError("PlayerInput component not found on Player!");
    //    }
    //}
}