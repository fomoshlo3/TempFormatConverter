namespace TempFormatConverter.GUI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gBUmrechnung = new System.Windows.Forms.GroupBox();
            this.radBtnCelsiusNachFahrenheit = new System.Windows.Forms.RadioButton();
            this.radBtnFahrenheitNachCelsius = new System.Windows.Forms.RadioButton();
            this.radBtnCelsiusNachKelvin = new System.Windows.Forms.RadioButton();
            this.radBtnKelvinNachCelsius = new System.Windows.Forms.RadioButton();
            this.btnBeenden = new System.Windows.Forms.Button();
            this.lblTemperatur = new System.Windows.Forms.Label();
            this.tB_Input = new System.Windows.Forms.TextBox();
            this.lblScaleUnit1 = new System.Windows.Forms.Label();
            this.lblScaleUnit2 = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblErrorOutput = new System.Windows.Forms.Label();
            this.gBUmrechnung.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBUmrechnung
            // 
            this.gBUmrechnung.Controls.Add(this.radBtnCelsiusNachFahrenheit);
            this.gBUmrechnung.Controls.Add(this.radBtnFahrenheitNachCelsius);
            this.gBUmrechnung.Controls.Add(this.radBtnCelsiusNachKelvin);
            this.gBUmrechnung.Controls.Add(this.radBtnKelvinNachCelsius);
            this.gBUmrechnung.Location = new System.Drawing.Point(9, 104);
            this.gBUmrechnung.Name = "gBUmrechnung";
            this.gBUmrechnung.Size = new System.Drawing.Size(246, 168);
            this.gBUmrechnung.TabIndex = 0;
            this.gBUmrechnung.TabStop = false;
            this.gBUmrechnung.Text = "Umrechnungen";
            // 
            // radBtnCelsiusNachFahrenheit
            // 
            this.radBtnCelsiusNachFahrenheit.AutoSize = true;
            this.radBtnCelsiusNachFahrenheit.Location = new System.Drawing.Point(6, 22);
            this.radBtnCelsiusNachFahrenheit.Name = "radBtnCelsiusNachFahrenheit";
            this.radBtnCelsiusNachFahrenheit.Size = new System.Drawing.Size(160, 19);
            this.radBtnCelsiusNachFahrenheit.TabIndex = 1;
            this.radBtnCelsiusNachFahrenheit.TabStop = true;
            this.radBtnCelsiusNachFahrenheit.Text = "°Celsius nach °Fahrenheit";
            this.radBtnCelsiusNachFahrenheit.UseVisualStyleBackColor = true;
            this.radBtnCelsiusNachFahrenheit.CheckedChanged += new System.EventHandler(this.radBtnCelsiusNachFahrenheit_CheckedChanged);
            // 
            // radBtnFahrenheitNachCelsius
            // 
            this.radBtnFahrenheitNachCelsius.AutoSize = true;
            this.radBtnFahrenheitNachCelsius.Location = new System.Drawing.Point(6, 60);
            this.radBtnFahrenheitNachCelsius.Name = "radBtnFahrenheitNachCelsius";
            this.radBtnFahrenheitNachCelsius.Size = new System.Drawing.Size(160, 19);
            this.radBtnFahrenheitNachCelsius.TabIndex = 2;
            this.radBtnFahrenheitNachCelsius.TabStop = true;
            this.radBtnFahrenheitNachCelsius.Text = "°Fahrenheit nach °Celsius";
            this.radBtnFahrenheitNachCelsius.UseVisualStyleBackColor = true;
            this.radBtnFahrenheitNachCelsius.CheckedChanged += new System.EventHandler(this.radBtnCelsiusNachFahrenheit_CheckedChanged);
            // 
            // radBtnCelsiusNachKelvin
            // 
            this.radBtnCelsiusNachKelvin.AutoSize = true;
            this.radBtnCelsiusNachKelvin.Location = new System.Drawing.Point(6, 98);
            this.radBtnCelsiusNachKelvin.Name = "radBtnCelsiusNachKelvin";
            this.radBtnCelsiusNachKelvin.Size = new System.Drawing.Size(136, 19);
            this.radBtnCelsiusNachKelvin.TabIndex = 3;
            this.radBtnCelsiusNachKelvin.TabStop = true;
            this.radBtnCelsiusNachKelvin.Text = "°Celsius nach °Kelvin";
            this.radBtnCelsiusNachKelvin.UseVisualStyleBackColor = true;
            this.radBtnCelsiusNachKelvin.CheckedChanged += new System.EventHandler(this.radBtnCelsiusNachFahrenheit_CheckedChanged);
            // 
            // radBtnKelvinNachCelsius
            // 
            this.radBtnKelvinNachCelsius.AutoSize = true;
            this.radBtnKelvinNachCelsius.Location = new System.Drawing.Point(6, 138);
            this.radBtnKelvinNachCelsius.Name = "radBtnKelvinNachCelsius";
            this.radBtnKelvinNachCelsius.Size = new System.Drawing.Size(155, 19);
            this.radBtnKelvinNachCelsius.TabIndex = 4;
            this.radBtnKelvinNachCelsius.TabStop = true;
            this.radBtnKelvinNachCelsius.Text = "°Kelvin nach °Fahrenheit";
            this.radBtnKelvinNachCelsius.UseVisualStyleBackColor = true;
            this.radBtnKelvinNachCelsius.CheckedChanged += new System.EventHandler(this.radBtnCelsiusNachFahrenheit_CheckedChanged);
            // 
            // btnBeenden
            // 
            this.btnBeenden.Location = new System.Drawing.Point(9, 278);
            this.btnBeenden.Name = "btnBeenden";
            this.btnBeenden.Size = new System.Drawing.Size(246, 23);
            this.btnBeenden.TabIndex = 1;
            this.btnBeenden.Text = "Beenden";
            this.btnBeenden.UseVisualStyleBackColor = true;
            // 
            // lblTemperatur
            // 
            this.lblTemperatur.AutoSize = true;
            this.lblTemperatur.Location = new System.Drawing.Point(15, 18);
            this.lblTemperatur.Name = "lblTemperatur";
            this.lblTemperatur.Size = new System.Drawing.Size(70, 15);
            this.lblTemperatur.TabIndex = 2;
            this.lblTemperatur.Text = "Temperatur:";
            // 
            // tB_Input
            // 
            this.tB_Input.Location = new System.Drawing.Point(91, 15);
            this.tB_Input.Name = "tB_Input";
            this.tB_Input.Size = new System.Drawing.Size(100, 23);
            this.tB_Input.TabIndex = 3;
            this.tB_Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tB_Input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_Input_KeyPress);
            // 
            // lblScaleUnit1
            // 
            this.lblScaleUnit1.Location = new System.Drawing.Point(195, 19);
            this.lblScaleUnit1.Name = "lblScaleUnit1";
            this.lblScaleUnit1.Size = new System.Drawing.Size(30, 15);
            this.lblScaleUnit1.TabIndex = 4;
            this.lblScaleUnit1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblScaleUnit2
            // 
            this.lblScaleUnit2.Location = new System.Drawing.Point(195, 52);
            this.lblScaleUnit2.Name = "lblScaleUnit2";
            this.lblScaleUnit2.Size = new System.Drawing.Size(30, 15);
            this.lblScaleUnit2.TabIndex = 5;
            this.lblScaleUnit2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOutput
            // 
            this.lblOutput.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblOutput.Location = new System.Drawing.Point(91, 52);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(97, 15);
            this.lblOutput.TabIndex = 6;
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblErrorOutput
            // 
            this.lblErrorOutput.AutoSize = true;
            this.lblErrorOutput.Location = new System.Drawing.Point(9, 72);
            this.lblErrorOutput.Name = "lblErrorOutput";
            this.lblErrorOutput.Size = new System.Drawing.Size(116, 15);
            this.lblErrorOutput.TabIndex = 7;
            this.lblErrorOutput.Text = "ErrorMessageOutput";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 307);
            this.Controls.Add(this.lblErrorOutput);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblScaleUnit2);
            this.Controls.Add(this.lblScaleUnit1);
            this.Controls.Add(this.tB_Input);
            this.Controls.Add(this.lblTemperatur);
            this.Controls.Add(this.btnBeenden);
            this.Controls.Add(this.gBUmrechnung);
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "TemperatureConverter V1.0.0";
            this.gBUmrechnung.ResumeLayout(false);
            this.gBUmrechnung.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox gBUmrechnung;
        private RadioButton radBtnCelsiusNachFahrenheit;
        private RadioButton radBtnFahrenheitNachCelsius;
        private RadioButton radBtnCelsiusNachKelvin;
        private RadioButton radBtnKelvinNachCelsius;
        private Button btnBeenden;
        private Label lblTemperatur;
        private TextBox tB_Input;
        private Label lblScaleUnit1;
        private Label lblScaleUnit2;
        private Label lblOutput;
        private Label lblErrorOutput;
    }
}