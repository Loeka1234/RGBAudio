// Loeka Lievens 
using NAudio.CoreAudioApi;
using Solid.Arduino;
using Solid.Arduino.Firmata;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoAudio
{
    public partial class Form : System.Windows.Forms.Form
    {
        Graphics g;
        Brush br;
        ArduinoSession session;

        int redPin = 6, greenPin = 5, bluePin = 3;
        int newRed, newGreen, newBlue;
        int hardness = 100; // Default hardness

        public Form()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            g = pnlAudio.CreateGraphics();
            // Adds audio devices to combobox
            MMDeviceEnumerator en = new MMDeviceEnumerator();
            var devices = en.EnumerateAudioEndPoints(DataFlow.All, DeviceState.Active);
            cbDevices.Items.AddRange(devices.ToArray());


            br = new SolidBrush(btnColor.BackColor);
            cbMode.SelectedIndex = 0;
        }

        public void drawAudio(float height) // Draws out the audio in pnlAudio
        {
            height = (float)pnlAudio.Height / 100 * height;
            g.Clear(pnlAudio.BackColor);
            g.FillRectangle(br, 0, pnlAudio.Height - height, pnlAudio.Width, height);
        }

        private void audioTimer_Tick(object sender, EventArgs e) // Draws the audio
        {
            if(cbDevices.SelectedItem != null)
            {
                var device = (MMDevice)cbDevices.SelectedItem;
                float deviceValue = device.AudioMeterInformation.MasterPeakValue * hardness;
                deviceValue = deviceValue > 100 ? 100 : deviceValue; // Sets max of 100 for float deviceValue
                if (session != null) {
                    session.SetDigitalPin(redPin, btnColor.BackColor.R/100*(long)deviceValue);
                    session.SetDigitalPin(greenPin, btnColor.BackColor.G/100*(long)deviceValue);
                    session.SetDigitalPin(bluePin, btnColor.BackColor.B/100*(long)deviceValue);
                }
            }
        }
        private void visualAudioTimer_Tick(object sender, EventArgs e)
        {
            if(cbDevices.SelectedItem != null)
            {
                var device = (MMDevice)cbDevices.SelectedItem;
                float deviceValue = device.AudioMeterInformation.MasterPeakValue * hardness;
                deviceValue = deviceValue > 100 ? 100 : deviceValue;
                drawAudio(deviceValue);
                lblAudio.Text = Math.Round(deviceValue).ToString();
            }
        }
        private void btnColor_Click(object sender, EventArgs e) // Changes the color
        {
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                btnColor.BackColor = colorDialog.Color;
                br = new SolidBrush(btnColor.BackColor);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e) // To close the form
        {
            Close();
        }
        private void pictureBox2_Click(object sender, EventArgs e) // To minimize the form
        {
            WindowState = FormWindowState.Minimized;
        }
        // Making close and minimize look beter on hover
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Image.FromFile("close_darker.png");
        }
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Image.FromFile("close.png");
        }
        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.BackgroundImage = Image.FromFile("minimize_darker.png");
        }
        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackgroundImage = Image.FromFile("minimize.png");
        }


        // to move the form
        int mouseX = 0, mouseY = 0;
        bool mouseDown;
        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }
        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouseDown)
            {
                mouseX = MousePosition.X - Width/2;
                mouseY = MousePosition.Y - 20;

                SetDesktopLocation(mouseX, mouseY);
            }
        }
        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }


        // Search arduino at start
        private void Form_Shown(object sender, EventArgs e)
        {
            findArduino();
        }
        private void btnRetry_Click(object sender, EventArgs e)
        {
            findArduino();
        }
        private void findArduino() // Try finding the arduino
        {
            ISerialConnection connection = EnhancedSerialConnection.Find();
            if (connection != null)
            {
                session = new ArduinoSession(connection);
                lblConnection.Text = "Arduino found!";
                session.SetDigitalPinMode(redPin, PinMode.PwmOutput);
                session.SetDigitalPinMode(greenPin, PinMode.PwmOutput);
                session.SetDigitalPinMode(bluePin, PinMode.PwmOutput);
                session.SetDigitalPin(redPin, btnColor.BackColor.R);
                session.SetDigitalPin(greenPin, btnColor.BackColor.G);
                session.SetDigitalPin(bluePin, btnColor.BackColor.B);
                btnRetry.Hide();
            }
            else
            {
                lblConnection.Text = "The arduino was not found...";
                btnRetry.Show();
            }
        }

        // For changing the pins
        private void btnChangePins_Click(object sender, EventArgs e)
        {
            txtRedInput.Show();
            txtGreenInput.Show();
            txtBlueInput.Show();
            txtRedInput.Focus();
            pbSubmitRed.Show();
            pbSubmitGreen.Show();
            pbSubmitBlue.Show();
            btnChangePins.Hide();
        }
        private void txtRedInput_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                setRedPin();
            }
        }
        private void txtGreenInput_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                setGreenPin();
            }
        }
        private void txtBlueInput_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                setBluePin();
            }
        }
        private void pbSubmitRed_Click(object sender, EventArgs e)
        {
            setRedPin();
        }
        private void pbSubmitGreen_Click(object sender, EventArgs e)
        {
            setGreenPin();
        }
        private void pbSubmitBlue_Click(object sender, EventArgs e)
        {
            setBluePin();
        }
        private void setRedPin()
        {
            try
            {
                int newPin = int.Parse(txtRedInput.Text);
                if (newPin == newGreen || newPin == newBlue) throw new ArgumentException("Pin already exists!");
                session.SetDigitalPinMode(newPin, PinMode.PwmOutput);

                newRed = newPin;
                redPin = newPin;
                lblRedNumber.Text = redPin.ToString();
                txtRedInput.Hide();
                pbSubmitRed.Hide();
                if (!txtRedInput.Visible && !txtGreenInput.Visible && !txtBlueInput.Visible)
                {
                    newRed = -1;
                    newGreen = -1;
                    newBlue = -1;
                    btnChangePins.Show();
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                txtRedInput.Clear();
            }
            catch(Exception) 
            {
                MessageBox.Show("This is not a correct pin!");
                txtRedInput.Clear();
            }
        }


        private void setGreenPin()
        {
            try
            {
                int newPin = int.Parse(txtGreenInput.Text);
                if (newPin == newRed || newPin == newBlue) throw new ArgumentException("Pin already exists!");
                session.SetDigitalPinMode(newPin, PinMode.PwmOutput);

                newGreen = newPin;
                greenPin = newPin;
                lblGreenNumber.Text = greenPin.ToString();
                txtGreenInput.Hide();
                pbSubmitGreen.Hide();

                if (!txtRedInput.Visible && !txtGreenInput.Visible && !txtBlueInput.Visible)
                {
                    newRed = -1;
                    newGreen = -1;
                    newBlue = -1;
                    btnChangePins.Show();
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                txtGreenInput.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("This is not a correct pin!");
                txtGreenInput.Clear();
            }
        }

        private void setBluePin()
        {
            try
            {
                int newPin = int.Parse(txtBlueInput.Text);
                if (newPin == newGreen || newPin == newRed) throw new ArgumentException("Pin already exists!");
                session.SetDigitalPinMode(newPin, PinMode.PwmOutput);

                newBlue = newPin;
                bluePin = newPin;
                lblBlueNumber.Text = bluePin.ToString();
                txtBlueInput.Hide();
                pbSubmitBlue.Hide();

                if (!txtRedInput.Visible && !txtGreenInput.Visible && !txtBlueInput.Visible)
                {
                    newRed = -1;
                    newGreen = -1;
                    newBlue = -1;
                    btnChangePins.Show();
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                txtBlueInput.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("This is not a correct pin!");
                txtBlueInput.Clear();
            }
        }
        private void tbHardness_Scroll(object sender, EventArgs e)
        {
            hardness = tbHardness.Value;
            lblHardness.Text = tbHardness.Value.ToString() + "%";
        }
    }
}
