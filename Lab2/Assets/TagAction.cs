using UnityEngine;

public class TagAction : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Restart"))
        {
            transform.position = new Vector3(0, 0, 0);
        }
    }
}
