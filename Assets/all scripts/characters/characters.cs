using UnityEngine;
public class Character : MonoBehaviour
{
    [SerializeField] protected int mass = 1;
    public int Mass => mass;
    [SerializeField] protected float density = 1f;
    public float Density => density;
    [SerializeField] protected float scale = 1f;
    public float Scale => scale;
    public void addmass(int amount)
    {
        mass+=amount;
    }
    public float get_scale()
    {
        return scale;
    }
}