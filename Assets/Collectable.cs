using UnityEngine;

public class Collectable : MonoBehaviour
{
    public int pointValue = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if ( other.CompareTag("Player"))
        {
            PointSystem.Instance.AddPoints(pointValue);
            Destroy(gameObject);
        }
    }
}
