using UnityEngine;

class DebugCommand : Command
{
    string key;

    public DebugCommand(string key)
    {
        this.key = key;
    }

    public override void Do()
    {
        Debug.Log("DO " + key);
    }

    public override void Undo()
    {
        Debug.Log("UNDO " + key);
    }
}