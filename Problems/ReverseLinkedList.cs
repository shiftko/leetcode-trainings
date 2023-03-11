using Problems.Shared;

namespace Problems;

public static class ReverseLinkedList
{
    public static ListNode? ReverseList(ListNode? node)
    {
        ListNode? prev = default;
        ListNode? current = node;
        while (current is not null)
        {
            var setupNext = current.Next;
            current.Next = prev;
            prev = current;
            current = setupNext;
        }

        return prev;
    }
}