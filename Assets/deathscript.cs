using UnityEngine;

public class deathscript : MonoBehaviour
{
    public GameObject Gameover;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    
private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            Gameover.SetActive(true);
        }
        
    }

}
