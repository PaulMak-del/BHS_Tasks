using BHS_test.Slots;

namespace BHS_test.Nodes;

public class PrintNode : Node
{
    public PrintNode()
    {
        InputSlots.Add(new InputSlot(this));
    }
    public override void Run()
    {
        Console.WriteLine("PrintNode: Run()");
        int? in1 = InputSlots[0].InputLink.Source.Value;
        if (in1 == null)
        {
            InputSlots[0].InputLink.Source.ParentNode.Run();
        }
        
        Console.WriteLine(InputSlots[0].InputLink.Source.Value);
    }
}
