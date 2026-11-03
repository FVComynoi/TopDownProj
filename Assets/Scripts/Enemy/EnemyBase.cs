using UnityEngine;
using UnityEngine.UIElements;

public class EnemyBase : MonoBehaviour
{
    [SerializeField] private int Lives;
    [SerializeField] private float moveSpeed;
    private Vector3 playerPos;
    private PlayerBehaviour playerRef;


    private void Start()
    {
        playerRef = GameManager.Instance.GetPlayer();
        
    }
    private void Update()
    {
        playerPos = playerRef.transform.position;
        transform.position = Vector3.MoveTowards(transform.position, playerPos, moveSpeed * Time.deltaTime);
    }
}
