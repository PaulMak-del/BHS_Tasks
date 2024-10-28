using BHS_test.Slots;

namespace BHS_test.Nodes;

public class EntryNode : Node
{
    public EntryNode()
    {
        OutputSlots.Add(new OutputSlot(this));
    }
    public override void Run()
    {
        Console.WriteLine("EntryNode: Run()");
        NextNode?.Run();
    }
}
