using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALERT_BOX
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        #region FUNCTION TO DISPLAY ALERT

        // This method is used to display an alert message using a custom AlertForm.
        public void Alert(string msg, AlertForm.Type type)
        {
            AlertForm alertForm = new AlertForm();

            // Call the ShowAlert method of the AlertForm instance, passing the message and alert type as parameters.
            alertForm.ShowAlert(msg, type);
        }

        #endregion

        #region FUNCTION TO DISPLAY SPECIFIC NOTIFICATION

        private void DisplayNotification_Click(object sender, EventArgs e)
        {
            // Cast the sender object to a Guna2Button, representing the button that triggered the event.
            Guna2Button button = (Guna2Button)sender;

            switch (button.Name)
            {
                case "successButton":
                    // If the "Success" button is clicked, trigger the Alert method with a success notification.
                    Alert("Success Notification", AlertForm.Type.Success);
                    break;
                case "informationButton":
                    // If the "Information" button is clicked, trigger the Alert method with an informative notification.
                    Alert("Informative Notification", AlertForm.Type.Info);
                    break;
                case "warningButton":
                    // If the "Warning" button is clicked, trigger the Alert method with a warning notification.
                    Alert("Warning Notification", AlertForm.Type.Warning);
                    break;
                case "errorButton":
                    // If the "Error" button is clicked, trigger the Alert method with an error notification.
                    Alert("Error Notification", AlertForm.Type.Error);
                    break;
            }
        }


        #endregion

        #region FUNCTIONS FOR DRAGGING FUNCTIONALITY OF FORM

        private void containerControls_MouseMove(object sender, MouseEventArgs e)
        {
            // Check if the left mouse button is held down (mouse is being dragged).
            if (e.Button == MouseButtons.Left)
            {
                // Calculate the new position of the form based on the mouse movement.
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        Point lastPoint;

        private void containerControls_MouseDown(object sender, MouseEventArgs e) => lastPoint = new Point(e.X, e.Y);

        #endregion
    }
}
