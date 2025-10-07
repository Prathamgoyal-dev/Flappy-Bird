using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject pipePrefab;
    public float spawnRate = 80f;
    public float timer = 0f;
    public float heightOffset = 10f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0f;
        }
    }
    
    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;   

        Instantiate(pipePrefab,new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation); 
    }
}
