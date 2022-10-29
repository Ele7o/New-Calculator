namespace Calculator
{
    partial class Form
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
            this.pastCal = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.numOne = new System.Windows.Forms.TextBox();
            this.numTwo = new System.Windows.Forms.TextBox();
            this.labelOne = new System.Windows.Forms.Label();
            this.lableTwo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pastCal
            // 
            this.pastCal.AutoSize = true;
            this.pastCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.pastCal.Location = new System.Drawing.Point(225, 19);
            this.pastCal.Name = "pastCal";
            this.pastCal.Size = new System.Drawing.Size(0, 22);
            this.pastCal.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.btnAdd.Location = new System.Drawing.Point(30, 200);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(114, 98);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSub
            // 
            this.btnSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.btnSub.Location = new System.Drawing.Point(226, 200);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(114, 98);
            this.btnSub.TabIndex = 2;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.btnMulti.Location = new System.Drawing.Point(422, 200);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(114, 98);
            this.btnMulti.TabIndex = 3;
            this.btnMulti.Text = "X";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.btnDiv.Location = new System.Drawing.Point(618, 200);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(114, 98);
            this.btnDiv.TabIndex = 4;
            this.btnDiv.Text = "÷";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // numOne
            // 
            this.numOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.numOne.Location = new System.Drawing.Point(229, 67);
            this.numOne.Name = "numOne";
            this.numOne.Size = new System.Drawing.Size(368, 38);
            this.numOne.TabIndex = 5;
            // 
            // numTwo
            // 
            this.numTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.numTwo.Location = new System.Drawing.Point(229, 125);
            this.numTwo.Name = "numTwo";
            this.numTwo.Size = new System.Drawing.Size(368, 38);
            this.numTwo.TabIndex = 6;
            this.numTwo.TextChanged += new System.EventHandler(this.numTwo_TextChanged);
            // 
            // labelOne
            // 
            this.labelOne.AutoSize = true;
            this.labelOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labelOne.Location = new System.Drawing.Point(39, 70);
            this.labelOne.Name = "labelOne";
            this.labelOne.Size = new System.Drawing.Size(152, 31);
            this.labelOne.TabIndex = 7;
            this.labelOne.Text = "Số thứ nhất";
            // 
            // lableTwo
            // 
            this.lableTwo.AutoSize = true;
            this.lableTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lableTwo.Location = new System.Drawing.Point(39, 132);
            this.lableTwo.Name = "lableTwo";
            this.lableTwo.Size = new System.Drawing.Size(135, 31);
            this.lableTwo.TabIndex = 8;
            this.lableTwo.Text = "Số thứ hai";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 360);
            this.Controls.Add(this.lableTwo);
            this.Controls.Add(this.labelOne);
            this.Controls.Add(this.numTwo);
            this.Controls.Add(this.numOne);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pastCal);
            this.Name = "Form";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pastCal;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.TextBox numOne;
        private System.Windows.Forms.TextBox numTwo;
        private System.Windows.Forms.Label labelOne;
        private System.Windows.Forms.Label lableTwo;
    }
}

