namespace MySimpleOPCClientC
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
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtWriteVal = new System.Windows.Forms.TextBox();
            this.txtReadVal = new System.Windows.Forms.TextBox();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(146, 314);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(111, 35);
            this.btnWrite.TabIndex = 23;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnRead
            // 
            this.btnRead.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRead.Location = new System.Drawing.Point(33, 260);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(111, 35);
            this.btnRead.TabIndex = 21;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAddItem.Location = new System.Drawing.Point(33, 198);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(224, 35);
            this.btnAddItem.TabIndex = 20;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(144, 113);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(111, 35);
            this.btnDisconnect.TabIndex = 18;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnConnect.Location = new System.Drawing.Point(33, 113);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(111, 35);
            this.btnConnect.TabIndex = 17;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtWriteVal
            // 
            this.txtWriteVal.Location = new System.Drawing.Point(33, 314);
            this.txtWriteVal.Name = "txtWriteVal";
            this.txtWriteVal.Size = new System.Drawing.Size(96, 20);
            this.txtWriteVal.TabIndex = 22;
            // 
            // txtReadVal
            // 
            this.txtReadVal.Location = new System.Drawing.Point(164, 263);
            this.txtReadVal.Name = "txtReadVal";
            this.txtReadVal.Size = new System.Drawing.Size(96, 20);
            this.txtReadVal.TabIndex = 24;
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(101, 172);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(156, 20);
            this.txtItem.TabIndex = 19;
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(99, 16);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(156, 20);
            this.txtServer.TabIndex = 25;
            this.txtServer.Text = "127.0.0.1";
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(99, 64);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(156, 20);
            this.txtServerName.TabIndex = 11;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(30, 337);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(67, 13);
            this.Label5.TabIndex = 12;
            this.Label5.Text = "(Write value)";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(30, 175);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(52, 13);
            this.Label3.TabIndex = 13;
            this.Label3.Text = "OPC Item";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(158, 285);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(68, 13);
            this.Label4.TabIndex = 10;
            this.Label4.Text = "(Read value)";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(96, 87);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(100, 13);
            this.Label6.TabIndex = 15;
            this.Label6.Text = "(OPC Server Name)";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(96, 39);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(129, 13);
            this.Label2.TabIndex = 16;
            this.Label2.Text = "(Host name or IP address)";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(30, 19);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(63, 13);
            this.Label1.TabIndex = 14;
            this.Label1.Text = "OPC Server";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 383);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtWriteVal);
            this.Controls.Add(this.txtReadVal);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.txtServerName);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "My Simple OPC Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnWrite;
        internal System.Windows.Forms.Button btnRead;
        internal System.Windows.Forms.Button btnAddItem;
        internal System.Windows.Forms.Button btnDisconnect;
        internal System.Windows.Forms.Button btnConnect;
        internal System.Windows.Forms.TextBox txtWriteVal;
        internal System.Windows.Forms.TextBox txtReadVal;
        internal System.Windows.Forms.TextBox txtItem;
        internal System.Windows.Forms.TextBox txtServer;
        internal System.Windows.Forms.TextBox txtServerName;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
    }
}

