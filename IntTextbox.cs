﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReplayEditor
{
    public class IntTextBox : TextBox
    {
        public int Value
        {
            get { return this.value; }
            set
            {
                this.value = value;
                this.Text = value.ToString();
            }
        }
        private int value;
        private string lastValidatedText;

        public IntTextBox()
        {
            this.lastValidatedText = "0";
            //this.TextChanged += OnChange;
            this.LostFocus += OnChange;
        }

        private void OnChange(object sender, EventArgs e)
        {
            this.Validate();
        }

        private bool Validate()
        {
            try
            {
                this.value = Convert.ToInt32(this.Text);
            }
            catch (Exception)
            {
                this.Text = this.lastValidatedText;
                return false;
            }
            this.Text = this.value.ToString();
            this.lastValidatedText = this.Text;
            return true;
        }

        public byte[] ToByteArray()
        {
            return BitConverter.GetBytes(this.value);
        }
    }
}
