
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

            if(displacement.magnitude > 2)
            {
                Debug.Log(displacement + "difference");
                transform.position += (Vector3)displacement*Time.deltaTime*2;

            }        
        }
    }
}
