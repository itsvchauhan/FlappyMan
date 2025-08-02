using UnityEngine;

public class movementbg : MonoBehaviour
{
    public GameObject Ground;
    public float speed = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        if (transform.position.x <= -15)
        {

            Instantiate(Ground, new Vector3(15, transform.position.y, 0), transform.rotation);
            Destroy(gameObject);
        }
    }
}
