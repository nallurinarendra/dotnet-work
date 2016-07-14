namespace ProductbillForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_ProdcutNo = new System.Windows.Forms.TextBox();
            this.textBox_ProductName = new System.Windows.Forms.TextBox();
            this.textBox_Rate = new System.Windows.Forms.TextBox();
            this.textBox_Quantity = new System.Windows.Forms.TextBox();
            this.textBox_BillAmount = new System.Windows.Forms.TextBox();
            this.button_Next = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Product Rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Bill Amount";
            // 
            // textBox_ProdcutNo
            // 
            this.textBox_ProdcutNo.Location = new System.Drawing.Point(182, 52);
            this.textBox_ProdcutNo.Name = "textBox_ProdcutNo";
            this.textBox_ProdcutNo.Size = new System.Drawing.Size(137, 20);
            this.textBox_ProdcutNo.TabIndex = 5;
            this.textBox_ProdcutNo.TextChanged += new System.EventHandler(this.textBox_ProdcutNo_TextChanged);
            this.textBox_ProdcutNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_ProdcutNo_KeyPress);
            // 
            // textBox_ProductName
            // 
            this.textBox_ProductName.Location = new System.Drawing.Point(182, 87);
            this.textBox_ProductName.Name = "textBox_ProductName";
            this.textBox_ProductName.Size = new System.Drawing.Size(137, 20);
            this.textBox_ProductName.TabIndex = 6;
            // 
            // textBox_Rate
            // 
            this.textBox_Rate.Location = new System.Drawing.Point(182, 122);
            this.textBox_Rate.Name = "textBox_Rate";
            this.textBox_Rate.Size = new System.Drawing.Size(137, 20);
            this.textBox_Rate.TabIndex = 7;
            this.textBox_Rate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Rate_KeyPress);
            // 
            // textBox_Quantity
            // 
            this.textBox_Quantity.Location = new System.Drawing.Point(182, 156);
            this.textBox_Quantity.Name = "textBox_Quantity";
            this.textBox_Quantity.Size = new System.Drawing.Size(137, 20);
            this.textBox_Quantity.TabIndex = 8;
            this.textBox_Quantity.TextChanged += new System.EventHandler(this.textBox_Quantity_TextChanged);
            this.textBox_Quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Quantity_KeyPress);
            // 
            // textBox_BillAmount
            // 
            this.textBox_BillAmount.Enabled = false;
            this.textBox_BillAmount.Location = new System.Drawing.Point(182, 186);
            this.textBox_BillAmount.Name = "textBox_BillAmount";
            this.textBox_BillAmount.Size = new System.Drawing.Size(137, 20);
            this.textBox_BillAmount.TabIndex = 9;
            this.textBox_BillAmount.Text = " ";
            // 
            // button_Next
            // 
            this.button_Next.Location = new System.Drawing.Point(83, 274);
            this.button_Next.Name = "button_Next";
            this.button_Next.Size = new System.Drawing.Size(75, 23);
            this.button_Next.TabIndex = 10;
            this.button_Next.Text = "Next";
            this.button_Next.UseVisualStyleBackColor = true;
            this.button_Next.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_Next_MouseClick);
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(200, 274);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(75, 23);
            this.button_Exit.TabIndex = 11;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(345, 375);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_Next);
            this.Controls.Add(this.textBox_BillAmount);
            this.Controls.Add(this.textBox_Quantity);
            this.Controls.Add(this.textBox_Rate);
            this.Controls.Add(this.textBox_ProductName);
            this.Controls.Add(this.textBox_ProdcutNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Bill Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_ProdcutNo;
        private System.Windows.Forms.TextBox textBox_ProductName;
        private System.Windows.Forms.TextBox textBox_Rate;
        private System.Windows.Forms.TextBox textBox_Quantity;
        private System.Windows.Forms.TextBox textBox_BillAmount;
        private System.Windows.Forms.Button button_Next;
        private System.Windows.Forms.Button button_Exit;
    }
}

