using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorDLL
{
    public partial class Form1 : Form
    {

        //Calling dll 
        public const string SumFunctionsDLL = @"..\..\..\Debug\SumFunction.dll";

        //Calling AddNumbers Method from dll
        [DllImport(SumFunctionsDLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern int AddNumbers(int a, int b);

        //Calling MinusNumbers Method from dll
        [DllImport(SumFunctionsDLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern int MinusNumbers(int a, int b);

        //Calling MultiplyNumbers Method from dll
        [DllImport(SumFunctionsDLL, CallingConvention = CallingConvention.Cdecl)]

        public static extern int MultiplyNumbers(int a, int b);

        //Calling DivisionNumbers Method from dll
        [DllImport(SumFunctionsDLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern int DivisionNumbers(int a, int b);


      

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);

            int sum = AddNumbers(a, b);

            label1.Text = ""+sum;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);

            int sum = MinusNumbers(a, b);

            label1.Text = "" + sum;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);

            int sum = MultiplyNumbers(a, b);
            label1.Text = "" + sum;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);

            int sum = DivisionNumbers(a, b);
            label1.Text = "" + sum;
        }
    }
}
