using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    enum Kind { CM, M, KM, In, Ft, Yard};
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void caculateAnswer(Kind _kind, double _value)
        {
            if (_kind != Kind.CM)
                txtCM.Text = string.Format("{0:0.##########}", _value);
            if (_kind != Kind.M)
                txtM.Text = string.Format("{0:0.##########}", _value / 100);
            if (_kind != Kind.KM)
                txtKM.Text = string.Format("{0:0.##########}", _value / 100000);
            if (_kind != Kind.In)
                txtIn.Text = string.Format("{0:0.##########}", _value / 2.54);
            if (_kind != Kind.Ft)
                txtFt.Text = string.Format("{0:0.##########}", _value / 30.48);
            if (_kind != Kind.Yard)
                txtYard.Text = string.Format("{0:0.##########}", _value / 91.44);
        }

        string strInput;
        double douOutput;

        private void txtCM_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtCM.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(Kind.CM, douOutput);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtCM.Text = "";
            }
        }

        private void txtM_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtM.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(Kind.M, douOutput * 100);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtM.Text = "";
            }
        }

        private void txtKM_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtKM.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(Kind.KM, douOutput * 100000);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtKM.Text = "";
            }
        }

        private void txtIn_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtIn.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(Kind.In, douOutput * 2.54);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtIn.Text = "";
            }
        }

        private void txtFt_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtFt.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(Kind.Ft, douOutput * 30.48);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtFt.Text = "";
            }
        }

        private void txtYard_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtYard.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(Kind.Yard, douOutput * 91.44);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtYard.Text = "";
            }
        }

        private void btnAllClear_Click(object sender, EventArgs e)
        {
            txtCM.Text = "";
            txtM.Text = "";
            txtKM.Text = "";
            txtIn.Text = "";
            txtFt.Text = "";
            txtYard.Text = "";
        }
    }
}
