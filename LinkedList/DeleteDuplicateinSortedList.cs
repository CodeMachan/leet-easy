// https://leetcode.com/problems/remove-duplicates-from-sorted-list/?envType=problem-list-v2&envId=linked-list

public class DeleteDuplicatesFromSortedList {
    
    public DeleteDuplicatesFromSortedList()
    {
        int[] values = { 1, 1, 1, 2, 3, 3, 3, 4, 5, 5, 6 };
        ListNode head = ListNode.BuildList(values);
        var result = DeleteDuplicates(head);
        Merge2SortedList.PrintList(result);
    }

    public ListNode DeleteDuplicates(ListNode head)
    {
        ListNode dummy = new ListNode(0,head);
        ListNode current = dummy;
        while (head != null && head.next != null)
        {
            if (head.val == head.next.val)
            {
                head = head.next;
            }
            else
            {
                current.next = head;
                current = current.next;
                head = head.next;
            }
        }
        if (head != null)
        {
            current.next = head;
        }
        return dummy.next;
    }
}