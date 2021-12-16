class Node 
{
    public string Message;

    public Node(string messageValue)
    {
        Message = messageValue;
    }
}

class Question: Node
{
    public Node Left;

    public Node Right;

    public Question( string messageValue) : base (messageValue){}
}
 class DeceaseNode: Node {
     public DeceaseNode( string messageValue) : base(messageValue){}
 }