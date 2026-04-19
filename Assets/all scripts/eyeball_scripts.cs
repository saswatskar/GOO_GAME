
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Scripting.APIUpdating;

public class eyeball_scripts : MonoBehaviour
{

    private goo_script ParentScript;
    public Vector3 RightPos = new Vector3(0f , 0.12f , -0.1f);
    public float eye_ball_radius;

    void Start()
    {
        transform.localPosition = RightPos;
        Debug.Log("set position" + transform.localPosition);
        ParentScript = GetComponentInParent<goo_script>();
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector2 _moveDirection = ParentScript.get_moveDirection();


        transform.localPosition = RightPos + (Vector3)_moveDirection*eye_ball_radius;

    }
}
