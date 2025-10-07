using UnityEngine;

public class BirdScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Rigidbody2D myrigidbody;
    void Start()
    {
        gameObject.name = "Flappy Bird";
    }

    // Update is called once per frame
    void Update()
    {
        myrigidbody.linearVelocity = Vector2.up * 10; 
    }
}
