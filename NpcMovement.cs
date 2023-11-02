using UnityEngine;

public class NpcMovement : MonoBehaviour
{
      public float moveSpeed = 2.0f;
    public float changeDirectionInterval = 2.0f; // Time between changing movement direction
    
    private float timeSinceLastDirectionChange = 0.0f;
    private Vector2 currentDirection;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        // Initialize references
        spriteRenderer = GetComponent<SpriteRenderer>();
        
        // Initialize the NPC's movement direction
        ChangeDirection();
    }

    private void Update()
    {
        // Move the NPC in the current direction
        transform.Translate(currentDirection * moveSpeed * Time.deltaTime);

        // Check if it's time to change direction
        timeSinceLastDirectionChange += Time.deltaTime;
        if (timeSinceLastDirectionChange >= changeDirectionInterval)
        {
            ChangeDirection();
        }

        // Flip the sprite based on the movement direction
        if (currentDirection.x > 0)
        {
            spriteRenderer.flipX = false; // Facing right
        }
        else if (currentDirection.x < 0)
        {
            spriteRenderer.flipX = true; // Facing left
        }
    }

    private void ChangeDirection()
    {
        // Generate a random direction
        currentDirection = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;

        // Reset the timer
        timeSinceLastDirectionChange = 0.0f;
    }
}
