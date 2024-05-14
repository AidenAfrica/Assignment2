using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    [SerializeField] private string targetTag = "SnapPoint"; // Change this to the tag you want to detect collisions with

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(targetTag))
        {
            Debug.Log("Collision detected with tag: " + targetTag);
        }
    }
}
