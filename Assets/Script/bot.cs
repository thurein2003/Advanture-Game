using UnityEngine;
using System.Collections;

public class bot : MonoBehaviour
{
    public bool facingLeft = true; // Tracks the bot's current direction
    public float moveSpeed = 2f;  // Movement speed
    public Transform checkPoint;  // Reference point for raycast
    public float distance = 1f;   // Raycast distance
    public LayerMask layerMask;   // LayerMask for ground detection
    private bool canFlip = true;  // Prevents immediate flipping

    void Update()
    {
        // Move the bot
        transform.Translate(Vector2.left * Time.deltaTime * moveSpeed);

        // Perform raycast to check for ground
        RaycastHit2D hit = Physics2D.Raycast(checkPoint.position, Vector2.down, distance, layerMask);

        // If no ground is detected and flipping is allowed
        if (hit.collider == null && canFlip)
        {
            StartCoroutine(FlipDirection());
        }
    }

    private IEnumerator FlipDirection()
    {
        // Prevent multiple flips in quick succession
        canFlip = false;

        // Flip the bot's direction
        if (facingLeft)
        {
            transform.localScale = new Vector3(1, 1, 1); // Face right
            facingLeft = false;
        }
        else
        {
            transform.localScale = new Vector3(-1, 1, 1); // Face left
            facingLeft = true;
        }

        // Wait for a short cooldown before allowing another flip
        yield return new WaitForSeconds(0.5f);
        canFlip = true;
    }

    private void OnDrawGizmosSelected()
    {
        if (checkPoint == null) return;

        // Draw ray for visualization
        Gizmos.color = Color.yellow;
        Gizmos.DrawRay(checkPoint.position, Vector2.down * distance);
    }
}
