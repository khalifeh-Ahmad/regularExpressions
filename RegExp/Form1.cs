using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegExp
{
    public partial class Form1 : Form
    {
        Regex rx;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            Regex rx = new Regex(txtPattern.Text);
            //only Arabic and English alphabet and numbers and( . - _)
            // rx = new Regex(@"^[\u0600-\u06FF]|[a-zA-Z0-9-_]|[*]+$");
            bool result = rx.IsMatch(txtInput.Text);
            lblrslt.Text = result.ToString();
        }

        private void btncheckNumber_Click(object sender, EventArgs e)
        {
             rx = new Regex("\\(?\\d{3}\\)?-? *\\d{3}-? *-?\\d{4}");
            bool result = rx.IsMatch(txtnumber.Text);
            lblNumber.Text = result.ToString();
        }
        //@"^(0011)(([ ][0-9]{3}){3})$" validation for phone  Number
        //@"^([0-9]{2})\/([0-9]{2})\/([0-9]{4})$" validation for date
        //@"^(http://www\.)([\w]+)\.([\w]+)$" validation for website
        //@"^([\w]+)@([\w]+)\.([\w]+)$" validation for email
        private void btnMail_Click(object sender, EventArgs e)
        {
             rx = new Regex(@"^[a-z0-9](\\.?[a-z0-9_-]){0,}@[a-z0-9-]+\\.([a-z]{1,6}\\.)?[a-z]{2,6}$");
            bool result = rx.IsMatch(txtmail.Text);
            lblMail.Text = result.ToString();
        }

        private void txtInput_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            Regex rx = new Regex(txtPattern.Text);
            //only Arabic and English alphabet and numbers and( . - _)
            // rx = new Regex(@"^[\u0600-\u06FF]|[a-zA-Z0-9-_]|[*]+$");
            bool result = rx.IsMatch(txtInput.Text);
            lblrslt.Text = result.ToString();
        }
    }
}
