namespace INF_Übungsbeispiel_Tankstellenrechner
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
            txtTankVolumen = new TextBox();
            txtGetankteMenge = new TextBox();
            txtKilometerAktuell = new TextBox();
            txtKilometerLetzterTank = new TextBox();
            txtBenzinPreis = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            btnBerechnen = new Button();
            lblGefahreneKilometer = new Label();
            lblDurchschnittsverbrauch = new Label();
            lblReichweite = new Label();
            lblTankempfehlung = new Label();
            SuspendLayout();
            // 
            // txtTankVolumen
            // 
            txtTankVolumen.Location = new Point(165, 315);
            txtTankVolumen.Name = "txtTankVolumen";
            txtTankVolumen.Size = new Size(225, 43);
            txtTankVolumen.TabIndex = 0;
            txtTankVolumen.TextAlign = HorizontalAlignment.Right;
            // 
            // txtGetankteMenge
            // 
            txtGetankteMenge.Location = new Point(165, 243);
            txtGetankteMenge.Name = "txtGetankteMenge";
            txtGetankteMenge.Size = new Size(225, 43);
            txtGetankteMenge.TabIndex = 1;
            txtGetankteMenge.TextAlign = HorizontalAlignment.Right;
            // 
            // txtKilometerAktuell
            // 
            txtKilometerAktuell.Location = new Point(165, 178);
            txtKilometerAktuell.Name = "txtKilometerAktuell";
            txtKilometerAktuell.Size = new Size(225, 43);
            txtKilometerAktuell.TabIndex = 2;
            txtKilometerAktuell.TextAlign = HorizontalAlignment.Right;
            // 
            // txtKilometerLetzterTank
            // 
            txtKilometerLetzterTank.Location = new Point(165, 116);
            txtKilometerLetzterTank.Name = "txtKilometerLetzterTank";
            txtKilometerLetzterTank.Size = new Size(225, 43);
            txtKilometerLetzterTank.TabIndex = 3;
            txtKilometerLetzterTank.TextAlign = HorizontalAlignment.Right;
            // 
            // txtBenzinPreis
            // 
            txtBenzinPreis.Location = new Point(165, 56);
            txtBenzinPreis.Name = "txtBenzinPreis";
            txtBenzinPreis.Size = new Size(225, 43);
            txtBenzinPreis.TabIndex = 4;
            txtBenzinPreis.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(531, 59);
            label1.Name = "label1";
            label1.Size = new Size(152, 37);
            label1.TabIndex = 5;
            label1.Text = "Benzinpreis";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(531, 119);
            label2.Name = "label2";
            label2.Size = new Size(510, 37);
            label2.TabIndex = 6;
            label2.Text = "Kilometerstand beim letzten Tankvorgang";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(531, 181);
            label3.Name = "label3";
            label3.Size = new Size(309, 37);
            label3.TabIndex = 7;
            label3.Text = "Aktueller Kilometerstand";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(531, 249);
            label4.Name = "label4";
            label4.Size = new Size(211, 37);
            label4.TabIndex = 8;
            label4.Text = "getankte Menge";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(531, 318);
            label5.Name = "label5";
            label5.Size = new Size(173, 37);
            label5.TabIndex = 9;
            label5.Text = "Tankvolumen";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(413, 62);
            label6.Name = "label6";
            label6.Size = new Size(56, 37);
            label6.TabIndex = 10;
            label6.Text = "€/L";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(413, 122);
            label7.Name = "label7";
            label7.Size = new Size(53, 37);
            label7.TabIndex = 11;
            label7.Text = "km";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(413, 184);
            label8.Name = "label8";
            label8.Size = new Size(53, 37);
            label8.TabIndex = 12;
            label8.Text = "km";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(413, 249);
            label9.Name = "label9";
            label9.Size = new Size(30, 37);
            label9.TabIndex = 13;
            label9.Text = "L";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(413, 321);
            label10.Name = "label10";
            label10.Size = new Size(30, 37);
            label10.TabIndex = 14;
            label10.Text = "L";
            // 
            // btnBerechnen
            // 
            btnBerechnen.Location = new Point(1296, 195);
            btnBerechnen.Name = "btnBerechnen";
            btnBerechnen.Size = new Size(169, 52);
            btnBerechnen.TabIndex = 15;
            btnBerechnen.Text = "&Berechnen";
            btnBerechnen.UseVisualStyleBackColor = true;
            btnBerechnen.Click += btnBerechnen_Click;
            // 
            // lblGefahreneKilometer
            // 
            lblGefahreneKilometer.AutoSize = true;
            lblGefahreneKilometer.Location = new Point(531, 564);
            lblGefahreneKilometer.Name = "lblGefahreneKilometer";
            lblGefahreneKilometer.Size = new Size(254, 37);
            lblGefahreneKilometer.TabIndex = 16;
            lblGefahreneKilometer.Text = "GefahreneKilometer";
            // 
            // lblDurchschnittsverbrauch
            // 
            lblDurchschnittsverbrauch.AutoSize = true;
            lblDurchschnittsverbrauch.Location = new Point(531, 613);
            lblDurchschnittsverbrauch.Name = "lblDurchschnittsverbrauch";
            lblDurchschnittsverbrauch.Size = new Size(293, 37);
            lblDurchschnittsverbrauch.TabIndex = 17;
            lblDurchschnittsverbrauch.Text = "Durchschnittsverbrauch";
            // 
            // lblReichweite
            // 
            lblReichweite.AutoSize = true;
            lblReichweite.Location = new Point(531, 666);
            lblReichweite.Name = "lblReichweite";
            lblReichweite.Size = new Size(144, 37);
            lblReichweite.TabIndex = 18;
            lblReichweite.Text = "Reichweite";
            // 
            // lblTankempfehlung
            // 
            lblTankempfehlung.AutoSize = true;
            lblTankempfehlung.Location = new Point(531, 727);
            lblTankempfehlung.Name = "lblTankempfehlung";
            lblTankempfehlung.Size = new Size(213, 37);
            lblTankempfehlung.TabIndex = 19;
            lblTankempfehlung.Text = "Tankempfehlung";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1866, 995);
            Controls.Add(lblTankempfehlung);
            Controls.Add(lblReichweite);
            Controls.Add(lblDurchschnittsverbrauch);
            Controls.Add(lblGefahreneKilometer);
            Controls.Add(btnBerechnen);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtBenzinPreis);
            Controls.Add(txtKilometerLetzterTank);
            Controls.Add(txtKilometerAktuell);
            Controls.Add(txtGetankteMenge);
            Controls.Add(txtTankVolumen);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTankVolumen;
        private TextBox txtGetankteMenge;
        private TextBox txtKilometerAktuell;
        private TextBox txtKilometerLetzterTank;
        private TextBox txtBenzinPreis;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button btnBerechnen;
        private Label lblGefahreneKilometer;
        private Label lblDurchschnittsverbrauch;
        private Label lblReichweite;
        private Label lblTankempfehlung;
    }
}
