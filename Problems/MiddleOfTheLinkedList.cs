using Problems.Shared;

namespace Problems;

public class MiddleOfTheLinkedList
{
    public static ListNode? GetMiddleNode(ListNode? head)
    {
        var counter = 0;
        var midNode = head;

        while (head is not null)
        {
            counter++;
            if (counter % 2 == 0)
            {
                midNode = midNode?.Next;
            }

            head = head.Next;
        }

        return midNode;
    }
}