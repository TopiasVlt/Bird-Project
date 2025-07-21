using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    public float scrollSpeed = 0.5f;
    private Vector3 startPosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Record the initial position of the background
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Move the background to the left based on the scroll speed and time
        float newPosition = Mathf.Repeat(Time.time * scrollSpeed, 19);

        transform.position = startPosition + Vector3.left * newPosition;
    }
}
