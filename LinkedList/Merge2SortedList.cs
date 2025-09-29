//https://leetcode.com/problems/merge-two-sorted-lists/?envType=problem-list-v2&envId=linked-list
// Definition for singly-linked list.
public class Merge2SortedList
{
    public Merge2SortedList()
    {
        ListNode list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
        ListNode list2 = new ListNode(1, new ListNode(3, new ListNode(4)));
        var result = MergeTwoLists(list1, list2);
        PrintList(result);
    }
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode dummy = new ListNode(-1);
        var current = dummy;

        while (list1 != null && list2 != null)
        {
            if (list1.val < list2.val)
            {
                current.next = list1;
                list1 = list1.next;
            }
            else
            {
                current.next = list2;
                list2 = list2.next;
            }
            current = current.next;
        }

        if (list1 != null)
            current.next = list1;
        else
            current.next = list2;

        return dummy.next;

    }
    public static void PrintList(ListNode head) {
    while (head != null) {
        Console.Write(head.val + " ");
        head = head.next;
    }
    Console.WriteLine();
}
}

