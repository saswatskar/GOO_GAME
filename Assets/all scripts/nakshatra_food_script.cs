

using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;
using goo_game.utils;

public class nakshatra_food_script : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Rigidbody2D rb;
    public Transform TargetObject;
    public float speed;
    public float turn_speed = 0.5f;
    public int clock = 0;

    public int mode;
    public int avoid_mode;
    void Start()
    {
        transform.position = HelperFunctions.generate_random_vector3();
        rb.linearVelocity =  Vector2.down*speed;
        TargetObject = GameObject.FindGameObjectWithTag("goo").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {        
    }

    void FixedUpdate()
    {

        Vector3 target_vector = transform.position-TargetObject.transform.position ;

        if (target_vector.magnitude < 9)
        {
            mode = 1;//avoiding mode

            if (clock%200 <70)
            {
                mode = 2;
                if (clock%200 == 90)
                {
                    if (UnityEngine.Random.Range(0, 2) == 1)
                    {
                        avoid_mode = 1;
                    }
                    else{avoid_mode = 0;}
                }
            }        
        }
        else mode = 0;
        switch (mode)
        {
            case 1 ://escape mode
                Vector3 new_direction = Vector3.RotateTowards(
                    rb.linearVelocity,
                    target_vector,
                    turn_speed,
                    0f
                );
                new_direction.Normalize();   
                new_direction = new_direction*speed*UnityEngine.Random.Range(1 , 3);
                rb.linearVelocity = new_direction;
                break;
            
            case 2 : //juke mode
                Vector3 juke_direction;
                if(avoid_mode == 1)
                {
                    juke_direction = Vector3.RotateTowards(
                    rb.linearVelocity,
                    new Vector3(-target_vector.y,target_vector.x,0f),
                    turn_speed,
                    0f
                    );
                }
                else
                {
                        juke_direction = Vector3.RotateTowards(
                        rb.linearVelocity,
                        new Vector3(target_vector.y,-target_vector.x,0f),
                        turn_speed,
                        0f);
                }
                
                juke_direction.Normalize();
                juke_direction = juke_direction*speed*UnityEngine.Random.Range(3 , 5);
                rb.linearVelocity = juke_direction;
                break;
            default : 
                rb.linearVelocity = Vector2.zero;
                break;
        }

        clock++;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("goo"))
        {
            Destroy(gameObject);
        }
    }
    
}
