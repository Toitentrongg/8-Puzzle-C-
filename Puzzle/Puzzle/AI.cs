using Priority_Queue;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using static System.Windows.Forms.AxHost;

namespace Puzzle
{
    public class AI
    {
        public static List<int> KQ = new List<int>() { 1, 2, 3, 8, 0, 4, 7, 6, 5 };//{ 1, 2, 3, 4, 5, 6, 7, 8, 0 };//;
        public static bool WIN(List<int> list)
        {
            return list.SequenceEqual(KQ);//So sánh list đang xét với list KQ
        }
        public static int TinhH (List<int> list)
        {
            int count = 0;
            for (int i = 0; i < list.Count; i++) 
            {
                if (list[i] - KQ[i] != 0)
                {
                    count++;
                }
            }
            return count;
        }
        public static void Swap(List<int> list, int index1, int index2)
        {
            int temp = list[index1];
            list[index1] = list[index2];
            list[index2] = temp;
        }

        static bool Len(List<int> list) 
        {
            int temp = list.IndexOf(0);
            if (temp - 3 < 0)
            {
                return false;
            }
            return true;
            
        }
        static bool Xuong(List<int> list) 
        {
            int temp = list.IndexOf(0);
            if (temp + 3 > 8)
            {
                return false;
            }
            return true;
        }
        static bool Trai(List<int> list) 
        {
            int temp = list.IndexOf(0);
            if (temp == 0 || temp == 3 || temp == 6)
            {
                return false;
            }
            return true;
        }
        static bool Phai (List<int> list) 
        {
            int temp = list.IndexOf(0);
            if (temp == 2 || temp == 5 || temp == 8)
            {
                return false;
            }
            return true;
        }
        public static List<List<int>> DiChuyen(List<int> listBanDau)
        {
            List<List<int>> CacBuocDiChuyen = new List<List<int>>();
            
            int ViTri0 = listBanDau.IndexOf(0);
            if (Phai(listBanDau))
            {
                List<int> lstTemp = listBanDau.ToList(); 
                Swap(lstTemp, ViTri0, ViTri0 + 1);
                CacBuocDiChuyen.Add(lstTemp);
            }
            if (Xuong(listBanDau))
            {
                List<int> lstTemp = listBanDau.ToList(); 
                Swap(lstTemp, ViTri0, ViTri0 + 3);
                CacBuocDiChuyen.Add(lstTemp);
            }
            if (Trai(listBanDau))
            {
                List<int> lstTemp = listBanDau.ToList(); 
                Swap(lstTemp, ViTri0, ViTri0 - 1);
                CacBuocDiChuyen.Add(lstTemp);
            }
            if (Len(listBanDau))
            {
                List<int> lstTemp = listBanDau.ToList();
                Swap(lstTemp, ViTri0, ViTri0 -3);
                CacBuocDiChuyen.Add(lstTemp);
            }
            return CacBuocDiChuyen;
        }
        static bool Check(List<List<int>> list1, List<int> list2)
         //HÀM CHECK XEM THỬ LIST ĐÓ ĐÃ ĐƯỢC DUYỆT HAY CHƯA
        {
            foreach (var item in list1)
            {
                if (item.SequenceEqual(list2))
                {
                    return true;
                }
            }
            return false;
        }
        public static List<List<int>> Astar(List<int> lstrstart)
        {
            Dictionary<List<int>, List<int>> DuongDi = new Dictionary<List<int>, List<int>>();
            Dictionary<List<int>, int> GChaCon = new Dictionary<List<int>, int>();

            List<List<int>> temp1 = new List<List<int>>();
            List<List<int>> CacListDaDuyet = new List<List<int>>();
            CacListDaDuyet.Add(lstrstart);
            int count = 0;
            SimplePriorityQueue<List<int>> A = new SimplePriorityQueue<List<int>>();
            A.Enqueue(lstrstart, 0);// F ban đầu = 0
            temp1.Add(lstrstart);
            GChaCon[lstrstart] = 0; //G cua diem bat dau la 0
            int demm = 0;
            while (A.Count > 0)
            {
                List<int> temp = A.Dequeue();
                //Console.WriteLine($"{string.Join(", ", temp)} --- {demm}" );
                if (WIN(temp))
                {
                    List<List<int>> duongdi = new List<List<int>>();
                    while (DuongDi.ContainsKey(temp))
                    {
                        duongdi.Add(temp);
                        temp = DuongDi[temp];
                    }
                    duongdi.Add(lstrstart);
                    duongdi.Reverse();
                    return duongdi;
                }
                List<List<int>> CacBuocDiChuyen = DiChuyen(temp);
                count++;
                foreach(List<int> i in CacBuocDiChuyen)
                {
                    if (Check(CacListDaDuyet, i) == false && Check(temp1,i)== false)
                    {
                        CacListDaDuyet.Add(i);
                        DuongDi[i] = temp;
                        GChaCon[i] = (GChaCon[temp] +1);
                        int H = TinhH(i);
                        A.Enqueue(i, GChaCon[i] + H);
                        temp1.Add(i);
                    }
                    
                }
                
            }
            Console.Write(CacListDaDuyet.Count);
            return null;
        }
        public static bool HamKTtraHopLe(List<int> list)
        {
            int count = 0;
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i] > list[j] && list[j] != 0)
                    {
                        count++;
                    }
                }
            }
            if (count % 2 == 0)
                return true; // trả về là số chẵn
            else
                return false; // trả về là số lẻ
        }
    }
}
