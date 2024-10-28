using BHS_test.Nodes;

namespace BHS_test.Slots;

public class OutputSlot(Node parentNode) : Slot(parentNode)
{
    public int? Value { get; set; } = null;
}
