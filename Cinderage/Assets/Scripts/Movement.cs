using UnityEngine;

public class Movement : MonoBehaviour

{
    public float Speed = 5f;
    Rigidbody2D rigidbody;
  
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 retning = new Vector2(0, 0);
        if (Input.GetKey(KeyCode.W))
        {
            retning += new Vector2(0, 1);
        }
               
        if (Input.GetKey(KeyCode.S))
        {
            retning += new Vector2(0, -1);
        }
       
        if (Input.GetKey(KeyCode.A))
        {
            retning += new Vector2(-1, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            retning += new Vector2(1, 0);
        }

        retning = retning.normalized;
        retning *= Speed;

        rigidbody.linearVelocity = retning;

    }
}
