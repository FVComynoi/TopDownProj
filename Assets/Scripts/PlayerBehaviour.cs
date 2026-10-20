using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBehaviour : MonoBehaviour
{
    private InputManager inputManager;
    private InputAction move;

    private Rigidbody2D rigidBody;
    [SerializeField] private float moveSpeed;

    private void Awake()
    {
        inputManager = new InputManager();
        rigidBody = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        rigidBody.linearVelocity = inputManager.GetInputDirection() * moveSpeed;
    }
}
