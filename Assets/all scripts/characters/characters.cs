using UnityEngine;
public class Character : MonoBehaviour
{
    [SerializeField] protected int mass = 1;
    public int Mass => mass;
    [SerializeField] protected float density = 1f;
    public float Density => density;
}