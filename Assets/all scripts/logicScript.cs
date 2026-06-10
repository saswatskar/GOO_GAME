using TMPro;
using UnityEngine;

public class logicScript : MonoBehaviour
{
    public TextMeshProUGUI infotext;
    public goo_script GOO;
    public void update_stats()
    {
        infotext.text = "density = "+GOO.get_density().ToString()+"\n";
        infotext.text+= "mass = "+GOO.get_mass().ToString()+"\n";
        infotext.text+= "scale = "+GOO.get_scale().ToString()+"\n";
    }
    private void Update()
    {
        update_stats();
    }
}