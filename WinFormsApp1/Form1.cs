namespace WinFormsApp1
{
    public partial class Form1 : Form
    { 
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        int a, b, c, d, e1;
        int c1, c2, c3, c4, c5;
        int credit = 100;
        static void Swap(ref int a, ref int b)
        {
            int aux = a;
            a = b;
            b = aux;
        }
        public void calc()
        {
            if (a > b) Swap(ref a, ref b);
            if (a > c) Swap(ref a, ref c);
            if (a > d) Swap(ref a, ref d);
            if (a > e1) Swap(ref a, ref e1);
            if (b > c) Swap(ref b, ref c);
            if (b > d) Swap(ref b, ref d);
            if (b > e1) Swap(ref b, ref e1);
            if (c > d) Swap(ref c, ref d);
            if (c > e1) Swap(ref c, ref e1);
            if (d > e1) Swap(ref d, ref e1);



            if (a == b && a == c && a == d && a == e1)
            {
                textBox2.Text = "FIVE OF A KIND";
                credit += 1100;
            }
            else if ((a == b && a == c & a == d) || (b == c && b == d && b == e1))
            {
                textBox2.Text = "FOUR OF A KIND";
                credit += 40;
            }
            else if ((a == b && a == c && d == e1) || (a == b && c == d && d == e1))
            {
                textBox2.Text = "FULL HOUSE";
                credit += 10;
            }
            else if ((a == b && a == c) || (b == c && b == d) || (c == d && c == e1))
            {
                textBox2.Text = "THREE OF A KIND";
                credit += 3;
            }
            else if ((a == b && (c == d || d == e1)) || (b == c && d == e1))
            {
                textBox2.Text = "TWO PAIRS";
                credit += 2;
            }
            else if (a == b || b == c || c == d || d == e1)
            {
                textBox2.Text = "ONE PAIR";
                credit += 1;
            }
            else
                textBox2.Text = "";
        }
        public void view()
        {
            textBox1.Text = a + " " + b + " " + c + " " + d + " " + e1;   
        }
        private void button1_Click(object sender, EventArgs e)
        {
          credit -= 1;
                init();
                view();
                calc();
                draw();
            
           // textBox2.Text = credit.ToString();
            
        }
        public void draw()
        {
           // try
            {

              //  pictureBox1.Image = Image.FromFile(@"..\..\Resurse\" + a.ToString("00") + c1.ToString("00") + ".png");
                textBox2.Text = @"..\..\Resurse\" + a.ToString("00") + c1.ToString("00") + ".png";
            }
           // catch {};
            try
            {
                pictureBox2.Image = Image.FromFile(@"..\..\Resurse\" + b.ToString("00") + c2.ToString("00") + ".png");
            }
            catch {};
            try
            {
                pictureBox3.Image = Image.FromFile(@"..\..\Resurse\" + c.ToString("00") + c3.ToString("00") + ".png");
            }
            catch {};
            try
            {
                pictureBox4.Image = Image.FromFile(@"..\..\Resurse\" + d.ToString("00") + c4.ToString("00") + ".png");
            }
            catch {};
            try
            {
                pictureBox5.Image = Image.FromFile(@"..\..\Resurse\" + e1.ToString("00") + c5.ToString("00") + ".png");
            }
            catch {};
            }
        public void init() {
            a = rnd.Next(2, 15);
            b = rnd.Next(2, 15);
            c = rnd.Next(2, 15);
            d = rnd.Next(2, 15);
            e1 = rnd.Next(2, 15);
            c1 = rnd.Next(4);
            c2 = rnd.Next(4);
            c3 = rnd.Next(4);
            c4 = rnd.Next(4);
            c5 = rnd.Next(4);

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            init();


        }
    }
}