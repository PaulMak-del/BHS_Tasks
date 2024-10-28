using BHS_test.Nodes;
using BHS_test.Task1;

namespace BHS_test.Slots;

public abstract class Slot(Node parentNode)
{
    public Node ParentNode { get; set; } = parentNode;
    
    public Link InputLink { get; set; }
    public List<Link> OutputLinks { get; set; } = [];

    public void SetInputLink(Link link)
    {
        InputLink = link; 
    }

    public void AddOutputLink(Link link)
    {   
        OutputLinks.Add(link);
    }
}
