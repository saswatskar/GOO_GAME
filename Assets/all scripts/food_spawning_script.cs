using System.Threading;
using UnityEngine;

public class food_spawning_script : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject Nakshatra; 
    public float count = 0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(count>3)
        {
            count = 0;
            Instantiate(Nakshatra , Vector3.zero , Quaternion.identity);
        }
        
        count+=Time.deltaTime;
    }
}
