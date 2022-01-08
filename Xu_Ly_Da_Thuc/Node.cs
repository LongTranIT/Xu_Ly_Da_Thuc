using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xu_Ly_Da_Thuc
{
    public class Node
    {
        private double heSo; //Ctr+R+E
        private int soMu;
        private Node next;

        public double HeSo { get => heSo; set => heSo = value; }
        public int SoMu { get => soMu; set => soMu = value; }
        public Node Next { get => next; set => next = value; }
        public Node(double heSo, int soMu)
        {
            this.heSo = heSo;
            this.soMu = soMu;
            this.next = null;
        }

        public Node(double heSo, int soMu, Node next)
        {
            this.heSo = heSo;
            this.soMu = soMu;
            this.next = next;
        }
    }
}
