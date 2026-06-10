using UnityEngine;
public class Character : MonoBehaviour
{
    [SerializeField] protected int mass = 1;
    public int Mass => mass;
    [SerializeField] protected float density = 1f;
    public float Density => density;
    [SerializeField] protected float scale = 1f;
    public float Scale => scale;
    public void set_localscale(float scalefactor)
    {
        scale = Mathf.Sqrt((float)mass / density);
        transform.localScale = Vector3.one*scale*scalefactor;
    }
    public void addmass(int amount)
    {
        mass+=amount;
    }
    public float get_scale()
    {
        return scale;
    }
    public float get_density()
    {
        return density;
    }
    public int get_mass()
    {
        return mass;
    }
}