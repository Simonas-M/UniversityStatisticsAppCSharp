using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Aspose.OCR;

namespace UniversitySQL
{
    partial class EditWindow
    {
        private void AddOnClickEventsOnTextBoxes()
        {
            var textBoxes = GetTextBoxes();
            foreach (TextBox item in textBoxes)
            {
                if (item.Text == "Telefono Nr.")
                {
                    item.Tag = item.Text;
                    item.Click += TelNumberTextBox_Click;
                    item.KeyPress += TelNumberTextBox_KeyPress;
                    item.LostFocus += TelNumberTextBox_LostFocus;
                    continue;
                }
                item.Tag = item.Text;
                item.Click += TextBox_Click;
                item.LostFocus += TextBox_LostFocus;
                item.MouseDoubleClick += TextBox_DoubleClick;
            }
        }

        private void TextBox_Click(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;
            box.Text = "";
            box.ForeColor = System.Drawing.Color.Black;
        }

        private void TextBox_LostFocus(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;
            if (String.IsNullOrEmpty(box.Text))
            {
                box.Text = (string)box.Tag;
                box.ForeColor = System.Drawing.Color.Gray;
            }

        }

        private void TextBox_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog fileSelect = new OpenFileDialog();
            fileSelect.Multiselect = false;
            fileSelect.Title = "Pasirinkite nuotrauka su tekstu";
            fileSelect.ShowDialog();
            if (!string.IsNullOrEmpty(fileSelect.FileName))
            {
                if (fileSelect.SafeFileName.EndsWith(".png") || fileSelect.SafeFileName.EndsWith(".bmp") || fileSelect.SafeFileName.EndsWith(".jpg"))
                {
                    using (OcrEngine ocr = new OcrEngine())
                    {
                        ocr.Image = ImageStream.FromFile(fileSelect.FileName);
                        ocr.Process();
                        ((TextBox)sender).Text = ocr.Text.ToString();
                        ((TextBox)sender).ForeColor = System.Drawing.Color.Black;
                    }
                }
                else
                    MessageBox.Show("Prašome pasirinkti paveikslėlį [png, jpg, bmp]");
            }
        }

        private void TelNumberTextBox_Click(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;
            box.ForeColor = System.Drawing.Color.Black;
            box.Text = "+370_______";
            box.SelectionStart = box.Text.IndexOf('_');
        }

        private void TelNumberTextBox_LostFocus(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;
            if (box.Text == "+370_______")
                box.Text = "Telefono Nr.";
        }

        private void TelNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox box = (TextBox)sender;
            char pressedKey = e.KeyChar;
            if(new System.Text.RegularExpressions.Regex(@"[0-9]").IsMatch(pressedKey.ToString()))
            {
                if (box.Text.Contains('_'))
                {
                    int indexOfX = box.Text.IndexOf('_');
                    box.Text = box.Text.ReplaceAt(indexOfX, pressedKey);
                }
            }
            else if(pressedKey == (char)8)
            {
                int xCount = box.Text.Count(s => s == '_');
                if (xCount < 7 && xCount > 0)
                {
                    int indexOfX = box.Text.IndexOf('_');
                    box.Text = box.Text.ReplaceAt(indexOfX-1, '_');
                }
                else
                {
                    box.Text = box.Text.ReplaceAt(box.Text.Length-1, '_');
                }
            }
        }

        public List<TextBox> GetTextBoxes()
        {
            var textBoxes = new List<TextBox>();
            foreach (Control a in tabControl1.Controls)
            {
                foreach (Control b in a.Controls)
                {
                    if (b is TextBox)
                    {
                        textBoxes.Add((TextBox)b);
                    }
                }
            }
            return textBoxes;
        }

    }
}
