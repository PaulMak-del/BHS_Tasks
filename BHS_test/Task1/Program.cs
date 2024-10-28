using BHS_test.Nodes;
using BHS_test.Task1;

namespace BHS_test;

class Program
{
    static void Main(string[] args)
    {
        TestFromSpec();
        Test();
    }

    private static void Test()
    {
        // Блоки
        EntryNode entryNode = new EntryNode();
        AdderNode adderNode1 = new AdderNode();
        AdderNode adderNode2 = new AdderNode();
        AdderNode adderNode3 = new AdderNode();
        ConstNode constNode1 = new ConstNode(2);
        ConstNode constNode2 = new ConstNode(3);
        ConstNode constNode3 = new ConstNode(4);
        ConstNode constNode4 = new ConstNode(5);
        PrintNode printNode1 = new PrintNode();
        PrintNode printNode2 = new PrintNode();
        PrintNode printNode3 = new PrintNode();
        
        // Навигационные Связи 
        entryNode.NextNode = adderNode3;
        adderNode3.NextNode = printNode3;
        
        // Связи данных
        Link link1 = new Link(constNode1.OutputSlots[0], adderNode1.InputSlots[0]);
        constNode1.OutputSlots[0].AddOutputLink(link1);
        adderNode1.InputSlots[0].SetInputLink(link1);
        
        Link link2 = new Link(constNode2.OutputSlots[0], adderNode1.InputSlots[1]);
        constNode2.OutputSlots[0].AddOutputLink(link2);
        adderNode1.InputSlots[1].SetInputLink(link2);
        
        Link link3 = new Link(adderNode1.OutputSlots[0], adderNode3.InputSlots[0]);
        adderNode1.OutputSlots[0].AddOutputLink(link3);
        adderNode3.InputSlots[0].SetInputLink(link3);
        
        Link link4 = new Link(constNode3.OutputSlots[0], adderNode2.InputSlots[0]);
        constNode3.OutputSlots[0].AddOutputLink(link4);
        adderNode2.InputSlots[0].SetInputLink(link4);
        
        Link link5 = new Link(constNode4.OutputSlots[0], adderNode2.InputSlots[1]);
        constNode4.OutputSlots[0].AddOutputLink(link5);
        adderNode2.InputSlots[1].SetInputLink(link5);
        
        Link link6 = new Link(adderNode2.OutputSlots[0], adderNode3.InputSlots[1]);
        adderNode2.OutputSlots[0].AddOutputLink(link6);
        adderNode3.InputSlots[1].SetInputLink(link6);
        
        Link link7 = new Link(adderNode3.OutputSlots[0], printNode3.InputSlots[0]);
        printNode3.InputSlots[0].SetInputLink(link7);
        adderNode3.OutputSlots[0].AddOutputLink(link7);
        
        Link link8 = new Link(adderNode1.OutputSlots[0], printNode1.InputSlots[0]);
        adderNode1.OutputSlots[0].AddOutputLink(link8);
        printNode1.InputSlots[0].SetInputLink(link8);
        
        Link link9 = new Link(adderNode2.OutputSlots[0], printNode2.InputSlots[0]);
        adderNode2.OutputSlots[0].AddOutputLink(link9);
        printNode2.InputSlots[0].SetInputLink(link9);
        
        // Запуск 
        entryNode.Run();
    }

    private static void TestFromSpec()
    {
        // Блоки
        EntryNode entryNode = new EntryNode();
        AdderNode adderNode = new AdderNode();
        ConstNode constNode1 = new ConstNode(2);
        ConstNode constNode2 = new ConstNode(3);
        PrintNode printNode = new PrintNode();
        
        // Навигационные Связи 
        entryNode.NextNode = adderNode;
        adderNode.NextNode = printNode;
        
        // Связи данных
        Link link1 = new Link(constNode1.OutputSlots[0], adderNode.InputSlots[0]);
        Link link2 = new Link(constNode2.OutputSlots[0], adderNode.InputSlots[1]);
        Link link3 = new Link(adderNode.OutputSlots[0], printNode.InputSlots[0]);
        
        constNode1.OutputSlots[0].AddOutputLink(link1);
        constNode2.OutputSlots[0].AddOutputLink(link2);
        adderNode.OutputSlots[0].AddOutputLink(link3);
        
        adderNode.InputSlots[0].SetInputLink(link1);
        adderNode.InputSlots[1].SetInputLink(link2);
        printNode.InputSlots[0].SetInputLink(link3);
        
        // Запуск 
        entryNode.Run();
    }
}