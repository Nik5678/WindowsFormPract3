namespace _3_задание
{
    partial class Form1
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
            textBoxTemperature = new TextBox();
            buttonCelsiusToFahrenheit = new Button();
            buttonFahrenheitToCelsius = new Button();
            labelResult = new Label();
            SuspendLayout();
            // 
            // textBoxTemperature
            // 
            textBoxTemperature.BackColor = SystemColors.GradientActiveCaption;
            textBoxTemperature.Cursor = Cursors.IBeam;
            textBoxTemperature.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            textBoxTemperature.ForeColor = SystemColors.MenuHighlight;
            textBoxTemperature.Location = new Point(61, 38);
            textBoxTemperature.Multiline = true;
            textBoxTemperature.Name = "textBoxTemperature";
            textBoxTemperature.Size = new Size(246, 41);
            textBoxTemperature.TabIndex = 0;
            textBoxTemperature.Text = "Введите температуру";
            textBoxTemperature.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonCelsiusToFahrenheit
            // 
            buttonCelsiusToFahrenheit.BackColor = Color.SeaShell;
            buttonCelsiusToFahrenheit.Cursor = Cursors.Hand;
            buttonCelsiusToFahrenheit.FlatAppearance.BorderColor = SystemColors.HotTrack;
            buttonCelsiusToFahrenheit.FlatAppearance.BorderSize = 3;
            buttonCelsiusToFahrenheit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonCelsiusToFahrenheit.ForeColor = Color.Gold;
            buttonCelsiusToFahrenheit.Location = new Point(13, 148);
            buttonCelsiusToFahrenheit.Name = "buttonCelsiusToFahrenheit";
            buttonCelsiusToFahrenheit.Size = new Size(133, 64);
            buttonCelsiusToFahrenheit.TabIndex = 1;
            buttonCelsiusToFahrenheit.Text = "C to F";
            buttonCelsiusToFahrenheit.UseVisualStyleBackColor = false;
            buttonCelsiusToFahrenheit.Click += buttonCelsiusToFahrenheit_Click;
            // 
            // buttonFahrenheitToCelsius
            // 
            buttonFahrenheitToCelsius.BackColor = Color.SeaShell;
            buttonFahrenheitToCelsius.Cursor = Cursors.Hand;
            buttonFahrenheitToCelsius.FlatAppearance.BorderColor = SystemColors.HotTrack;
            buttonFahrenheitToCelsius.FlatAppearance.BorderSize = 3;
            buttonFahrenheitToCelsius.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonFahrenheitToCelsius.ForeColor = Color.Gold;
            buttonFahrenheitToCelsius.Location = new Point(205, 148);
            buttonFahrenheitToCelsius.Name = "buttonFahrenheitToCelsius";
            buttonFahrenheitToCelsius.Size = new Size(133, 64);
            buttonFahrenheitToCelsius.TabIndex = 2;
            buttonFahrenheitToCelsius.Text = "F to C";
            buttonFahrenheitToCelsius.UseVisualStyleBackColor = false;
            buttonFahrenheitToCelsius.Click += buttonFahrenheitToCelsius_Click;
            // 
            // labelResult
            // 
            labelResult.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            labelResult.ForeColor = Color.PaleGreen;
            labelResult.Location = new Point(111, 269);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(141, 48);
            labelResult.TabIndex = 3;
            labelResult.Text = "Температура";
            labelResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(367, 363);
            Controls.Add(labelResult);
            Controls.Add(buttonFahrenheitToCelsius);
            Controls.Add(buttonCelsiusToFahrenheit);
            Controls.Add(textBoxTemperature);
            Name = "Form1";
            Text = "Перевод температуры";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxTemperature;
        private Button buttonCelsiusToFahrenheit;
        private Button buttonFahrenheitToCelsius;
        private Label labelResult;
    }
}
