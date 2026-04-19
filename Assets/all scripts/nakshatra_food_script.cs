using Unity.Collections;
using UnityEngine;

public class nakshatra_food_script : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private float velocity_change_clock;
    public Vector3 velocity;
    public float velocity_normalisation;
    public float change_timing;
    void Start()
    {
        transform.position = generate_random_vector3();
        velocity = generate_random_vector3()/velocity_normalisation;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += velocity*Time.deltaTime;
    }
    Vector3 generate_random_vector3()
    {
        return new Vector3(
            (float)Random.Range(-600 , 600)/100,
            (float)Random.Range(-300 , 300)/100,
            0);
    }
}
