using UnityEngine;
using UnityEngine.InputSystem;
using Unity.Mathematics;
using TMPro;

public class goo_script : Character
{
    public float moveSpeed;
    private Vector2 _moveDirection;
    public float gooscale = 0.136f;
    private float _density_change;
    public InputActionReference move;
    public InputActionReference density_control;
    public TextMeshProUGUI enemytext;
    public TextMeshProUGUI infotext;

    private void Start()
    {
        mass = 10;
        name = "goo";
        enemytext.text = "";
    }
    private void Update()
    {
        set_localscale(gooscale);
        _moveDirection = move.action.ReadValue<Vector2>();
        transform.position +=(Vector3)_moveDirection*moveSpeed*Time.deltaTime;
        _density_change = density_control.action.ReadValue<float>();
        density += _density_change*Time.deltaTime;
        density = Mathf.Clamp(density, 0.5f, 1.5f);
        infotext.text = "density = "+density.ToString()+"\n";
        infotext.text+= "mass = "+mass.ToString()+"\n";
        infotext.text+= "size = "+((int)(scale*100)).ToString()+"\n";
    }

    public Vector2 get_moveDirection()
    { 
        return _moveDirection;
    }
    void OnTriggerStay2D(Collider2D collision)
    {
        Character other = collision.gameObject.GetComponent<Character>();
        enemytext.text = other.Name+"\n";
        enemytext.text+= "density = "+other.Density.ToString()+"\n";
        enemytext.text+= "mass = "+other.Mass.ToString()+"\n";
        enemytext.text+= "size = "+((int)(other.Scale*100)).ToString()+"\n";
    }
}
