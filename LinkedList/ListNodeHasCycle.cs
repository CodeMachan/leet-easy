//https://leetcode.com/problems/linked-list-cycle/description/?envType=problem-list-v2&envId=linked-list
public class HasCycleInLinkedList
{
    public bool HasCycle(ListNode head)
    {
        HashSet<ListNode> nodesSeen = new HashSet<ListNode>();
        while (head != null)
        {
            if (nodesSeen.Contains(head))
            {
                return true;
            }
            nodesSeen.Add(head);
            head = head.next;
        }
        return false;
    }
}