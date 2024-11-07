using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Scientific_Calculator
{
    public partial class Scientific_Calculators : Form
    {
        double Result = 0;
        string Operation = "";
        bool Enter_Value = false;
        public Scientific_Calculators()
        {
            InitializeComponent();
        }

        private void Scientific_Calculators_Load(object sender, EventArgs e)
        {
            btnBackSpace.Visible = true;
            btnBinary.Visible = false;
            
            btnCLear.Visible = true;
            btnClearText.Visible = true;
            btnCos.Visible = false;
            btnCosh.Visible = false;
            btnDecimal.Visible = false;
            btnDivision.Visible = true;
            btnDot.Visible = true;
            btnEight.Visible = true;
            btnEquals.Visible = true;
            btnExp.Visible = false;
            btnFirst.Visible = true;
            btnFive.Visible = true;
            btnFour.Visible = true;
            btnHexaDecimal.Visible = false;
            btnInX.Visible = false;
            btnLog.Visible = false;
            btnMinus.Visible = true;
            btnMinusPlus.Visible = true;
            btnMod.Visible = false;
            btnMultiply.Visible = true;
            btnNine.Visible = true;
            btnNumberDevideByNumber.Visible = false;
            btnOctal.Visible = false;
            btnPercent.Visible = false;
            btnPlus.Visible = true;
            btnSeven.Visible = true;
            btnSin.Visible = false;
            btnSinh.Visible = false;
            btnSix.Visible = true;
            btnSqrt.Visible = false;
            btnThree.Visible = true;
            btnTwo.Visible = true;
            btnX.Visible = false;
            btnXPowerOfThree.Visible = false;
            btnXPowerOfTwo.Visible = false;
            btnZero.Visible = true;
            txtResult.Visible = true;
            btnTanjant.Visible = false;
            btnTanh.Visible = false;
            this.Width = 288;
            txtResult.Width = 254;
            GroupBoxTempreture.Visible = false;
            

        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnBackSpace.Visible = true;
            btnBinary.Visible = false;
            
            btnCLear.Visible = true;
            btnClearText.Visible = true;
            btnCos.Visible = false;
            btnCosh.Visible = false;
            btnDecimal.Visible = false;
            btnDivision.Visible = true;
            btnDot.Visible = true;
            btnEight.Visible = true;
            btnEquals.Visible = true;
            btnExp.Visible = false;
            btnFirst.Visible = true;
            btnFive.Visible = true;
            btnFour.Visible = true;
            btnHexaDecimal.Visible = false;
            btnInX.Visible = false;
            btnLog.Visible = false;
            btnMinus.Visible = true;
            btnMinusPlus.Visible = true;
            btnMod.Visible = false;
            btnMultiply.Visible = true;
            btnNine.Visible = true;
            btnNumberDevideByNumber.Visible = false;
            btnOctal.Visible = false;
            btnPercent.Visible = false;
            btnPlus.Visible = true;
            btnSeven.Visible = true;
            btnSin.Visible = false;
            btnSinh.Visible = false;
            btnSix.Visible = true;
            btnSqrt.Visible = false;
            btnThree.Visible = true;
            btnTwo.Visible = true;
            btnX.Visible = false;
            btnXPowerOfThree.Visible = false;
            btnXPowerOfTwo.Visible = false;
            btnZero.Visible = true;
            txtResult.Visible = true;
            btnTanjant.Visible = false;
            btnTanh.Visible = false;
            this.Width = 288;
            txtResult.Width = 254;
            GroupBoxTempreture.Visible = false;
            
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnBackSpace.Visible = true;
            btnBinary.Visible = true;
            
            btnCLear.Visible = true;
            btnClearText.Visible = true;
            btnCos.Visible = true;
            btnCosh.Visible = true;
            btnDecimal.Visible = true;
            btnDivision.Visible = true;
            btnDot.Visible = true;
            btnEight.Visible = true;
            btnEquals.Visible = true;
            btnEquals.Visible = true;
            btnExp.Visible = true;
            btnFirst.Visible = true;
            btnFive.Visible = true;
            btnFour.Visible = true;
            btnHexaDecimal.Visible = true;
            btnInX.Visible = true;
            btnLog.Visible = true;
            btnMinus.Visible = true;
            btnMinusPlus.Visible = true;
            btnMod.Visible = true;
            btnMultiply.Visible = true;
            btnNine.Visible = true;
            btnNumberDevideByNumber.Visible = true;
            btnOctal.Visible = true;
            btnPercent.Visible = true;
            btnPlus.Visible = true;
            btnSeven.Visible = true;
            btnSin.Visible = true;
            btnSinh.Visible = true;
            btnSix.Visible = true;
            btnSqrt.Visible = true;
            btnThree.Visible = true;
            btnTwo.Visible = true;
            btnX.Visible = true;
            btnXPowerOfThree.Visible = true;
            btnXPowerOfTwo.Visible = true;
            btnZero.Visible = true;
            txtResult.Visible = true;
            btnTanjant.Visible = true;
            btnTanh.Visible = true;
            this.Width = 510;
            txtResult.Width = 472;
            GroupBoxTempreture.Visible = false;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            double sh = Double.Parse(txtResult.Text);
            txtResult.Text = System.Convert.ToString("Sinh " + "(" + (txtResult.Text) + ")");
            sh = Math.Sinh(sh);
            txtResult.Text = System.Convert.ToString(sh);
            OverWriteNumbers(sender);
        }

        private void tepretureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnBackSpace.Visible = false;
            btnBinary.Visible = false;
            
            btnCLear.Visible = false;
            btnClearText.Visible = false;
            btnCos.Visible = false;
            btnCosh.Visible = false;
            btnDecimal.Visible = false;
            btnDivision.Visible = false;
            btnDot.Visible = false;
            btnEight.Visible = false;
            btnEquals.Visible = false;
            btnEquals.Visible = false;
            btnExp.Visible = false;
            btnFirst.Visible = false;
            btnFive.Visible = false;
            btnFour.Visible = false;
            btnHexaDecimal.Visible = false;
            btnInX.Visible = false;
            btnLog.Visible = false;
            btnMinus.Visible = false;
            btnMinusPlus.Visible = false;
            btnMod.Visible = false;
            btnMultiply.Visible = false;
            btnNine.Visible = false;
            btnNumberDevideByNumber.Visible = false;
            btnOctal.Visible = false;
            btnPercent.Visible = false;
            btnPlus.Visible = false;
            btnSeven.Visible = false;
            btnSin.Visible = false;
            btnSinh.Visible = false;
            btnSix.Visible = false;
            btnSqrt.Visible = false;
            btnThree.Visible = false;
            btnTwo.Visible = false;
            btnX.Visible = false;
            btnXPowerOfThree.Visible = false;
            btnXPowerOfTwo.Visible = false;
            btnZero.Visible = false;
            txtResult.Visible = false;
            btnTanjant.Visible = false;
            btnTanh.Visible = false;
            this.Width = 356;
            GroupBoxTempreture.Visible = true;
            GroupBoxTempreture.Location=new Point(10,33);
            lblOperationOf.Text = "";
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if ((txtResult.Text == "0") || (Enter_Value))
                txtResult.Text = "";
            Enter_Value = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!txtResult.Text.Contains("."))
                    txtResult.Text = txtResult.Text + button.Text;
            }
            else
            {
                txtResult.Text = txtResult.Text + button.Text;
            }
        }

        private void btnCLear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Length > 0)
            {
                txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1, 1);
            }
            if (txtResult.Text == "")
            {
                txtResult.Text = "0";
;            }
        }

        private void Arithmetic_Operator(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (Result != 0)
            {
                btnEquals.PerformClick();
                Enter_Value = true;
                Operation = button.Text;
                lblOperationOf.Text = System.Convert.ToString(Result) + " " + Operation;
            }
            else
            {
                Operation = button.Text;
                Result = Double.Parse(txtResult.Text);
                Enter_Value = true;
                lblOperationOf.Text = System.Convert.ToString(Result) + " " + Operation;
            }
        }
        void OverWriteNumbers(object sender)
        {
            //At this stage if Equal Button clicked we want to over write selected button text into Textbox
            Button button = (Button)sender;
            Operation = button.Text;
            Result = Double.Parse(txtResult.Text);
            Enter_Value = true;
            lblOperationOf.Text = System.Convert.ToString(Result) + " " + Operation;
            // After Every clicks of Equals we should clear the label Result
            lblOperationOf.Text = "";
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            try
            {
                lblOperationOf.Text = "";
                switch (Operation)
                {
                    case "+":
                        txtResult.Text = (Result + Double.Parse(txtResult.Text)).ToString();
                        break;
                    case "-":
                        txtResult.Text = (Result - Double.Parse(txtResult.Text)).ToString();
                        break;
                    case "X":
                        txtResult.Text = (Result * Double.Parse(txtResult.Text)).ToString();
                        break;
                    case "/":
                        txtResult.Text = (Result / Double.Parse(txtResult.Text)).ToString();
                        break;
                    case "Mod":
                        txtResult.Text = (Result % Double.Parse(txtResult.Text)).ToString();
                        break;
                    case "Exp":
                        double i = Double.Parse(txtResult.Text);
                        double q;
                        q = (Result);
                        txtResult.Text = Math.Exp(i * Math.Log(q * 4)).ToString();
                        break;
                }
                Result = Double.Parse(txtResult.Text);
                Operation = "";
                OverWriteNumbers(sender);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            txtResult.Text = "3.141592653589976323";
            OverWriteNumbers(sender);
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            double ilog = Double.Parse(txtResult.Text);
            lblOperationOf.Text = System.Convert.ToString("log " + "(" + (txtResult.Text) + ")");
            ilog = Math.Log10(ilog);
            txtResult.Text = System.Convert.ToString(ilog);
            OverWriteNumbers(sender);
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double sq = Double.Parse(txtResult.Text);
            lblOperationOf.Text = System.Convert.ToString("Sqrt " + "(" + (txtResult.Text) + ")");
            sq = Math.Sqrt(sq);
            txtResult.Text = System.Convert.ToString(sq);
            OverWriteNumbers(sender);
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            double sh = Double.Parse(txtResult.Text);
            txtResult.Text = System.Convert.ToString("Sinh " + "(" + (txtResult.Text) + ")");
            sh = Math.Sin(sh);
            txtResult.Text = System.Convert.ToString(sh);
            OverWriteNumbers(sender);
        }

        private void btnCosh_Click(object sender, EventArgs e)
        {
            double cosinh = Double.Parse(txtResult.Text);
            txtResult.Text = System.Convert.ToString("Cosh " + "(" + (txtResult.Text) + ")");
            cosinh = Math.Cosh(cosinh);
            txtResult.Text = System.Convert.ToString(cosinh);
            OverWriteNumbers(sender);
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            double cosin = Double.Parse(txtResult.Text);
            txtResult.Text = System.Convert.ToString("Cos " + "(" + (txtResult.Text) + ")");
            cosin = Math.Cos(cosin);
            txtResult.Text = System.Convert.ToString(cosin);
            OverWriteNumbers(sender);
        }

        private void btnTanjant_Click(object sender, EventArgs e)
        {
            double Tanjant = Double.Parse(txtResult.Text);
            lblOperationOf.Text = System.Convert.ToString("Tan " + "(" + (txtResult.Text) + ")");
            Tanjant = Math.Tan(Tanjant);
            txtResult.Text = System.Convert.ToString(Tanjant);
            OverWriteNumbers(sender);
        }

        private void btnTanh_Click(object sender, EventArgs e)
        {
            double Tanjanth = Double.Parse(txtResult.Text);
            txtResult.Text = System.Convert.ToString("Tanh " + "(" + (txtResult.Text) + ")");
            Tanjanth = Math.Tanh(Tanjanth);
            txtResult.Text = System.Convert.ToString(Tanjanth);
        }

        private void btnBinary_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtResult.Text);
            txtResult.Text = System.Convert.ToString(a,2);
            OverWriteNumbers(sender);

        }

        private void btnOctal_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtResult.Text);
            txtResult.Text = System.Convert.ToString(a, 8);
            OverWriteNumbers(sender);
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtResult.Text);
            txtResult.Text = System.Convert.ToString(a, 10);
            OverWriteNumbers(sender);
        }

        private void btnHexaDecimal_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtResult.Text);
            txtResult.Text = System.Convert.ToString(a, 16);
            OverWriteNumbers(sender);
        }

        private void btnXPowerOfTwo_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(txtResult.Text) * Convert.ToDouble(txtResult.Text);
            txtResult.Text = System.Convert.ToString(a);
            OverWriteNumbers(sender);
        }

        private void btnXPowerOfThree_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(txtResult.Text) * Convert.ToDouble(txtResult.Text)* Convert.ToDouble(txtResult.Text);
            txtResult.Text = System.Convert.ToString(a);
            OverWriteNumbers(sender);
        }

        private void btnNumberDevideByNumber_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(1.0 / Convert.ToDouble(txtResult.Text));
            txtResult.Text = System.Convert.ToString(a);
            OverWriteNumbers(sender);
        }

        private void btnInX_Click(object sender, EventArgs e)
        {
            double ilog = Double.Parse(txtResult.Text);
            txtResult.Text = System.Convert.ToString("log " + "(" + (txtResult.Text) + ")");
            ilog = Math.Log(ilog);
            lblOperationOf.Text = System.Convert.ToString(ilog);
            OverWriteNumbers(sender);
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(txtResult.Text) / Convert.ToDouble(100);
            txtResult.Text = System.Convert.ToString(a);
            OverWriteNumbers(sender);

        }

        private void btnClearText_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            lblOperationOf.Text = "";
        }

        private void btnBS_Click(object sender, EventArgs e)
        {

        }
    }
}
