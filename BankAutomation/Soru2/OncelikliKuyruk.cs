using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru2
{
    public class OncelikliKuyruk : IKuyruk
    {
        private object[] Queue;
        private int front = -1;
        private int rear = 0;
        private int size = 0;
        private int count = 0;

        public OncelikliKuyruk(int size)
        {
            this.size = size;
            Queue = new object[size];
        }
        public void Insert(Musteri m)
        {
            if (count == size) throw new Exception("Kuyruk doludur.");
            if (IsEmpty())
            {
                front++;
                Queue[front] = m.IslemSuresi;
                count++;
            }
            else
            {
                if (front == -1)
                {
                    front = 0;
                    Queue[front] = m.IslemSuresi;
                    count++;
                }
                else
                {
                    int i;
                    int tmp = (int)m.IslemSuresi;
                    for (i = count - 1; i >= 0; i--)
                    {
                        if (tmp < (int)Queue[i])
                            Queue[i + 1] = Queue[i];
                        else
                            break;
                    }
                    Queue[i + 1] = m.IslemSuresi;
                    front++;
                    count++;
                }
            }
        }

        public bool IsEmpty()
        {
            return (count == 0);
        }

        public object Peek()
        {
            return Queue[front];
        }

        public object Remove()
        {
            if ((this.IsEmpty())) throw new Exception("Kuyruk boştur.");
            Object tmp = Queue[front];
            Queue[front] = null;
            front--;
            count--;
            return tmp;
        }
    }
}
