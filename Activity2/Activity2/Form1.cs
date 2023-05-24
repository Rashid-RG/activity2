using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity2
{
    public partial class Form1 : Form
    {
        private int MarkSubject1;
        private int MarkSubject2;
        private int result;


        private int intValidation;

        private bool bSubject1 =false;
        private bool bSubject2 =false;
        private bool bresult =false;

        private ErrorProvider errorProvider;




        public Form1()
        {
            InitializeComponent();

            MarkSubject1= 0;
            MarkSubject2= 0;    

            txtAvarage.ReadOnly= true;
            errorProvider= new ErrorProvider();
        }

        private void txtSubject1_Validating(object sender, CancelEventArgs e)
        {
            errorProvider.SetError(txtSubject1,"");
            bSubject1= false;
            if (!int.TryParse(txtSubject1.Text, out intValidation)) 
            { bSubject1= true;
                errorProvider.SetError(txtSubject1, "Please Fill This Required Field");
            }

        }

        private void txt_Subject2_Validating(object sender, CancelEventArgs e)
        {
            errorProvider.SetError(txt_Subject2, "");
            bSubject2 = false;
            if (!int.TryParse(txt_Subject2.Text, out intValidation))
            {
                bSubject2 = true;
                errorProvider.SetError(txt_Subject2, "Please Fill This Required Field");
            }
        }

        private void txtAvarage_Validating(object sender, CancelEventArgs e)
        {
            errorProvider.SetError(txtAvarage, "");
            bresult = false;
            if (!int.TryParse(txtAvarage.Text, out intValidation))
            {
                bresult = true;
                errorProvider.SetError(txtAvarage, "Please Fill This Required Field");
            }
        }

        private void btn_Sub_Click(object sender, EventArgs e)
        {
            try
            {
                if(bSubject1==false && bSubject2==false) {
                    MarkSubject1 = int.Parse(txtSubject1.Text);
                    MarkSubject2 = int.Parse(txt_Subject2.Text);
                    result = ((MarkSubject1 + MarkSubject2) /2 );
                    txtAvarage.Text= result.ToString();
                    if (result>=0 && result<=39) { label.Text = "F"; }
                    if (result >40 && result <= 64) { label.Text = "C"; }
                    if (result > 65 && result <= 74) { label.Text = "B"; }
                    if (result >= 75 && result <= 100) { label.Text = "A"; }
                }
            }
            catch { }
        }
    }
}
