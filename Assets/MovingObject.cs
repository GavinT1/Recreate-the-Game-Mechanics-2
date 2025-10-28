using UnityEngine;

public class MovingObject : MonoBehaviour
{
    public float speed = 3f;
    public float destroyX = 10f;

    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        if (transform.position.x > destroyX)
            Destroy(gameObject);
    }
}