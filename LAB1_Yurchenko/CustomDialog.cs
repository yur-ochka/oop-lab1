using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace LAB1_Yurchenko
{
    class CustomDialog : Form
    {
        public CustomDialog()
        {
            // Set dialog title
            this.Text = "Custom Dialog Box";

            // Create and configure label (message)
            Label messageLabel = new Label();
            messageLabel.Text = "Do you want to continue?";
            messageLabel.AutoSize = true;
            messageLabel.Location = new System.Drawing.Point(50, 20);
            this.Controls.Add(messageLabel);

            // Create and configure first button (Custom OK button)
            Button customOkButton = new Button();
            customOkButton.Text = "Proceed";
            customOkButton.Location = new System.Drawing.Point(30, 60);
            customOkButton.Click += (sender, e) => { MessageBox.Show("You chose to proceed!"); this.Close(); };
            this.Controls.Add(customOkButton);

            // Create and configure second button (Custom Cancel button)
            Button customCancelButton = new Button();
            customCancelButton.Text = "Abort";
            customCancelButton.Location = new System.Drawing.Point(150, 60);
            customCancelButton.Click += (sender, e) => { MessageBox.Show("You chose to abort!"); this.Close(); };
            this.Controls.Add(customCancelButton);
        }

        // Show the custom dialog box
        public static void ShowDialogBox()
        {
            CustomDialog dialog = new CustomDialog();
            dialog.StartPosition = FormStartPosition.CenterScreen;
            dialog.ShowDialog();
        }
    }
}
