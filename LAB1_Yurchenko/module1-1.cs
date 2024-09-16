using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LAB1_Yurchenko
{
    class module1_1 : Form
    {
        public module1_1()
        {
            this.Text = "Window 1";

            Label messageLabel = new Label();
            messageLabel.Text = "Do you want to continue?";
            messageLabel.AutoSize = true;
            messageLabel.Location = new System.Drawing.Point(50, 20);
            this.Controls.Add(messageLabel);

            Button customOkButton = new Button();
            customOkButton.Text = "Next >";
            customOkButton.Location = new System.Drawing.Point(30, 60);
            customOkButton.Click += (sender, e) => {this.Close(); module1_2.ShowDialogBox(); };
            this.Controls.Add(customOkButton);

            Button customCancelButton = new Button();
            customCancelButton.Text = "Abort";
            customCancelButton.Location = new System.Drawing.Point(150, 60);
            customCancelButton.Click += (sender, e) => {this.Close(); };
            this.Controls.Add(customCancelButton);
        }
        public static void ShowDialogBox()
        {
            module1_1 dialog = new module1_1();
            dialog.StartPosition = FormStartPosition.CenterScreen;
            dialog.ShowDialog();
        }
    }
}
