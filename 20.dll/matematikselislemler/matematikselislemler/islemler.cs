namespace matematikselislemler
{
    public class islemler
    {
        public int topla(int x, int y)
        {
            return x + y;
        }

        public int cikart (int x, int y)
        {
            return x - y;
        }

        public int bol (int x, int y)
        {
            return x / y;
        }

        public int carp(int x, int y)
        {
            return x * y;
        }

        public void ozelmethod1()
        {
            Console.WriteLine("bu method dll referans edildiği zaman çalışmayacaktır");
        }
    }
}
