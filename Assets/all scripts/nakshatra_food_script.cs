

using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;

public class nakshatra_food_script : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Rigidbody2D rb;
    public Transform TargetObject;
    public float speed;
    public float turn_speed;
    void Start()
    {
        transform.position = generate_random_vector3();
        rb.linearVelocity =  Vector2.down*speed;
    }

    // Update is called once per frame
    void Update()
    {        
    }

    void FixedUpdate()
    {
        Vector3 target_vector = transform.position-TargetObject.transform.position ;
        Vector3 new_direction = Vector3.RotateTowards(
            rb.linearVelocity,
            target_vector,
            turn_speed,
            0f
        );
        rb.linearVelocity = new_direction;

    }
    Vector3 generate_random_vector3()
    {
        return new Vector3(
            (float)UnityEngine.Random.Range(-600 , 600)/100,
            (float)UnityEngine.Random.Range(-300 , 300)/100,
            0);
    }
    
}
