using TempFormatConverter.models;
namespace TempFormatConverter.GUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        
        private void TB_Input_KeyPress(object sender, KeyEventArgs e)
        {

           
            if (e.KeyCode == Keys.Return && radBtnCelsiusNachFahrenheit.Checked == true)
            {
                Celsius calculation = new(tB_Input.Text);
                calculation.ToFahrenheit();

                lblOutput.Text = $"{calculation.Output,0:F3}";
            }
            

           
            if (e.KeyCode == Keys.Return && radBtnCelsiusNachKelvin.Checked == true)
            {
                Celsius calculation = new(tB_Input.Text);
                calculation.ToKelvin();

                lblOutput.Text = $"{calculation.Output,0:F3}";
            }


           
            if (e.KeyCode == Keys.Return && radBtnFahrenheitNachCelsius.Checked == true)
            {
                Fahrenheit calculation = new(tB_Input.Text);
                calculation.ToCelsius();
                lblOutput.Text = $"{calculation.Output,0:F3}";
            }


          
            if (e.KeyCode == Keys.Return && radBtnKelvinNachCelsius.Checked == true)
            {
                Kelvin calculation = new(tB_Input.Text);
                calculation.ToCelsius();
                lblOutput.Text = $"{calculation.Output,0:F3}";
            }
            //TODO: fehlerabfrage auf richtiges Format
            //TODO: Fehlerabfrage wegen Conversion da Celsius nach Kelvin darf Celsius nicht < -273,15 sein e.g.
        }

        private void radBtnCelsiusNachFahrenheit_CheckedChanged(object sender, EventArgs e)
        {
            if (radBtnKelvinNachCelsius.Checked == true)
            {
                lblScaleUnit1.Text = "°K";
                lblScaleUnit2.Text = "°C";
            }
            if (radBtnCelsiusNachFahrenheit.Checked == true)
            {
                lblScaleUnit1.Text = "°C";
                lblScaleUnit2.Text = "°F";
            }
            if (radBtnCelsiusNachKelvin.Checked == true)
            {
                lblScaleUnit1.Text = "°C";
                lblScaleUnit2.Text = "°K";
            }
            if (radBtnFahrenheitNachCelsius.Checked == true)
            {
                lblScaleUnit1.Text = "°F";
                lblScaleUnit2.Text = "°C";
            }
        }

    }
}