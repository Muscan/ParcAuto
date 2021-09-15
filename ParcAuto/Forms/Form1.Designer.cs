
namespace ParcAuto
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
            this.grpBoxDropDownSelections = new System.Windows.Forms.GroupBox();
            this.lblCombustibil = new System.Windows.Forms.Label();
            this.btnCauta = new System.Windows.Forms.Button();
            this.checkBoxEligibilFinantare = new System.Windows.Forms.CheckBox();
            this.lblAn = new System.Windows.Forms.Label();
            this.cmbBoxCombustibil = new System.Windows.Forms.ComboBox();
            this.cmbBoxAnStop = new System.Windows.Forms.ComboBox();
            this.cmbBoxAnStart = new System.Windows.Forms.ComboBox();
            this.lblPret = new System.Windows.Forms.Label();
            this.cmbBoxPretPanaLa = new System.Windows.Forms.ComboBox();
            this.cmbBoxPretDeLa = new System.Windows.Forms.ComboBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.cmbBoxModel = new System.Windows.Forms.ComboBox();
            this.lblGeneratie = new System.Windows.Forms.Label();
            this.cmbBoxGeneratie = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cmbBoxMarca = new System.Windows.Forms.ComboBox();
            this.grpBoxDropDownSelections.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxDropDownSelections
            // 
            this.grpBoxDropDownSelections.AutoSize = true;
            this.grpBoxDropDownSelections.BackColor = System.Drawing.Color.White;
            this.grpBoxDropDownSelections.Controls.Add(this.lblCombustibil);
            this.grpBoxDropDownSelections.Controls.Add(this.btnCauta);
            this.grpBoxDropDownSelections.Controls.Add(this.checkBoxEligibilFinantare);
            this.grpBoxDropDownSelections.Controls.Add(this.lblAn);
            this.grpBoxDropDownSelections.Controls.Add(this.cmbBoxCombustibil);
            this.grpBoxDropDownSelections.Controls.Add(this.cmbBoxAnStop);
            this.grpBoxDropDownSelections.Controls.Add(this.cmbBoxAnStart);
            this.grpBoxDropDownSelections.Controls.Add(this.lblPret);
            this.grpBoxDropDownSelections.Controls.Add(this.cmbBoxPretPanaLa);
            this.grpBoxDropDownSelections.Controls.Add(this.cmbBoxPretDeLa);
            this.grpBoxDropDownSelections.Controls.Add(this.lblModel);
            this.grpBoxDropDownSelections.Controls.Add(this.cmbBoxModel);
            this.grpBoxDropDownSelections.Controls.Add(this.lblGeneratie);
            this.grpBoxDropDownSelections.Controls.Add(this.cmbBoxGeneratie);
            this.grpBoxDropDownSelections.Controls.Add(this.lblMarca);
            this.grpBoxDropDownSelections.Controls.Add(this.cmbBoxMarca);
            this.grpBoxDropDownSelections.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpBoxDropDownSelections.Location = new System.Drawing.Point(12, 54);
            this.grpBoxDropDownSelections.Name = "grpBoxDropDownSelections";
            this.grpBoxDropDownSelections.Size = new System.Drawing.Size(1023, 688);
            this.grpBoxDropDownSelections.TabIndex = 0;
            this.grpBoxDropDownSelections.TabStop = false;
            this.grpBoxDropDownSelections.Text = "Ce cauti?";
            this.grpBoxDropDownSelections.Enter += new System.EventHandler(this.grpBoxDropDownSelections_Enter);
            // 
            // lblCombustibil
            // 
            this.lblCombustibil.AutoSize = true;
            this.lblCombustibil.Location = new System.Drawing.Point(16, 323);
            this.lblCombustibil.Name = "lblCombustibil";
            this.lblCombustibil.Size = new System.Drawing.Size(129, 24);
            this.lblCombustibil.TabIndex = 15;
            this.lblCombustibil.Text = "Combustibil";
            // 
            // btnCauta
            // 
            this.btnCauta.BackColor = System.Drawing.Color.Brown;
            this.btnCauta.Location = new System.Drawing.Point(406, 521);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(373, 71);
            this.btnCauta.TabIndex = 14;
            this.btnCauta.Text = "Cauta";
            this.btnCauta.UseVisualStyleBackColor = false;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // checkBoxEligibilFinantare
            // 
            this.checkBoxEligibilFinantare.AutoSize = true;
            this.checkBoxEligibilFinantare.Location = new System.Drawing.Point(406, 358);
            this.checkBoxEligibilFinantare.Name = "checkBoxEligibilFinantare";
            this.checkBoxEligibilFinantare.Size = new System.Drawing.Size(273, 28);
            this.checkBoxEligibilFinantare.TabIndex = 13;
            this.checkBoxEligibilFinantare.Text = "Eligibil pentru finantare";
            this.checkBoxEligibilFinantare.UseVisualStyleBackColor = true;
            // 
            // lblAn
            // 
            this.lblAn.AutoSize = true;
            this.lblAn.Location = new System.Drawing.Point(16, 237);
            this.lblAn.Name = "lblAn";
            this.lblAn.Size = new System.Drawing.Size(56, 24);
            this.lblAn.TabIndex = 12;
            this.lblAn.Text = "Anul";
            // 
            // cmbBoxCombustibil
            // 
            this.cmbBoxCombustibil.BackColor = System.Drawing.Color.White;
            this.cmbBoxCombustibil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxCombustibil.FormattingEnabled = true;
            this.cmbBoxCombustibil.Items.AddRange(new object[] {
            "100",
            "200"});
            this.cmbBoxCombustibil.Location = new System.Drawing.Point(16, 361);
            this.cmbBoxCombustibil.Name = "cmbBoxCombustibil";
            this.cmbBoxCombustibil.Size = new System.Drawing.Size(358, 32);
            this.cmbBoxCombustibil.TabIndex = 11;
            // 
            // cmbBoxAnStop
            // 
            this.cmbBoxAnStop.BackColor = System.Drawing.Color.White;
            this.cmbBoxAnStop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxAnStop.FormattingEnabled = true;
            this.cmbBoxAnStop.Items.AddRange(new object[] {
            "100",
            "200"});
            this.cmbBoxAnStop.Location = new System.Drawing.Point(223, 272);
            this.cmbBoxAnStop.Name = "cmbBoxAnStop";
            this.cmbBoxAnStop.Size = new System.Drawing.Size(151, 32);
            this.cmbBoxAnStop.TabIndex = 10;
            // 
            // cmbBoxAnStart
            // 
            this.cmbBoxAnStart.BackColor = System.Drawing.Color.White;
            this.cmbBoxAnStart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxAnStart.FormattingEnabled = true;
            this.cmbBoxAnStart.Items.AddRange(new object[] {
            "100",
            "200"});
            this.cmbBoxAnStart.Location = new System.Drawing.Point(16, 272);
            this.cmbBoxAnStart.Name = "cmbBoxAnStart";
            this.cmbBoxAnStart.Size = new System.Drawing.Size(151, 32);
            this.cmbBoxAnStart.TabIndex = 9;
            // 
            // lblPret
            // 
            this.lblPret.AutoSize = true;
            this.lblPret.Location = new System.Drawing.Point(406, 130);
            this.lblPret.Name = "lblPret";
            this.lblPret.Size = new System.Drawing.Size(52, 24);
            this.lblPret.TabIndex = 8;
            this.lblPret.Text = "Pret";
            // 
            // cmbBoxPretPanaLa
            // 
            this.cmbBoxPretPanaLa.BackColor = System.Drawing.Color.White;
            this.cmbBoxPretPanaLa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxPretPanaLa.FormattingEnabled = true;
            this.cmbBoxPretPanaLa.Items.AddRange(new object[] {
            "500",
            "600"});
            this.cmbBoxPretPanaLa.Location = new System.Drawing.Point(599, 161);
            this.cmbBoxPretPanaLa.Name = "cmbBoxPretPanaLa";
            this.cmbBoxPretPanaLa.Size = new System.Drawing.Size(151, 32);
            this.cmbBoxPretPanaLa.TabIndex = 7;
            // 
            // cmbBoxPretDeLa
            // 
            this.cmbBoxPretDeLa.BackColor = System.Drawing.Color.White;
            this.cmbBoxPretDeLa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxPretDeLa.FormattingEnabled = true;
            this.cmbBoxPretDeLa.Items.AddRange(new object[] {
            "100",
            "200"});
            this.cmbBoxPretDeLa.Location = new System.Drawing.Point(406, 161);
            this.cmbBoxPretDeLa.Name = "cmbBoxPretDeLa";
            this.cmbBoxPretDeLa.Size = new System.Drawing.Size(151, 32);
            this.cmbBoxPretDeLa.TabIndex = 6;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(406, 40);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(71, 24);
            this.lblModel.TabIndex = 5;
            this.lblModel.Text = "Model";
            // 
            // cmbBoxModel
            // 
            this.cmbBoxModel.BackColor = System.Drawing.Color.White;
            this.cmbBoxModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxModel.FormattingEnabled = true;
            this.cmbBoxModel.Items.AddRange(new object[] {
            "Car1",
            "Car2",
            "Car3"});
            this.cmbBoxModel.Location = new System.Drawing.Point(406, 71);
            this.cmbBoxModel.Name = "cmbBoxModel";
            this.cmbBoxModel.Size = new System.Drawing.Size(344, 32);
            this.cmbBoxModel.TabIndex = 4;
            // 
            // lblGeneratie
            // 
            this.lblGeneratie.AutoSize = true;
            this.lblGeneratie.Location = new System.Drawing.Point(16, 130);
            this.lblGeneratie.Name = "lblGeneratie";
            this.lblGeneratie.Size = new System.Drawing.Size(109, 24);
            this.lblGeneratie.TabIndex = 3;
            this.lblGeneratie.Text = "Generatie";
            // 
            // cmbBoxGeneratie
            // 
            this.cmbBoxGeneratie.BackColor = System.Drawing.Color.White;
            this.cmbBoxGeneratie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxGeneratie.FormattingEnabled = true;
            this.cmbBoxGeneratie.Items.AddRange(new object[] {
            "Veche",
            "Noua",
            "Istorica"});
            this.cmbBoxGeneratie.Location = new System.Drawing.Point(16, 161);
            this.cmbBoxGeneratie.Name = "cmbBoxGeneratie";
            this.cmbBoxGeneratie.Size = new System.Drawing.Size(358, 32);
            this.cmbBoxGeneratie.TabIndex = 2;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(16, 40);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(72, 24);
            this.lblMarca.TabIndex = 1;
            this.lblMarca.Text = "Marca";
            // 
            // cmbBoxMarca
            // 
            this.cmbBoxMarca.BackColor = System.Drawing.Color.White;
            this.cmbBoxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxMarca.FormattingEnabled = true;
            this.cmbBoxMarca.Items.AddRange(new object[] {
            "VW",
            "AUDI",
            "DACIA"});
            this.cmbBoxMarca.Location = new System.Drawing.Point(16, 71);
            this.cmbBoxMarca.Name = "cmbBoxMarca";
            this.cmbBoxMarca.Size = new System.Drawing.Size(358, 32);
            this.cmbBoxMarca.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 788);
            this.Controls.Add(this.grpBoxDropDownSelections);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpBoxDropDownSelections.ResumeLayout(false);
            this.grpBoxDropDownSelections.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxDropDownSelections;
        private System.Windows.Forms.Label lblGeneratie;
        private System.Windows.Forms.ComboBox cmbBoxGeneratie;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cmbBoxMarca;
        private System.Windows.Forms.CheckBox checkBoxEligibilFinantare;
        private System.Windows.Forms.Label lblAn;
        private System.Windows.Forms.ComboBox cmbBoxCombustibil;
        private System.Windows.Forms.ComboBox cmbBoxAnStop;
        private System.Windows.Forms.ComboBox cmbBoxAnStart;
        private System.Windows.Forms.Label lblPret;
        private System.Windows.Forms.ComboBox cmbBoxPretPanaLa;
        private System.Windows.Forms.ComboBox cmbBoxPretDeLa;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.ComboBox cmbBoxModel;
        private System.Windows.Forms.Label lblCombustibil;
        private System.Windows.Forms.Button btnCauta;
    }
}

