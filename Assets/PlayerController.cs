using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 9f;
    public float minX = -8f;
    public float maxX = 8f;

    void Update()
    {
        float move = Input.GetAxisRaw("Horizontal");

        // Touch / mouse: move toward where you press
        if (Input.GetMouseButton(0))
        {
            float targetX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x;
            float diff = targetX - transform.position.x;
            move = Mathf.Abs(diff) > 0.15f ? Mathf.Sign(diff) : 0f;
        }

        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x + move * speed * Time.deltaTime, minX, maxX);
        transform.position = pos;
    }
}