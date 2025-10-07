using UnityEngine;

public class BirdScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Rigidbody2D myrigidbody;
    public float flapstrength;
    public LogicScript logic;

    public bool isAlive = true;
    void Start()
    {

        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)   && isAlive)
        {
            myrigidbody.linearVelocity = Vector2.up * flapstrength;
        }

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        logic.Gameover();
        isAlive = false;
    
    }
}
