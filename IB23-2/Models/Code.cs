using System.Data.Entity;

namespace IB23_2.Models
{
    public class Code
    {
        public int Id { get; set; }
        public int Pos1 { get; set; }
        public int Pos2 { get; set; }
        public int Pos3 { get; set; }
        public int Pos4 { get; set; }
        public int Pos5 { get; set; }
        public int EmployeeId { get; set; }
        public int SessionId { get; set; }

        public Code(int pos1, int pos2, int pos3, int pos4, int pos5)
        {
            Pos1 = pos1;
            Pos2 = pos2;
            Pos3 = pos3;
            Pos4 = pos4;
            Pos5 = pos5;
            EmployeeId = GetEmployee(pos1, pos2, pos3);
        }

        public Code() { }

        public int GetEmployee(int pos1, int pos2, int pos3)
        {
            if (pos1 == 1 && pos2 == 1 && pos3 == 2) return 1;
            if (pos1 == 3 && pos2 == 3 && pos3 == 3) return 2;
            if (pos1 == 2 && pos2 == 1 && pos3 == 2) return 3;
            if (pos1 == 1 && pos2 == 1 && pos3 == 1) return 4;
            if (pos1 == 2 && pos2 == 2 && pos3 == 2) return 5;
            if (pos1 == 2 && pos2 == 1 && pos3 == 3) return 6;
            if (pos1 == 2 && pos2 == 1 && pos3 == 1) return 7;
            if (pos1 == 3 && pos2 == 3 && pos3 == 1) return 8;
            if (pos1 == 3 && pos2 == 1 && pos3 == 2) return 9;
            if (pos1 == 3 && pos2 == 2 && pos3 == 1) return 10;
            return 11;
            /* 
                1 Механики = 1, // rrg
                2 Знахари, // bbb
                3 Пилоты, // grg
                4 ПищевойПерсонал, // rrr
                5 Мусорщики, // ggg
                6 Связисты, // grb
                7 Охранники, // grr
                8 Гости, // bbr
                9 ПерваяГруппаНаучников, // brg
                10 ВтораяГруппаНаучников, // bgr
                11 UnknownError // rgb*/                 
        }
    }

}