namespace WCFClient
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
            this.rbHttp = new System.Windows.Forms.RadioButton();
            this.rbTcp = new System.Windows.Forms.RadioButton();
            this.btExecute = new System.Windows.Forms.Button();
            this.cbOperations = new System.Windows.Forms.ComboBox();
            this.tbNum1 = new System.Windows.Forms.TextBox();
            this.tbNum2 = new System.Windows.Forms.TextBox();
            this.lbOperation = new System.Windows.Forms.Label();
            this.lbNum1 = new System.Windows.Forms.Label();
            this.lbNum2 = new System.Windows.Forms.Label();
            this.lbProtocolSelected = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbHttp
            // 
            this.rbHttp.AutoSize = true;
            this.rbHttp.Checked = true;
            this.rbHttp.Location = new System.Drawing.Point(22, 24);
            this.rbHttp.Name = "rbHttp";
            this.rbHttp.Size = new System.Drawing.Size(45, 17);
            this.rbHttp.TabIndex = 0;
            this.rbHttp.TabStop = true;
            this.rbHttp.Text = "Http";
            this.rbHttp.UseVisualStyleBackColor = true;
            this.rbHttp.CheckedChanged += new System.EventHandler(this.protocol_CheckedChanged);
            // 
            // rbTcp
            // 
            this.rbTcp.AutoSize = true;
            this.rbTcp.Location = new System.Drawing.Point(22, 47);
            this.rbTcp.Name = "rbTcp";
            this.rbTcp.Size = new System.Drawing.Size(44, 17);
            this.rbTcp.TabIndex = 1;
            this.rbTcp.Text = "Tcp";
            this.rbTcp.UseVisualStyleBackColor = true;
            this.rbTcp.CheckedChanged += new System.EventHandler(this.protocol_CheckedChanged);
            // 
            // btExecute
            // 
            this.btExecute.Location = new System.Drawing.Point(334, 84);
            this.btExecute.Name = "btExecute";
            this.btExecute.Size = new System.Drawing.Size(75, 23);
            this.btExecute.TabIndex = 2;
            this.btExecute.Text = "Ejecutar";
            this.btExecute.UseVisualStyleBackColor = true;
            this.btExecute.Click += new System.EventHandler(this.btExecute_Click);
            // 
            // cbOperations
            // 
            this.cbOperations.FormattingEnabled = true;
            this.cbOperations.Location = new System.Drawing.Point(169, 43);
            this.cbOperations.Name = "cbOperations";
            this.cbOperations.Size = new System.Drawing.Size(121, 21);
            this.cbOperations.TabIndex = 3;
            // 
            // tbNum1
            // 
            this.tbNum1.Location = new System.Drawing.Point(169, 91);
            this.tbNum1.Name = "tbNum1";
            this.tbNum1.Size = new System.Drawing.Size(121, 20);
            this.tbNum1.TabIndex = 4;
            // 
            // tbNum2
            // 
            this.tbNum2.Location = new System.Drawing.Point(169, 135);
            this.tbNum2.Name = "tbNum2";
            this.tbNum2.Size = new System.Drawing.Size(121, 20);
            this.tbNum2.TabIndex = 5;
            // 
            // lbOperation
            // 
            this.lbOperation.AutoSize = true;
            this.lbOperation.Location = new System.Drawing.Point(107, 48);
            this.lbOperation.Name = "lbOperation";
            this.lbOperation.Size = new System.Drawing.Size(56, 13);
            this.lbOperation.TabIndex = 6;
            this.lbOperation.Text = "Operación";
            // 
            // lbNum1
            // 
            this.lbNum1.AutoSize = true;
            this.lbNum1.Location = new System.Drawing.Point(107, 94);
            this.lbNum1.Name = "lbNum1";
            this.lbNum1.Size = new System.Drawing.Size(53, 13);
            this.lbNum1.TabIndex = 7;
            this.lbNum1.Text = "Numero 1";
            // 
            // lbNum2
            // 
            this.lbNum2.AutoSize = true;
            this.lbNum2.Location = new System.Drawing.Point(107, 138);
            this.lbNum2.Name = "lbNum2";
            this.lbNum2.Size = new System.Drawing.Size(53, 13);
            this.lbNum2.TabIndex = 8;
            this.lbNum2.Text = "Numero 2";
            // 
            // lbProtocolSelected
            // 
            this.lbProtocolSelected.AutoSize = true;
            this.lbProtocolSelected.Location = new System.Drawing.Point(461, 89);
            this.lbProtocolSelected.Name = "lbProtocolSelected";
            this.lbProtocolSelected.Size = new System.Drawing.Size(121, 13);
            this.lbProtocolSelected.TabIndex = 9;
            this.lbProtocolSelected.Text = "Protocolo seleccionado:";
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(340, 123);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(58, 13);
            this.lbResult.TabIndex = 10;
            this.lbResult.Text = "Resultado:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 184);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.lbProtocolSelected);
            this.Controls.Add(this.lbNum2);
            this.Controls.Add(this.lbNum1);
            this.Controls.Add(this.lbOperation);
            this.Controls.Add(this.tbNum2);
            this.Controls.Add(this.tbNum1);
            this.Controls.Add(this.cbOperations);
            this.Controls.Add(this.btExecute);
            this.Controls.Add(this.rbTcp);
            this.Controls.Add(this.rbHttp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbHttp;
        private System.Windows.Forms.RadioButton rbTcp;
        private System.Windows.Forms.Button btExecute;
        private System.Windows.Forms.ComboBox cbOperations;
        private System.Windows.Forms.TextBox tbNum1;
        private System.Windows.Forms.TextBox tbNum2;
        private System.Windows.Forms.Label lbOperation;
        private System.Windows.Forms.Label lbNum1;
        private System.Windows.Forms.Label lbNum2;
        private System.Windows.Forms.Label lbProtocolSelected;
        private System.Windows.Forms.Label lbResult;
    }
}

