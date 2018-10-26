using UnityEngine;

public class ShowGOCommand : Command
{
    public GameObject go;

    public ShowGOCommand(GameObject go)
    {
        this.go = go;
    }

    public override void Do()
    {
        go.SetActive(true);
    }

    public override void Undo()
    {
        go.SetActive(false);
    }
}
