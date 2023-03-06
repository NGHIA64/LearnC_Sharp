using System;
namespace week_2
{
    class thuCung {
        private int chan;
        public thuCung() { }
        public thuCung(int chan)
        {
            this.chan = chan;
        }
        public int getChan() { return chan; }
        public void nhap()
        {
            chan = int.Parse(Console.ReadLine());
        }
        public void hienThi()
        {
            Console.WriteLine(chan);
        }
    }
    class dog:thuCung
    {
        private string ten;
        public dog() { }

        public dog(string ten) { ten = this.ten; }

        public dog(int chan) : base(chan)
        {
        }
    }

}