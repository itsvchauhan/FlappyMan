using UnityEngine;

public class Script : MonoBehaviour
{
    public Rigidbody2D rigidbody;
    public float strength;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            rigidbody.linearVelocity = Vector2.up * strength;
            
        }

    }
}
