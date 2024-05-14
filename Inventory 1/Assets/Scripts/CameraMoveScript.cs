using UnityEngine;

public class CamMoveTest : MonoBehaviour
{
    public RectTransform canvasRectTransform;
    public GameObject startPositionObject; // GameObject representing the starting position
    public GameObject endPositionObject; // GameObject representing the ending position
    public float moveSpeed = 5f; // Speed of movement

    private Vector2 startPosition;
    private Vector2 endPosition;
    private bool moveToEnd = true;

    void Start()
    {
        // Assuming you've assigned these in the Unity Editor
        canvasRectTransform = GetComponent<RectTransform>();

        // Get the positions from the GameObjects
        startPosition = startPositionObject.transform.position;
        endPosition = endPositionObject.transform.position;
    }

    void Update()
    {
        // Move the canvas towards the target position based on the toggle
        Vector2 targetPosition = moveToEnd ? endPosition : startPosition;
        canvasRectTransform.anchoredPosition = Vector2.Lerp(canvasRectTransform.anchoredPosition, targetPosition, moveSpeed * Time.deltaTime);
    }

    public void ToggleCanvasMovement()
    {
        moveToEnd = !moveToEnd;
    }
}
