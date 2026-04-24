
using System;
using System.IO.Compression;
using UnityEngine;

public class main_camera_script : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject Target;
    private UnityEngine.Vector2 displacement;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Target!=null)
        {
            displacement = (UnityEngine.Vector2)(Target.transform.position - transform.position);

            if(outside_ellipse(5 , 2 , displacement))
            {
                transform.position += (Vector3)displacement*Time.deltaTime*2;

            }        
        }
    }
    private Boolean outside_ellipse(float a , float b , Vector2 pos)
    {
        float value;
        value = ((pos.x)*(pos.x))/a*a + (pos.y*pos.y)/b*b;
        if(value > 1)
        {
            return true;
        }
        return false;
    }
}
