using Problems.Shared;

namespace Problems;

public static class LinkedListCycle2
{
    public static ListNode? DetectCycle(ListNode? head)
    {
        var refs = new HashSet<ListNode>();
        while (head is not null)
        {
            if (refs.Contains(head.Next))
            {
                return head.Next;
            }

            refs.Add(head);
            head = head.Next;
        }

        return null;
    }

    public static ListNode? DetectCycle2(ListNode? head)
    {
        ListNode? slowHead = head;
        ListNode? fastHead = head;

        while (slowHead is not null && fastHead is not null)
        {
            slowHead = slowHead.Next;
            fastHead = fastHead.Next?.Next;

            if (slowHead == fastHead)
            {
                var tracker = slowHead;
                while (true)
                {
                    if (head == tracker)
                    {
                        return head;
                    }

                    if (tracker == slowHead)
                    {
                        head = head?.Next;
                    }

                    tracker = tracker?.Next;
                }
            }
        }

        return null;
    }
}