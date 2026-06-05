using UnityEngine;
using UnityEngine.InputSystem;
using Unity.Mathematics;

public class goo_script : Character
{
    public float moveSpeed;
    private Vector2 _moveDirection;

    public InputActionReference move;

    private void Start()
    {
        mass = 10;
    }
    private void Update()
    {
        _moveDirection = move.action.ReadValue<Vector2>();
        transform.position +=(Vector3)_moveDirection*moveSpeed*Time.deltaTime;
    }

    public Vector2 get_moveDirection()
    {
        return _moveDirection;
    }
}
