using System;
using System.Collections;
using System.Collections.Generic;

/*
namespace Day2_9
{
    class Program
    {
        static void Main()
        {
            // Hashtable onj = new Hashtable();
            Dictionary<String, String> onj = new Dictionary<string, string>(); 

            onj.Add("김길동", "서울");
            onj.Add("홍길동", "광주");
            onj.Add("박길동", "부산");

            try
            {
                onj.Add("김길동", "서울");
            }
            catch
            {
                Console.WriteLine("키값 중복");
            }

            Console.WriteLine("for key = \"name\", value={0}", onj["홍길동"]);
            onj["박길동"] = "제주";

            Console.WriteLine("for key = \"name\", value={0}", onj["박길동"]);

            if(!onj.ContainsKey("최길동"))
            {
                onj.Add("최길동", "하와이");
                Console.WriteLine("value addeed for key = \"who\", value={0}", onj["최길동"]);

            }

            Console.WriteLine();

            //foreach(DictionaryEntry d in onj)
            foreach(KeyValuePair<string, string> d in onj)
            {
                Console.WriteLine("key = {0}, value = {1}", d.Key, d.Value);

            }

             SortedList s = new SortedList(onj);

            //  foreach(DictionaryEntry d in s )
            foreach (KeyValuePair<string, string> d in s)
            {
                Console.WriteLine("Key = {0}, value = {1}", d.Key, d.Value);
            }
        }
    }
}

    */
namespace ConsoleApplication6
{
    class Goods
    {
        public int goodsno { get; set; }
        public string gname { get; set; }
        public int danga { get; set; }

        public Goods(int goodsno, string gname, int danga)
        {
            this.goodsno = goodsno;
            this.gname = gname;
            this.danga = danga;
        }

        public override String ToString()
        {
            return "Goods [상품번호=" + goodsno + ", 상품명=" + gname + ", 단가="
                    + danga + "]";
        }
    }

    class Cart
    {
        public Goods goods { get; set; }
        public int count { get; set; }
        public int sum { get; set; }

        public Cart(Goods goods, int count)
        {
            this.goods = goods;
            this.count = count;
            sum = count * goods.danga; 
        }

        public override String ToString()
        {
            return "Cart :[Goods=" + goods + ", count=" + count + ", sum=" + sum
                    + "]";
        }
    }

    class CartTest
    {
        static void Main()
        {
            Goods Pen        = new Goods(1001, "볼펜", 2000);
            Goods Pencil     = new Goods(1002, "연필", 500);
            Goods strewbarry = new Goods(1003, "딸기", 6000);


            Cart cart1 = new Cart(Pen, 2);
            Cart cart2 = new Cart(Pencil, 3);
            Cart cart3 = new Cart(strewbarry, 2);

            Console.WriteLine(cart1.ToString());
            Console.WriteLine(cart2.ToString());
            Console.WriteLine(cart3.ToString());
        }
    }
}
