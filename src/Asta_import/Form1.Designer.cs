namespace Asta_import
{
    partial class Form1
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
            this.txtBxInFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBxOutFile = new System.Windows.Forms.TextBox();
            this.btnStartConv = new System.Windows.Forms.Button();
            this.txtBxLog = new System.Windows.Forms.TextBox();
            this.txtBxKomNr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBxSted = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBxAdresse = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBxFylke = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBxLand = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBxDepInst = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBxUrn = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.rdbNewSch = new System.Windows.Forms.RadioButton();
            this.rdbOldSch = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBxInFile
            // 
            this.txtBxInFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBxInFile.Location = new System.Drawing.Point(98, 12);
            this.txtBxInFile.Name = "txtBxInFile";
            this.txtBxInFile.ReadOnly = true;
            this.txtBxInFile.Size = new System.Drawing.Size(503, 20);
            this.txtBxInFile.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fil Inn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Navn resultatfil:";
            // 
            // txtBxOutFile
            // 
            this.txtBxOutFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBxOutFile.Location = new System.Drawing.Point(98, 49);
            this.txtBxOutFile.Name = "txtBxOutFile";
            this.txtBxOutFile.Size = new System.Drawing.Size(503, 20);
            this.txtBxOutFile.TabIndex = 4;
            // 
            // btnStartConv
            // 
            this.btnStartConv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStartConv.Location = new System.Drawing.Point(16, 289);
            this.btnStartConv.Name = "btnStartConv";
            this.btnStartConv.Size = new System.Drawing.Size(131, 53);
            this.btnStartConv.TabIndex = 5;
            this.btnStartConv.Text = "Start konvertering";
            this.btnStartConv.UseVisualStyleBackColor = true;
            this.btnStartConv.Click += new System.EventHandler(this.btnStartConv_Click);
            // 
            // txtBxLog
            // 
            this.txtBxLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBxLog.Location = new System.Drawing.Point(153, 289);
            this.txtBxLog.Multiline = true;
            this.txtBxLog.Name = "txtBxLog";
            this.txtBxLog.ReadOnly = true;
            this.txtBxLog.Size = new System.Drawing.Size(496, 53);
            this.txtBxLog.TabIndex = 6;
            // 
            // txtBxKomNr
            // 
            this.txtBxKomNr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBxKomNr.Location = new System.Drawing.Point(103, 39);
            this.txtBxKomNr.MaxLength = 4;
            this.txtBxKomNr.Name = "txtBxKomNr";
            this.txtBxKomNr.Size = new System.Drawing.Size(96, 20);
            this.txtBxKomNr.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kommunenr:";
            // 
            // txtBxSted
            // 
            this.txtBxSted.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBxSted.Location = new System.Drawing.Point(321, 100);
            this.txtBxSted.Name = "txtBxSted";
            this.txtBxSted.Size = new System.Drawing.Size(96, 20);
            this.txtBxSted.TabIndex = 10;
            this.txtBxSted.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sted:";
            this.label4.Visible = false;
            // 
            // txtBxAdresse
            // 
            this.txtBxAdresse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBxAdresse.Location = new System.Drawing.Point(103, 71);
            this.txtBxAdresse.Name = "txtBxAdresse";
            this.txtBxAdresse.Size = new System.Drawing.Size(96, 20);
            this.txtBxAdresse.TabIndex = 12;
            this.txtBxAdresse.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Adresse:";
            this.label5.Visible = false;
            // 
            // txtBxFylke
            // 
            this.txtBxFylke.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBxFylke.Location = new System.Drawing.Point(103, 8);
            this.txtBxFylke.MaxLength = 4;
            this.txtBxFylke.Name = "txtBxFylke";
            this.txtBxFylke.Size = new System.Drawing.Size(96, 20);
            this.txtBxFylke.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Fylkesnr:";
            // 
            // txtBxLand
            // 
            this.txtBxLand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBxLand.Location = new System.Drawing.Point(321, 8);
            this.txtBxLand.Name = "txtBxLand";
            this.txtBxLand.Size = new System.Drawing.Size(96, 20);
            this.txtBxLand.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(239, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Landkode:";
            // 
            // txtBxDepInst
            // 
            this.txtBxDepInst.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBxDepInst.Location = new System.Drawing.Point(321, 39);
            this.txtBxDepInst.Name = "txtBxDepInst";
            this.txtBxDepInst.Size = new System.Drawing.Size(96, 20);
            this.txtBxDepInst.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(239, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Depotinstitusjon:";
            // 
            // txtBxUrn
            // 
            this.txtBxUrn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBxUrn.Location = new System.Drawing.Point(321, 71);
            this.txtBxUrn.Name = "txtBxUrn";
            this.txtBxUrn.Size = new System.Drawing.Size(96, 20);
            this.txtBxUrn.TabIndex = 20;
            this.txtBxUrn.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(239, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Urn:";
            this.label9.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtBxUrn);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtBxDepInst);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtBxLand);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtBxFylke);
            this.panel1.Controls.Add(this.txtBxAdresse);
            this.panel1.Controls.Add(this.txtBxSted);
            this.panel1.Controls.Add(this.txtBxKomNr);
            this.panel1.Location = new System.Drawing.Point(14, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 137);
            this.panel1.TabIndex = 21;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // rdbNewSch
            // 
            this.rdbNewSch.AutoSize = true;
            this.rdbNewSch.Checked = true;
            this.rdbNewSch.Location = new System.Drawing.Point(16, 235);
            this.rdbNewSch.Name = "rdbNewSch";
            this.rdbNewSch.Size = new System.Drawing.Size(80, 17);
            this.rdbNewSch.TabIndex = 22;
            this.rdbNewSch.TabStop = true;
            this.rdbNewSch.Text = "Nytt skjema";
            this.rdbNewSch.UseVisualStyleBackColor = true;
            // 
            // rdbOldSch
            // 
            this.rdbOldSch.AutoSize = true;
            this.rdbOldSch.Location = new System.Drawing.Point(16, 258);
            this.rdbOldSch.Name = "rdbOldSch";
            this.rdbOldSch.Size = new System.Drawing.Size(102, 17);
            this.rdbOldSch.TabIndex = 23;
            this.rdbOldSch.Text = "Gammelt skjema";
            this.rdbOldSch.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 355);
            this.Controls.Add(this.rdbOldSch);
            this.Controls.Add(this.rdbNewSch);
            this.Controls.Add(this.txtBxLog);
            this.Controls.Add(this.btnStartConv);
            this.Controls.Add(this.txtBxOutFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBxInFile);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBxInFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBxOutFile;
        private System.Windows.Forms.Button btnStartConv;
        private System.Windows.Forms.TextBox txtBxLog;
        private System.Windows.Forms.TextBox txtBxKomNr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBxSted;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBxAdresse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBxFylke;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBxLand;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBxDepInst;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBxUrn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton rdbNewSch;
        private System.Windows.Forms.RadioButton rdbOldSch;
    }
}

