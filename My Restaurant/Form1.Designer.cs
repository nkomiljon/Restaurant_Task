namespace My_Restaurant
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonEgg = new System.Windows.Forms.RadioButton();
            this.radioButtonChicken = new System.Windows.Forms.RadioButton();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtBoxQuantity = new System.Windows.Forms.TextBox();
            this.btnNewRequest = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.resultlblQuality = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxResults = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonEgg);
            this.groupBox1.Controls.Add(this.radioButtonChicken);
            this.groupBox1.Location = new System.Drawing.Point(24, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 89);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // radioButtonEgg
            // 
            this.radioButtonEgg.AutoSize = true;
            this.radioButtonEgg.Location = new System.Drawing.Point(120, 43);
            this.radioButtonEgg.Name = "radioButtonEgg";
            this.radioButtonEgg.Size = new System.Drawing.Size(44, 17);
            this.radioButtonEgg.TabIndex = 1;
            this.radioButtonEgg.TabStop = true;
            this.radioButtonEgg.Text = "Egg";
            this.radioButtonEgg.UseVisualStyleBackColor = true;
            // 
            // radioButtonChicken
            // 
            this.radioButtonChicken.AutoSize = true;
            this.radioButtonChicken.Location = new System.Drawing.Point(26, 43);
            this.radioButtonChicken.Name = "radioButtonChicken";
            this.radioButtonChicken.Size = new System.Drawing.Size(64, 17);
            this.radioButtonChicken.TabIndex = 0;
            this.radioButtonChicken.TabStop = true;
            this.radioButtonChicken.Text = "Chicken";
            this.radioButtonChicken.UseVisualStyleBackColor = true;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(21, 150);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 1;
            this.lblQuantity.Text = "Quantity";
            // 
            // txtBoxQuantity
            // 
            this.txtBoxQuantity.Location = new System.Drawing.Point(73, 147);
            this.txtBoxQuantity.Name = "txtBoxQuantity";
            this.txtBoxQuantity.Size = new System.Drawing.Size(115, 20);
            this.txtBoxQuantity.TabIndex = 2;
            // 
            // btnNewRequest
            // 
            this.btnNewRequest.Location = new System.Drawing.Point(218, 147);
            this.btnNewRequest.Name = "btnNewRequest";
            this.btnNewRequest.Size = new System.Drawing.Size(135, 23);
            this.btnNewRequest.TabIndex = 3;
            this.btnNewRequest.Text = "Submit new request";
            this.btnNewRequest.UseVisualStyleBackColor = true;
            this.btnNewRequest.Click += new System.EventHandler(this.btnNewRequest_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(24, 193);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(329, 26);
            this.btnCopy.TabIndex = 4;
            this.btnCopy.Text = "Copy the previous request";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Egg Quality:";
            // 
            // resultlblQuality
            // 
            this.resultlblQuality.AutoSize = true;
            this.resultlblQuality.Location = new System.Drawing.Point(95, 244);
            this.resultlblQuality.Name = "resultlblQuality";
            this.resultlblQuality.Size = new System.Drawing.Size(19, 13);
            this.resultlblQuality.TabIndex = 6;
            this.resultlblQuality.Text = "65";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 274);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(329, 26);
            this.button2.TabIndex = 7;
            this.button2.Text = "Prepare Food";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Results";
            // 
            // txtBoxResults
            // 
            this.txtBoxResults.Location = new System.Drawing.Point(24, 346);
            this.txtBoxResults.Multiline = true;
            this.txtBoxResults.Name = "txtBoxResults";
            this.txtBoxResults.Size = new System.Drawing.Size(330, 110);
            this.txtBoxResults.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 467);
            this.Controls.Add(this.txtBoxResults);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.resultlblQuality);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnNewRequest);
            this.Controls.Add(this.txtBoxQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(415, 515);
            this.Name = "Form1";
            this.Text = "MacDonalds";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonChicken;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtBoxQuantity;
        private System.Windows.Forms.Button btnNewRequest;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label resultlblQuality;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxResults;
        private System.Windows.Forms.RadioButton radioButtonEgg;
    }
}

