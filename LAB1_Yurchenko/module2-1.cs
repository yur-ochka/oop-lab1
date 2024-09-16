using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LAB1_Yurchenko
{
    class module2_1 : Form
    {
        private Form1 parentForm;

        public module2_1(Form1 form)
        {
            parentForm = form;

            this.Text = "Window 3";

            Label messageLabel = new Label();
            messageLabel.Text = "Choose something:";
            messageLabel.AutoSize = true;
            messageLabel.Location = new System.Drawing.Point(50, 20);
            this.Controls.Add(messageLabel);

            ListBox listbox = new ListBox();
            for (int i = 31; i < 35; i++)
                listbox.Items.Add("IM-" + i);
            listbox.Location = new System.Drawing.Point(20, 60);
            this.Controls.Add(listbox);

            Button customOkButton = new Button();
            customOkButton.Text = "OK";
            customOkButton.Location = new System.Drawing.Point(20, 160);
            customOkButton.Click += (sender, e) => { if (listbox.SelectedItem != null) { parentForm.label1.Text = listbox.SelectedItem.ToString(); this.Close(); } };
            this.Controls.Add(customOkButton);

            Button customCancelButton = new Button();
            customCancelButton.Text = "Abort";
            customCancelButton.Location = new System.Drawing.Point(150, 160);
            customCancelButton.Click += (sender, e) => { this.Close(); };
            this.Controls.Add(customCancelButton);
        }

        public static void ShowDialogBox(Form1 form)
        {
            module2_1 dialog = new module2_1(form);
            dialog.StartPosition = FormStartPosition.CenterScreen;
            dialog.ShowDialog();
        }
    }
}
