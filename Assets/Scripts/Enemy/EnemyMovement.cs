using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    EnemyStats enemyStats;
    Transform player;

    private void Start()
    {
        enemyStats = GetComponent<EnemyStats>();
        player = FindObjectOfType<PlayerMovement>().transform;
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, enemyStats.currentMoveSpeed * Time.deltaTime);
    }
}
