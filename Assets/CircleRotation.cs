using UnityEngine;

public class CircleRotation : MonoBehaviour
{
    public float rotationSpeed = 100f;
    private int direction = 1;

    void Update()
    {

        transform.Rotate(0f, 0f, direction * rotationSpeed * Time.deltaTime);


        if (Input.GetMouseButtonDown(0) || Input.anyKeyDown)
        {
            direction *= -1;
        }
    }
}
