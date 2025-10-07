using UnityEngine;

public class BirdScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Rigidbody2D myrigidbody;
    public float flapstrength ;
    void Start()
    {
        gameObject.name = "Flappy Bird";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            myrigidbody.linearVelocity = Vector2.up * flapstrength; 
}
        
    }
}
