using UnityEngine;

public class CommandTest : MonoBehaviour
{
    void Update()
    {
        if(Input.anyKeyDown && !string.IsNullOrEmpty(Input.inputString))
        {
            DebugCommand cmd = new DebugCommand(Input.inputString);
            CommandManager.Do(cmd);
        }
    }
}