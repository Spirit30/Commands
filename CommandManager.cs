using System.Collections.Generic;

public static class CommandManager
{
    static Stack<Command> done = new Stack<Command>();
    static Stack<Command> undone = new Stack<Command>();

    public static void Do(Command cmd)
    {
        cmd.Do();
        done.Push(cmd);
        undone.Clear();
    }

    public static void Undo()
    {
        if (done.Count > 0)
        {
            Command cmd = done.Pop();
            cmd.Undo();
            undone.Push(cmd);
        }
    }

    public static void Redo()
    {
        if (undone.Count > 0)
        {
            Command cmd = undone.Pop();
            cmd.Do();
            done.Push(cmd);
        }
    }
}