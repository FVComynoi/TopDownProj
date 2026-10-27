using UnityEngine;
using UnityEngine.UIElements;

public class EnemyBase : MonoBehaviour
{
    [SerializeField] private int Lives;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float range;
    private Vector3 playerPos;
    private PlayerBehaviour playerRef;


    private void Start()
    {
        playerRef = GameManager.Instance.GetPlayer();
        Vector3 direction = (playerRef.transform.position - transform.position).normalized;
    }
    private void Update()
    {
        playerPos = (playerRef.transform,position - transform.position)
        transform.position = Vector3.MoveTowards (transform.position, playerPos, moveSpeed * Time.deltaTime);
    }
}
