using UnityEngine;
using UnityEngine.InputSystem;

public class goo_script : MonoBehaviour
{
    public float moveSpeed;
    private Vector2 _moveDirection;

    public InputActionReference move;

    public int mass;

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
