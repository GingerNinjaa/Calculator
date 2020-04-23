using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class MainBoard : Form
    {
        public MainBoard()
        {
            InitializeComponent();
        }

        public static double Evaluate(string expression)
        {
            DataTable table = new DataTable();
            table.Columns.Add("expression", typeof(string), expression);
            DataRow row = table.NewRow();
            table.Rows.Add(row);
            return double.Parse((string)row["expression"]);
        }

        string GetRandomNums(int Length)
        {


            string tmp = "";
            Random ran = new Random();
            for (int i = 0; i < Length; i++)
            {
                tmp += ran.Next(0, 10);
            }
            return tmp;
        }

        string Expression = "";

        public double LastAns { get; private set; }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton18_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            lblExpression.Text = Expression = "";
            lblAns.Text = "0";
        }

        int i = 0;

        private void TimeAnimate_Tick(object sender, EventArgs e)
        {
            

            if (i < 25)
            {
                lblAns.Text = GetRandomNums(this.LastAns.ToString().Length);
                i++;
            }
            else
            {
                i = 0;
                lblAns.Text = LastAns.ToString();
                TimeAnimate.Stop();
            }

        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            LastAns = Evaluate(Expression);
            TimeAnimate.Start();
        }

        private void bunifuImageButton9_Click(object sender, EventArgs e)
        {
            try
            {
                lblExpression.Text = Expression = Expression.Substring(0, Expression.Length - 1);

            }
            catch (Exception)
            {

            }

        }

        private void btnNumbers_Click(object sender, EventArgs e)
        {
            lblAns.Text = 0.ToString();
            lblExpression.Text = (Expression += ((Control)sender).Tag.ToString());
        }
    }
}
