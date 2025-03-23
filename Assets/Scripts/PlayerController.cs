using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour, PlayerActions.IMovementActions, PlayerActions.ICameraControlActions
{
    [Header("Movement Settings")]
    public float speed = 3f;
    public float sensitivity = 0.3f;

    private PlayerActions playerActions;
    private CharacterController characterController;
    private Vector2 moveInput;
    private Vector2 lookInput;
    private float rotationX = 0f;

    [Header("Camera Settings")]
    public Transform cameraTransform;

    private void Awake()
    {
        playerActions = new PlayerActions();
        characterController = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void OnEnable()
    {
        playerActions.Movement.SetCallbacks(this);
        playerActions.CameraControl.SetCallbacks(this);
        playerActions.Enable();
    }

    private void OnDisable()
    {
        playerActions.Disable();
    }

    private void Update()
    {
        Move();
        LookAround();
    }

    public void OnWalk(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }

    public void OnLook(InputAction.CallbackContext context)
    {
        lookInput = context.ReadValue<Vector2>();
    }

    private void Move()
    {
        Vector3 moveDirection = transform.right * moveInput.x + transform.forward * moveInput.y;
        characterController.Move(moveDirection * speed * Time.deltaTime);
    }

    private void LookAround()
    {
        rotationX -= lookInput.y * sensitivity;
        rotationX = Mathf.Clamp(rotationX, -90f, 90f); // Evita girar más de 90° arriba/abajo
        cameraTransform.localRotation = Quaternion.Euler(rotationX, 0f, 0f);
        transform.Rotate(Vector3.up * lookInput.x * sensitivity);
    }
}
