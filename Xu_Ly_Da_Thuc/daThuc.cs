using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xu_Ly_Da_Thuc
{
    public class daThuc
    {
        private Node head;

        public Node Head { get => head; set => head = value; }
       
        public String printList()
        {
            Node n = head;
            String kq="";
            while (n != null)
            {
                if(n.SoMu==1)
                    kq += Math.Round(n.HeSo, 2) + "X   ";
                else if(n.SoMu==0)
                    kq += Math.Round(n.HeSo, 2) + "   ";
                else
                    kq += Math.Round(n.HeSo,2) + "X^" + n.SoMu + "   ";
                n = n.Next;
            }
            return kq;
        }
        /* Inserts a new Node at front of the list. */
        public void AddFirst(Node newNode)
        {
            newNode.Next = head;
            head = newNode;
        }

        /*Insert a new Node at the end of the list*/
        public void AddLast(Node newNode)
        {
            /* If the Linked List is empty,  
               then make the new node as head */
            if (head == null)
            {
                head = newNode;
                return;
            }

            /* This new node is going to be  
            the last node, so make next of it as null */
            newNode.Next = null;

            /* Else traverse till the last node */
            Node last = head;
            while (last.Next != null)
                last = last.Next;

            /* Change the next of last node */
            last.Next = newNode;
            return;
        }
        public void Clear()
        {
            head = null;
        }
        /* Given a key, deletes the first occurrence of key in linked list */
        void deleteNode(Node node)
        {
            // Store head node 
            Node temp = head, prev = null;

            // If head node itself holds the key to be deleted 
            if (temp != null && temp.HeSo == node.HeSo&&temp.SoMu==node.SoMu)
            {
                head = temp.Next; // Changed head 
                return;
            }

            // Search for the key to be deleted, keep track of the 
            // previous node as we need to change temp.next 
            while (temp != null && (temp.HeSo != node.HeSo||temp.SoMu!=node.SoMu))
            {
                prev = temp;
                temp = temp.Next;
            }

            // If key was not present in linked list 
            if (temp == null) return;

            // Unlink the node from linked list 
            prev.Next = temp.Next;
        }
        public daThuc tinhTong(daThuc l2)
        {
            daThuc lTong = new daThuc();
            Node p1 = this.Head;
            Node p2 = l2.Head;
            Node p3;
            while (p1 != null || p2 != null)
            {
                if (p1 == null && p2 != null)
                {
                    p3 = new Node(p2.HeSo, p2.SoMu);
                    lTong.AddLast(p3);
                    p2 = p2.Next;
                    continue;
                }
                if (p1 != null && p2 == null)
                {
                    p3 = new Node(p1.HeSo, p1.SoMu);
                    lTong.AddLast(p3);
                    p1 = p1.Next;
                    continue;
                }
                // so mu p1 = so mu p2
                if (p1.SoMu == p2.SoMu)
                {
                    p3 = new Node(p1.HeSo + p2.HeSo, p1.SoMu);
                    lTong.AddLast(p3);
                    p1 = p1.Next;
                    p2 = p2.Next;
                }
                // so mu p1 > so mu p2
                else if (p1.SoMu > p2.SoMu)
                {
                    p3 = new Node(p1.HeSo, p1.SoMu);
                    lTong.AddLast(p3);
                    p1 = p1.Next;
                    continue;
                }
                // so mu p1 < so mu p2
                else
                {
                    p3 = new Node(p2.HeSo, p2.SoMu);
                    lTong.AddLast(p3);
                    p2 = p2.Next;
                }
            }
            return lTong;
        }
        public daThuc tinhHieu(daThuc l2)
        {
            Node p1 = this.Head;
            Node p2 = l2.Head;
            Node p3;
            daThuc lHieu = new daThuc();
            while (p1 != null || p2 != null)
            {
                if (p1 == null && p2 != null)
                {
                    p3 = new Node(-p2.HeSo, p2.SoMu);
                    lHieu.AddLast(p3);
                    p2 = p2.Next;
                    continue;
                }
                if (p1 != null && p2 == null)
                {
                    p3 = new Node(p1.HeSo, p1.SoMu);
                    lHieu.AddLast(p3);
                    p1 = p1.Next;
                    continue;
                }
                // so mu p1 = so mu p2
                if (p1.SoMu == p2.SoMu)
                {
                    p3 = new Node(p1.HeSo - p2.HeSo, p1.SoMu);
                    lHieu.AddLast(p3);
                    p1 = p1.Next;
                    p2 = p2.Next;
                }
                // so mu p1 > so mu p2
                else if (p1.SoMu > p2.SoMu)
                {
                    p3 = new Node(p1.HeSo, p1.SoMu);
                    lHieu.AddLast(p3);
                    p1 = p1.Next;
                    continue;
                }
                // so mu p1 < so mu p2
                else
                {
                    p3 = new Node(-p2.HeSo, p2.SoMu);
                    lHieu.AddLast(p3);
                    p2 = p2.Next;
                }
            }
            return lHieu; 
        }
        public daThuc tinhNhan(daThuc l2)
        {
            daThuc lNhanDaThuc = new daThuc();
            for (Node i = this.Head; i != null; i = i.Next)
            {
                daThuc lNhanDonThuc = new daThuc();
                for (Node j = l2.Head; j != null; j = j.Next)
                {
                    Node temp = new Node(i.HeSo * j.HeSo, i.SoMu + j.SoMu);
                    lNhanDonThuc.AddLast(temp);
                }
                lNhanDaThuc = lNhanDaThuc.tinhTong(lNhanDonThuc);

            }
            return lNhanDaThuc;
        }
        public daThuc daoHam()
        {
            daThuc lDaoHam = new daThuc();
            for (Node i = this.Head; i != null; i = i.Next)
            {
                if (i.SoMu == 0) continue;
                Node temp = new Node(i.HeSo * i.SoMu, i.SoMu - 1);
                lDaoHam.AddLast(temp);
            }
            return lDaoHam;
        }
        public daThuc daoHam(int n)
        {
            daThuc lDaoHam = this;
            daThuc result=new daThuc();
            for(int j = 0; j < n; j++)
            {
                result = new daThuc();
                for (Node i = lDaoHam.Head; i != null; i = i.Next)
                {
                    if (i.SoMu == 0) continue;
                    Node temp = new Node(i.HeSo * i.SoMu, i.SoMu - 1);
                    result.AddLast(temp);
                }
                lDaoHam = result;
            }
            return result;
        }
        public daThuc nguyenHam()
        {
            daThuc lNguyenHam = new daThuc();
            for (Node i = this.Head; i != null; i = i.Next)
            {
                Node temp = new Node(i.HeSo / (i.SoMu + 1), i.SoMu + 1);
                lNguyenHam.AddLast(temp);
            }
            return lNguyenHam;
        }
        public List<daThuc> tinhChia(daThuc l2)
        {
            List<daThuc> kq = new List<daThuc>();
            daThuc lChia = new daThuc();
            daThuc lphanDu = this;
            daThuc ltemp = new daThuc();

            while (lphanDu.Head!=null && lphanDu.Head.SoMu >=l2.Head.SoMu)
            {
                Node temp = new Node(lphanDu.Head.HeSo / l2.head.HeSo, lphanDu.Head.SoMu - l2.Head.SoMu);
                lChia.AddLast(temp);
                ltemp.Clear();
                ltemp.AddLast(temp);
                lphanDu = lphanDu.tinhHieu(ltemp.tinhNhan(l2));
                lphanDu.deleteNode(lphanDu.Head);
            }

            kq.Add(lChia);
            kq.Add(lphanDu);
            return kq;
        }
        public void sapTang()
        {
            for (Node i = this.Head; i != null; i = i.Next)
            {
                for (Node j = i.Next; j != null; j = j.Next)
                {
                    if (i.SoMu > j.SoMu)
                    {
                        Node temp = new Node(i.HeSo, i.SoMu);
                        i.HeSo = j.HeSo;
                        i.SoMu = j.SoMu;
                        j.HeSo = temp.HeSo;
                        j.SoMu = temp.SoMu;
                    }
                }
            }
        }
        public void sapGiam()
        {
            
            for (Node i = this.Head; i != null; i = i.Next)
            {
                for (Node j = i.Next; j != null; j = j.Next)
                {
                    if (i.SoMu < j.SoMu)
                    {
                        Node temp = new Node(i.HeSo, i.SoMu);
                        i.HeSo = j.HeSo;
                        i.SoMu = j.SoMu;
                        j.HeSo = temp.HeSo;
                        j.SoMu = temp.SoMu;
                    }
                }
            }
        }
        public void thuGon()
        {
            for (Node i = this.Head; i != null; i = i.Next)
            {
                Node prev = i;
                for (Node j = i.Next; j != null; j = j.Next)
                {
                    if (i.SoMu == j.SoMu)
                    {
                        i.HeSo += j.HeSo;
                        prev.Next = j.Next; //Xoa nut j
                        continue;
                    }
                    prev = prev.Next;
                }
            }
        }
        public double tinhTri(double x)
        { 
            double sum = 0;
            for (Node i = this.Head; i != null; i = i.Next)
            {
                sum += i.HeSo * (Math.Pow(x, i.SoMu));
            }
            return sum;
        }
    }
}
