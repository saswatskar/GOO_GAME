using UnityEngine;
using UnityEngine.InputSystem;
using Unity.Mathematics;

public class goo_script : Character
{
    public float moveSpeed;
    private Vector2 _moveDirection;
    public float gooscale = 0.136f;
    private float _density_change;
    public InputActionReference move;
    public InputActionReference density_control;
    private void Start()
    {
        mass = 10;
    }
    private void Update()
    {
        set_localscale(gooscale);
        _moveDirection = move.action.ReadValue<Vector2>();
        transform.position +=(Vector3)_moveDirection*moveSpeed*Time.deltaTime;
        _density_change = density_control.action.ReadValue<float>();
        density += _density_change*Time.deltaTime;
        density = Mathf.Clamp(density, 0.5f, 1.5f);
    }

    public Vector2 get_moveDirection()
    { 
        return _moveDirection;
    }
    
}
