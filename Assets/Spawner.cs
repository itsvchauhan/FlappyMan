using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject pipe;
    public float counter = 0;
    public float counter2 = 0;

    public float rate;
    public float difficulty = 0;

    public float offset;

    public float deadzone;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float max = transform.position.y + offset;
        float min = transform.position.y - offset;

        counter2 += Time.deltaTime;
        if (counter2 >= 500)
        {
            counter2 = 500;
        }



        counter = counter + Time.deltaTime + counter2 * difficulty;

        if (counter >= rate)
        {
            Instantiate(pipe, new Vector3(transform.position.x, Random.Range(max, min), 0), transform.rotation);
            counter = 0;
        }

        

    }
}
