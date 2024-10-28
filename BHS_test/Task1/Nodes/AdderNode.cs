using BHS_test.Slots;

namespace BHS_test.Nodes;

public class AdderNode : Node
{
    public AdderNode()
    {
        InputSlots.Add(new InputSlot(this));
        InputSlots.Add(new InputSlot(this));
        OutputSlots.Add(new OutputSlot(this));
    }
    
    public override void Run()
    {
        Console.WriteLine("AdderNode: Run()");
        int? in1 = InputSlots[0].InputLink.Source.Value;
        if (in1 == null)
        {
            InputSlots[0].InputLink.Source.ParentNode.Run();
        }
        
        int? in2 = InputSlots[1].InputLink.Source.Value;
        if (in2 == null)
        {
            InputSlots[1].InputLink.Source.ParentNode.Run();
        }
        
        OutputSlots[0].Value = InputSlots[0].InputLink.Source.Value + InputSlots[1].InputLink.Source.Value;
        
        NextNode?.Run();
    }
}
