using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    [SerializeField] Transform player;
    Vector3 playerPosition;
    void Start()
    {
        playerPosition = player.position;
    }

    void Update()
    {
        transform.position = 
        Vector3.MoveTowards(
            transform.position, 
            playerPosition, 
            speed * Time.deltaTime);    
    }
}
