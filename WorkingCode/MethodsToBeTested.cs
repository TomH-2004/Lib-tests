using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingCode
{
    public class MethodsToBeTested
    {
        public int CalculateFactorial(int x)
        {
            if (x < 0)
                throw new ArgumentException("n must be non-negative");
            if (x == 0 || x == 1)
                return 1;
            return x * CalculateFactorial(x - 1);
        }
    }

    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        

        int currentValule;

        
        
    }

    public static ListNode RecursiveAdd(ListNode l1, ListNode l2, bool AddOne)
    {
        var myListNode = new ListNode();

        int currentValule = l1.val + l2.val;
        bool addOne = false;

        if (currentValule > 10)
        {
            currentValule -= 10;
        }

        myListNode.val = currentValule;

        myListNode.next = RecursiveAdd()
    }

    ListNode RecursiveAdd()
    {
        throw new NotImplementedException();
    }
}



public sealed class Circle
{
    private double radius;

    public double Calculate(Func<double, double> op)
    {
        return op(radius);
    }
}

public class ListNode
{
       public int val;
       public ListNode next;
       public ListNode(int val = 0, ListNode next = null)
    {
         this.val = val;
         this.next = next;
              }
   }
