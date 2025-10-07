using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipePrefab;
    public float spawnRate = 2f;          // Base time between spawns
    private float timer = 0f;

    public float heightOffset = 2f;       // Random vertical offset
    public float baseGap = 5f;            // Base horizontal gap between pipes
    public float gapIncreaseRate = 0.5f;  // How much horizontal gap increases per spawn

    private float currentGap;             // Current horizontal distance between pipes
    private float lastPipeX;              // X position of last spawned pipe
    private Camera mainCamera;
    private float screenRightEdgeX;

    void Start()
    {
        mainCamera = Camera.main;
        currentGap = baseGap;

        // Calculate the right edge of the camera in world units
        screenRightEdgeX = mainCamera.ViewportToWorldPoint(new Vector3(1, 0, 0)).x;

        // Initialize lastPipeX so the first pipe spawns off-screen
        lastPipeX = screenRightEdgeX + currentGap;
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnRate)
        {
            SpawnPipe();
            timer = 0f;
            currentGap += gapIncreaseRate; // Increase horizontal gap
        }
    }

    void SpawnPipe()
    {
        // Random vertical position
        float spawnY = transform.position.y + Random.Range(-heightOffset, heightOffset);

        // Spawn pipe off the right edge of the camera
        float spawnX = lastPipeX;
        Instantiate(pipePrefab, new Vector3(spawnX, spawnY, 0f), transform.rotation);

        lastPipeX = spawnX + currentGap; // Update last pipe position
    }
}
