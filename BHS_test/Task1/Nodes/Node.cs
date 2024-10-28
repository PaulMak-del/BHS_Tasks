using BHS_test.Slots;

namespace BHS_test.Nodes;

public abstract class Node
{
    public Node? NextNode { get; set; }
    public List<InputSlot> InputSlots { get; set; } = [];
    public List<OutputSlot> OutputSlots { get; set; } = [];
    
    public abstract void Run();
}
