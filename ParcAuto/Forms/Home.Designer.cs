
namespace ParcAuto
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblPret = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtBoxNume = new System.Windows.Forms.TextBox();
            this.txtBoxPret = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblAddMarca = new System.Windows.Forms.Label();
            this.lblAddPret = new System.Windows.Forms.Label();
            this.lblAddMotor = new System.Windows.Forms.Label();
            this.lblAddCuloare = new System.Windows.Forms.Label();
            this.lblAddAnFabricatie = new System.Windows.Forms.Label();
            this.lblAddTractiune = new System.Windows.Forms.Label();
            this.txtBoxAddMarca = new System.Windows.Forms.TextBox();
            this.txtBoxAddPret = new System.Windows.Forms.TextBox();
            this.txtBoxAddMotor = new System.Windows.Forms.TextBox();
            this.txtBoxAddCuloare = new System.Windows.Forms.TextBox();
            this.txtBoxAnFabricatie = new System.Windows.Forms.TextBox();
            this.txtBoxAddTractiune = new System.Windows.Forms.TextBox();
            this.rpBoxStatus = new System.Windows.Forms.GroupBox();
            this.rdoBtnFalse = new System.Windows.Forms.RadioButton();
            this.rdoBtnTrue = new System.Windows.Forms.RadioButton();
            this.lblDeleteMarca = new System.Windows.Forms.Label();
            this.txtBoxDeleteMarca = new System.Windows.Forms.TextBox();
            this.btnDeleteMarca = new System.Windows.Forms.Button();
            this.rpBoxStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(795, 487);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(169, 71);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(12, 125);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(50, 20);
            this.lblMarca.TabIndex = 1;
            this.lblMarca.Text = "Marca";
            // 
            // lblPret
            // 
            this.lblPret.AutoSize = true;
            this.lblPret.Location = new System.Drawing.Point(126, 125);
            this.lblPret.Name = "lblPret";
            this.lblPret.Size = new System.Drawing.Size(35, 20);
            this.lblPret.TabIndex = 2;
            this.lblPret.Text = "Pret";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(811, 137);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(138, 32);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtBoxNume
            // 
            this.txtBoxNume.Location = new System.Drawing.Point(12, 160);
            this.txtBoxNume.Name = "txtBoxNume";
            this.txtBoxNume.Size = new System.Drawing.Size(98, 27);
            this.txtBoxNume.TabIndex = 4;
            this.txtBoxNume.TextChanged += new System.EventHandler(this.txtBoxNume_TextChanged);
            // 
            // txtBoxPret
            // 
            this.txtBoxPret.Location = new System.Drawing.Point(126, 160);
            this.txtBoxPret.Name = "txtBoxPret";
            this.txtBoxPret.Size = new System.Drawing.Size(105, 27);
            this.txtBoxPret.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(811, 61);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(138, 33);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblAddMarca
            // 
            this.lblAddMarca.AutoSize = true;
            this.lblAddMarca.Location = new System.Drawing.Point(3, 18);
            this.lblAddMarca.Name = "lblAddMarca";
            this.lblAddMarca.Size = new System.Drawing.Size(82, 20);
            this.lblAddMarca.TabIndex = 7;
            this.lblAddMarca.Text = "Add Marca";
            // 
            // lblAddPret
            // 
            this.lblAddPret.AutoSize = true;
            this.lblAddPret.Location = new System.Drawing.Point(98, 18);
            this.lblAddPret.Name = "lblAddPret";
            this.lblAddPret.Size = new System.Drawing.Size(67, 20);
            this.lblAddPret.TabIndex = 8;
            this.lblAddPret.Text = "Add Pret";
            // 
            // lblAddMotor
            // 
            this.lblAddMotor.AutoSize = true;
            this.lblAddMotor.Location = new System.Drawing.Point(186, 18);
            this.lblAddMotor.Name = "lblAddMotor";
            this.lblAddMotor.Size = new System.Drawing.Size(82, 20);
            this.lblAddMotor.TabIndex = 9;
            this.lblAddMotor.Text = "Add Motor";
            // 
            // lblAddCuloare
            // 
            this.lblAddCuloare.AutoSize = true;
            this.lblAddCuloare.Location = new System.Drawing.Point(284, 18);
            this.lblAddCuloare.Name = "lblAddCuloare";
            this.lblAddCuloare.Size = new System.Drawing.Size(92, 20);
            this.lblAddCuloare.TabIndex = 10;
            this.lblAddCuloare.Text = "Add Culoare";
            this.lblAddCuloare.Click += new System.EventHandler(this.lblAddCuloare_Click);
            // 
            // lblAddAnFabricatie
            // 
            this.lblAddAnFabricatie.AutoSize = true;
            this.lblAddAnFabricatie.Location = new System.Drawing.Point(382, 18);
            this.lblAddAnFabricatie.Name = "lblAddAnFabricatie";
            this.lblAddAnFabricatie.Size = new System.Drawing.Size(127, 20);
            this.lblAddAnFabricatie.TabIndex = 11;
            this.lblAddAnFabricatie.Text = "Add An Fabricatie";
            // 
            // lblAddTractiune
            // 
            this.lblAddTractiune.AutoSize = true;
            this.lblAddTractiune.Location = new System.Drawing.Point(505, 18);
            this.lblAddTractiune.Name = "lblAddTractiune";
            this.lblAddTractiune.Size = new System.Drawing.Size(101, 20);
            this.lblAddTractiune.TabIndex = 12;
            this.lblAddTractiune.Text = "Add Tractiune";
            // 
            // txtBoxAddMarca
            // 
            this.txtBoxAddMarca.Location = new System.Drawing.Point(3, 67);
            this.txtBoxAddMarca.Name = "txtBoxAddMarca";
            this.txtBoxAddMarca.Size = new System.Drawing.Size(82, 27);
            this.txtBoxAddMarca.TabIndex = 14;
            // 
            // txtBoxAddPret
            // 
            this.txtBoxAddPret.Location = new System.Drawing.Point(98, 67);
            this.txtBoxAddPret.Name = "txtBoxAddPret";
            this.txtBoxAddPret.Size = new System.Drawing.Size(79, 27);
            this.txtBoxAddPret.TabIndex = 15;
            // 
            // txtBoxAddMotor
            // 
            this.txtBoxAddMotor.Location = new System.Drawing.Point(183, 67);
            this.txtBoxAddMotor.Name = "txtBoxAddMotor";
            this.txtBoxAddMotor.Size = new System.Drawing.Size(85, 27);
            this.txtBoxAddMotor.TabIndex = 16;
            // 
            // txtBoxAddCuloare
            // 
            this.txtBoxAddCuloare.Location = new System.Drawing.Point(284, 67);
            this.txtBoxAddCuloare.Name = "txtBoxAddCuloare";
            this.txtBoxAddCuloare.Size = new System.Drawing.Size(82, 27);
            this.txtBoxAddCuloare.TabIndex = 17;
            // 
            // txtBoxAnFabricatie
            // 
            this.txtBoxAnFabricatie.Location = new System.Drawing.Point(403, 67);
            this.txtBoxAnFabricatie.Name = "txtBoxAnFabricatie";
            this.txtBoxAnFabricatie.Size = new System.Drawing.Size(84, 27);
            this.txtBoxAnFabricatie.TabIndex = 18;
            // 
            // txtBoxAddTractiune
            // 
            this.txtBoxAddTractiune.Location = new System.Drawing.Point(505, 67);
            this.txtBoxAddTractiune.Name = "txtBoxAddTractiune";
            this.txtBoxAddTractiune.Size = new System.Drawing.Size(84, 27);
            this.txtBoxAddTractiune.TabIndex = 19;
            // 
            // rpBoxStatus
            // 
            this.rpBoxStatus.Controls.Add(this.rdoBtnFalse);
            this.rpBoxStatus.Controls.Add(this.rdoBtnTrue);
            this.rpBoxStatus.Location = new System.Drawing.Point(612, 18);
            this.rpBoxStatus.Name = "rpBoxStatus";
            this.rpBoxStatus.Size = new System.Drawing.Size(177, 83);
            this.rpBoxStatus.TabIndex = 21;
            this.rpBoxStatus.TabStop = false;
            this.rpBoxStatus.Text = "Status";
            // 
            // rdoBtnFalse
            // 
            this.rdoBtnFalse.AutoSize = true;
            this.rdoBtnFalse.Location = new System.Drawing.Point(6, 47);
            this.rdoBtnFalse.Name = "rdoBtnFalse";
            this.rdoBtnFalse.Size = new System.Drawing.Size(62, 24);
            this.rdoBtnFalse.TabIndex = 1;
            this.rdoBtnFalse.TabStop = true;
            this.rdoBtnFalse.Text = "False";
            this.rdoBtnFalse.UseVisualStyleBackColor = true;
            // 
            // rdoBtnTrue
            // 
            this.rdoBtnTrue.AutoSize = true;
            this.rdoBtnTrue.Location = new System.Drawing.Point(6, 17);
            this.rdoBtnTrue.Name = "rdoBtnTrue";
            this.rdoBtnTrue.Size = new System.Drawing.Size(58, 24);
            this.rdoBtnTrue.TabIndex = 0;
            this.rdoBtnTrue.TabStop = true;
            this.rdoBtnTrue.Text = "True";
            this.rdoBtnTrue.UseVisualStyleBackColor = true;
            // 
            // lblDeleteMarca
            // 
            this.lblDeleteMarca.AutoSize = true;
            this.lblDeleteMarca.Location = new System.Drawing.Point(12, 240);
            this.lblDeleteMarca.Name = "lblDeleteMarca";
            this.lblDeleteMarca.Size = new System.Drawing.Size(98, 20);
            this.lblDeleteMarca.TabIndex = 22;
            this.lblDeleteMarca.Text = "Delete Marca";
            // 
            // txtBoxDeleteMarca
            // 
            this.txtBoxDeleteMarca.Location = new System.Drawing.Point(12, 263);
            this.txtBoxDeleteMarca.Name = "txtBoxDeleteMarca";
            this.txtBoxDeleteMarca.Size = new System.Drawing.Size(125, 27);
            this.txtBoxDeleteMarca.TabIndex = 23;
            // 
            // btnDeleteMarca
            // 
            this.btnDeleteMarca.Location = new System.Drawing.Point(811, 261);
            this.btnDeleteMarca.Name = "btnDeleteMarca";
            this.btnDeleteMarca.Size = new System.Drawing.Size(138, 29);
            this.btnDeleteMarca.TabIndex = 24;
            this.btnDeleteMarca.Text = "Delete";
            this.btnDeleteMarca.UseVisualStyleBackColor = true;
            this.btnDeleteMarca.Click += new System.EventHandler(this.btnDeleteMarca_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 570);
            this.Controls.Add(this.btnDeleteMarca);
            this.Controls.Add(this.txtBoxDeleteMarca);
            this.Controls.Add(this.lblDeleteMarca);
            this.Controls.Add(this.rpBoxStatus);
            this.Controls.Add(this.txtBoxAddTractiune);
            this.Controls.Add(this.txtBoxAnFabricatie);
            this.Controls.Add(this.txtBoxAddCuloare);
            this.Controls.Add(this.txtBoxAddMotor);
            this.Controls.Add(this.txtBoxAddPret);
            this.Controls.Add(this.txtBoxAddMarca);
            this.Controls.Add(this.lblAddTractiune);
            this.Controls.Add(this.lblAddAnFabricatie);
            this.Controls.Add(this.lblAddCuloare);
            this.Controls.Add(this.lblAddMotor);
            this.Controls.Add(this.lblAddPret);
            this.Controls.Add(this.lblAddMarca);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtBoxPret);
            this.Controls.Add(this.txtBoxNume);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblPret);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.btnPrint);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.rpBoxStatus.ResumeLayout(false);
            this.rpBoxStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblPret;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtBoxNume;
        private System.Windows.Forms.TextBox txtBoxPret;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblAddMarca;
        private System.Windows.Forms.Label lblAddPret;
        private System.Windows.Forms.Label lblAddMotor;
        private System.Windows.Forms.Label lblAddCuloare;
        private System.Windows.Forms.Label lblAddAnFabricatie;
        private System.Windows.Forms.Label lblAddTractiune;
        private System.Windows.Forms.TextBox txtBoxAddMarca;
        private System.Windows.Forms.TextBox txtBoxAddPret;
        private System.Windows.Forms.TextBox txtBoxAddMotor;
        private System.Windows.Forms.TextBox txtBoxAddCuloare;
        private System.Windows.Forms.TextBox txtBoxAnFabricatie;
        private System.Windows.Forms.TextBox txtBoxAddTractiune;
        private System.Windows.Forms.GroupBox rpBoxStatus;
        private System.Windows.Forms.RadioButton rdoBtnFalse;
        private System.Windows.Forms.RadioButton rdoBtnTrue;
        private System.Windows.Forms.Label lblDeleteMarca;
        private System.Windows.Forms.TextBox txtBoxDeleteMarca;
        private System.Windows.Forms.Button btnDeleteMarca;
    }
}