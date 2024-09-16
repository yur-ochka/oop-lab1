using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB1_Yurchenko
{
    class module1_2:Form
    {
        public module1_2()
        {
            this.Text = "Window 2";

            Label messageLabel = new Label();
            messageLabel.Text = "What you wanna do?";
            messageLabel.AutoSize = true;
            messageLabel.Location = new System.Drawing.Point(50, 20);
            this.Controls.Add(messageLabel);

            Button customBackButton = new Button();
            customBackButton.Text = "< Back";
            customBackButton.Location = new System.Drawing.Point(30, 60);
            customBackButton.Click += (sender, e) => { this.Close(); module1_1.ShowDialogBox(); };
            this.Controls.Add(customBackButton);

            Button customOkButton = new Button();
            customOkButton.Text = "OK";
            customOkButton.Location = new System.Drawing.Point(110, 60);
            customOkButton.Click += (sender, e) => { this.Close(); };
            this.Controls.Add(customOkButton);

            Button customCancelButton = new Button();
            customCancelButton.Text = "Abort";
            customCancelButton.Location = new System.Drawing.Point(190, 60);
            customCancelButton.Click += (sender, e) => { this.Close(); };
            this.Controls.Add(customCancelButton);
        }

        public static void ShowDialogBox()
        {
            module1_2 dialog = new module1_2();
            dialog.StartPosition = FormStartPosition.CenterScreen;
            dialog.ShowDialog();
        }
    }
}
