namespace Ch11
{
    partial class Form2
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
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.btnPoision = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbHobby = new System.Windows.Forms.ComboBox();
            this.btnHobby = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbResultPositon = new System.Windows.Forms.Label();
            this.lbResultHobby = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lstCountry = new System.Windows.Forms.ListBox();
            this.lbResultCountry = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "데이터를 공급해주는 컨트롤";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "ComboBox 연습";
            // 
            // cbPosition
            // 
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Location = new System.Drawing.Point(62, 91);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(106, 23);
            this.cbPosition.TabIndex = 2;
            // 
            // btnPoision
            // 
            this.btnPoision.Location = new System.Drawing.Point(174, 90);
            this.btnPoision.Name = "btnPoision";
            this.btnPoision.Size = new System.Drawing.Size(75, 23);
            this.btnPoision.TabIndex = 3;
            this.btnPoision.Text = "확인";
            this.btnPoision.UseVisualStyleBackColor = true;
            this.btnPoision.Click += new System.EventHandler(this.btnPoision_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "직급";
            // 
            // cbHobby
            // 
            this.cbHobby.FormattingEnabled = true;
            this.cbHobby.Location = new System.Drawing.Point(62, 120);
            this.cbHobby.Name = "cbHobby";
            this.cbHobby.Size = new System.Drawing.Size(106, 23);
            this.cbHobby.TabIndex = 5;
            // 
            // btnHobby
            // 
            this.btnHobby.Location = new System.Drawing.Point(174, 120);
            this.btnHobby.Name = "btnHobby";
            this.btnHobby.Size = new System.Drawing.Size(75, 23);
            this.btnHobby.TabIndex = 6;
            this.btnHobby.Text = "확인";
            this.btnHobby.UseVisualStyleBackColor = true;
            this.btnHobby.Click += new System.EventHandler(this.btnHobby_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "취미";
            // 
            // lbResultPositon
            // 
            this.lbResultPositon.AutoSize = true;
            this.lbResultPositon.Location = new System.Drawing.Point(255, 94);
            this.lbResultPositon.Name = "lbResultPositon";
            this.lbResultPositon.Size = new System.Drawing.Size(38, 15);
            this.lbResultPositon.TabIndex = 8;
            this.lbResultPositon.Text = "결과 :";
            // 
            // lbResultHobby
            // 
            this.lbResultHobby.AutoSize = true;
            this.lbResultHobby.Location = new System.Drawing.Point(255, 124);
            this.lbResultHobby.Name = "lbResultHobby";
            this.lbResultHobby.Size = new System.Drawing.Size(38, 15);
            this.lbResultHobby.TabIndex = 9;
            this.lbResultHobby.Text = "결과 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "ListBox 연습";
            // 
            // lstCountry
            // 
            this.lstCountry.FormattingEnabled = true;
            this.lstCountry.ItemHeight = 15;
            this.lstCountry.Location = new System.Drawing.Point(25, 198);
            this.lstCountry.Name = "lstCountry";
            this.lstCountry.Size = new System.Drawing.Size(143, 124);
            this.lstCountry.TabIndex = 11;
            this.lstCountry.SelectedIndexChanged += new System.EventHandler(this.lstCountry_SelectedIndexChanged);
            // 
            // lbResultCountry
            // 
            this.lbResultCountry.AutoSize = true;
            this.lbResultCountry.Location = new System.Drawing.Point(174, 307);
            this.lbResultCountry.Name = "lbResultCountry";
            this.lbResultCountry.Size = new System.Drawing.Size(38, 15);
            this.lbResultCountry.TabIndex = 12;
            this.lbResultCountry.Text = "결과 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "ListBox 연습";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 380);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(432, 158);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 680);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbResultCountry);
            this.Controls.Add(this.lstCountry);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbResultHobby);
            this.Controls.Add(this.lbResultPositon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnHobby);
            this.Controls.Add(this.cbHobby);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPoision);
            this.Controls.Add(this.cbPosition);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cbPosition;
        private Button btnPoision;
        private Label label3;
        private ComboBox cbHobby;
        private Button btnHobby;
        private Label label4;
        private Label lbResultPositon;
        private Label lbResultHobby;
        private Label label5;
        private ListBox lstCountry;
        private Label lbResultCountry;
        private Label label6;
        private DataGridView dataGridView1;
    }
}