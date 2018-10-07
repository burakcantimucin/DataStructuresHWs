using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru2
{
    public class DaireselKuyruk : IKuyruk
    {
        private object[] Queue;
        private int front = -1;
        private int rear = -1;
        private int size = 0;
        private int count = 0;

        public DaireselKuyruk(int size)
        {
            this.size = size;
            Queue = new object[size];
        }

        public void Insert(Musteri m)
        {
            if (count == size) throw new Exception("Kuyruk doludur.");
            if (front == -1) front = 0;
            if (rear == size - 1)
            {
                rear = 0;
                Queue[rear] = m.IslemSuresi;
            }
            else Queue[++rear] = m.IslemSuresi;
            count++;
        }

        public object Remove()
        {
            if (IsEmpty()) throw new Exception("Kuyruk boştur.");
            object temp = Queue[front];
            Queue[front] = null;
            if (front == size - 1) front = 0;
            else front++;
            count--;
            return temp;
        }

        public bool IsEmpty()
        {
            return (count == 0);
        }

        public object Peek()
        {
            return Queue[front];
        }
    }
}
