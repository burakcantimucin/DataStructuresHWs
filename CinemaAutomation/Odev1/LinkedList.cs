using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev1
{
    public class LinkedList : ListADT
    {
        public List<Seyirci> Seyirciler = new List<Seyirci>();
        public void SeyirciEkle(Seyirci s)
        {
            Seyirciler.Add(s);
        }
        public void SeyirciCikar(Seyirci s)
        {
            Seyirciler.Remove(s);
        }
        public override void InsertFirst(int value)
        {
            Node tmpHead = new Node
            {
                Data = value
            };

            if (Head == null)
                Head = tmpHead;
            else
            {
                tmpHead.Next = Head;
                Head = tmpHead;
            }
            Size++;
        }
        public override void InsertPos(int position, Seyirci seyirci)
        {
            Node posNode = Head;
            if (Head == null) return;
            Node tempNext;
            Node newNode = new Node()
            {
                Data = seyirci.KoltukNo
            };
            for (int i = 1; i < position; i++)
            {
                if (posNode.Next != null)
                    posNode = posNode.Next;
                else
                    return;
            }
            tempNext = posNode.Next;
            posNode.Next = newNode;
            newNode.Next = tempNext;
            Size++;
        }

        public override void DeletePos(int position)
        {
            Node posNode = Head;
            Node prevPosNode = new Node();

            if (Head == null) return;

            if (position == 1) return;

            for (int i = 1; i < position; i++)
            {
                if (posNode.Next != null)
                {
                    prevPosNode = posNode;
                    posNode = posNode.Next;
                }
                else
                    return;
            }
            prevPosNode.Next = posNode.Next;
            posNode = null;
            Size--;
        }

        public override String GetElement(int position)
        {
            String temp2 = "";
            foreach (Seyirci item in Seyirciler)
            {
                if (item.KoltukNo == position)
                {
                    temp2 = "Ad-Soyad: " + item.Ad + " " + item.Soyad + Environment.NewLine +
                            "TC Kimlik No: " + item.TCKimlikNo;
                }
            }
            return temp2;
        }
    }
}
