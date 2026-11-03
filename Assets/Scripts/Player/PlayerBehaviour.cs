using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBehaviour : MonoBehaviour
{
    private InputManager inputManager;

    private Rigidbody2D rigidBody;

    [Header("attack Params")]
    [SerializeField] private Transform attackPosition;
    [SerializeField] private Vector2 attackArea;
    [SerializeField] private float moveSpeed;
    [SerializeField] private LayerMask enemyLayer;
    private Collider2D enemyRef;

    private void Awake()
    {
        inputManager = new InputManager();
        rigidBody = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (inputManager.isAttackPressed)
        {
            enemyRef = Physics2D.OverlapBox(attackPosition.position, attackArea, 0 ,enemyLayer);
            Destroy(enemyRef.gameObject);
            print("Enemy name:" + enemyRef.gameObject.name);
        }
    }
    private void FixedUpdate()
    {
        rigidBody.linearVelocity = inputManager.GetInputDirection() * moveSpeed;
    }
    private void OnDisable()
    {
        
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(attackPosition.position, attackArea);
    }
}
