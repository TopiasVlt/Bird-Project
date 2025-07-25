using UnityEngine;

public class Wind : MonoBehaviour
{
    public Vector2 windForce = new Vector2(5f, 0f);
    public bool toggleWind = false;
    public float toggleInterval = 2f;
    public float extraDrag = 2f;

    private bool windActive = true;

    private void Start()
    {
        if (toggleWind)
        {
            InvokeRepeating(nameof(ToggleWindState), 0f, toggleInterval);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (other.CompareTag("Player"))
        {
            Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                rb.linearDamping += extraDrag;
            }
        }
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (windActive && other.CompareTag("Player"))
        {
            Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                rb.AddForce(windForce * Time.deltaTime, ForceMode2D.Force);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (other.CompareTag("Player"))
        {
           Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
        }
    }

    private void ToggleWindState()
    {
        windActive = !windActive;
    }
}