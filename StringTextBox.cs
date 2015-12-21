using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReplayEditor
{
    public class StringTextBox : TextBox
    {
        private byte[] bytes;

        public StringTextBox()
        {
            this.UpdateBytes();
            this.LostFocus += OnChange;
        }

        private void OnChange(object sender, EventArgs e)
        {
            this.UpdateBytes();
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            this.UpdateBytes();
        }

        private void UpdateBytes()
        {
            List<byte> list = new List<byte>();
            list.Add(0x0b);
            list.AddRange(MainForm.EncodeULEB(this.Text.Length));
            list.AddRange(MainForm.Encoding.GetBytes(this.Text));
            this.bytes = list.ToArray();
        }

        public byte[] ToByteArray()
        {
            return this.bytes;
        }
    }
}
