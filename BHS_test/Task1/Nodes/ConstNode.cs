using BHS_test.Slots;

namespace BHS_test.Nodes;

public class ConstNode : Node
{
    private int ConstValue { get; }

    public ConstNode(int value) 
    {
        ConstValue = value;
        OutputSlots.Add(new OutputSlot(this));
    }
    
    public override void Run()
    {
        Console.WriteLine("ConstNode: Run()");
        OutputSlots[0].Value = ConstValue;
    }
}
