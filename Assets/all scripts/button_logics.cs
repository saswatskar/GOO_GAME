using UnityEngine;

public class button_logics : MonoBehaviour
{
    
    public void end_game()
    {
        Application.Quit();

        // This will stop the "Play Mode" while you are in the Unity Editor
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}
