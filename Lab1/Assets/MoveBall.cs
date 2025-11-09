using UnityEngine;

public class MoveBall : MonoBehaviour
{
    [SerializeField] readonly float velocity = 10f;
    [SerializeField] readonly float rotationFactor = 180f;
            
    void Update()
    {
        var deltaVertical = Input.GetAxis("Vertical");
        var deltaHorizontal = Input.GetAxis("Horizontal");
        var timeDelta = Time.deltaTime;

        var moveX = deltaHorizontal * velocity * timeDelta;
        var moveZ = deltaVertical * velocity * timeDelta;
        transform.Translate(moveX, 0, moveZ, Space.World);

        if (moveZ != 0)
        {
            transform.Rotate(moveZ * rotationFactor, 0, 0, Space.World);
        }
        if (moveX != 0)
        {
            transform.Rotate(0, 0, -moveX * rotationFactor, Space.World);
        }
    }
}
