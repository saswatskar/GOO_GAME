using UnityEngine;

namespace goo_game.utils
{
    public static class HelperFunctions 
    {
        public static Vector3 generate_random_vector3()
            {
                return new Vector3(
                    (float)UnityEngine.Random.Range(-600 , 600)/100,
                    (float)UnityEngine.Random.Range(-300 , 300)/100,
                    0.1f);
            }   
    }
}