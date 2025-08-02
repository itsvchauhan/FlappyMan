using UnityEngine;

public class movement : MonoBehaviour
{
    public float deadzone = -500;
    public float speed = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        if (transform.position.x <= deadzone)
        {
            Destroy(gameObject);
        }
    }
    
    
}
