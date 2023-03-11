using Problems.Shared;

namespace Problems;

public static class MergeTwoSortedLists
{
    public static ListNode? MergeTwoLists(ListNode? list1, ListNode? list2)
    {
        ListNode? headNode;
        ListNode? currentNode;

        if (list1 is null && list2 is null)
        {
            return null;
        }

        if (list1 is null)
        {
            return list2;
        }

        if (list2 is null)
        {
            return list1;
        }

        if (list1.Val > list2.Val)
        {
            headNode = list2;
            currentNode = headNode;
            list2 = list2.Next;
        }
        else
        {
            headNode = list1;
            currentNode = headNode;
            list1 = list1.Next;
        }

        while (list1 != null || list2 != null)
        {
            if (list1 is null)
            {
                currentNode.Next = list2;
                currentNode = list2;
                list2 = list2.Next;
                continue;
            }

            if (list2 is null)
            {
                currentNode.Next = list1;
                currentNode = list1;
                list1 = list1.Next;
                continue;
            }

            if (list1.Val > list2.Val)
            {
                currentNode.Next = list2;
                currentNode = list2;
                list2 = list2.Next;
            }
            else
            {
                currentNode.Next = list1;
                currentNode = list1;
                list1 = list1.Next;
            }
        }

        return headNode;
    }
}