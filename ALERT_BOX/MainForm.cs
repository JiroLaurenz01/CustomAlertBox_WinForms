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
    }
}
