using BHS_test.Slots;

namespace BHS_test.Task1;

public class Link(OutputSlot source, InputSlot target)
{
    public OutputSlot Source { get; set; } = source;
    public InputSlot Target { get; set; } = target;
}
