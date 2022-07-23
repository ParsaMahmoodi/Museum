namespace Museum
{
    partial class frm_Artists
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_Artists = new System.Windows.Forms.DataGridView();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Date_Born = new System.Windows.Forms.Label();
            this.lbl_Date_Died = new System.Windows.Forms.Label();
            this.lbl_Country = new System.Windows.Forms.Label();
            this.lbl_Epoch = new System.Windows.Forms.Label();
            this.lbl_Main_Style = new System.Windows.Forms.Label();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Date_Born = new System.Windows.Forms.TextBox();
            this.txt_Date_Died = new System.Windows.Forms.TextBox();
            this.txt_Country = new System.Windows.Forms.TextBox();
            this.txt_Epoch = new System.Windows.Forms.TextBox();
            this.txt_Main_Style = new System.Windows.Forms.TextBox();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Artists)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Artists
            // 
            this.dgv_Artists.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Artists.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Artists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Artists.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Artists.Location = new System.Drawing.Point(431, 12);
            this.dgv_Artists.Name = "dgv_Artists";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Artists.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Artists.Size = new System.Drawing.Size(634, 426);
            this.dgv_Artists.TabIndex = 0;
            this.dgv_Artists.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Artists_CellClick);
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(12, 18);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(68, 25);
            this.lbl_Name.TabIndex = 1;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_Date_Born
            // 
            this.lbl_Date_Born.AutoSize = true;
            this.lbl_Date_Born.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date_Born.Location = new System.Drawing.Point(12, 66);
            this.lbl_Date_Born.Name = "lbl_Date_Born";
            this.lbl_Date_Born.Size = new System.Drawing.Size(108, 25);
            this.lbl_Date_Born.TabIndex = 2;
            this.lbl_Date_Born.Text = "Date Born";
            // 
            // lbl_Date_Died
            // 
            this.lbl_Date_Died.AutoSize = true;
            this.lbl_Date_Died.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date_Died.Location = new System.Drawing.Point(12, 114);
            this.lbl_Date_Died.Name = "lbl_Date_Died";
            this.lbl_Date_Died.Size = new System.Drawing.Size(107, 25);
            this.lbl_Date_Died.TabIndex = 3;
            this.lbl_Date_Died.Text = "Date Died";
            // 
            // lbl_Country
            // 
            this.lbl_Country.AutoSize = true;
            this.lbl_Country.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Country.Location = new System.Drawing.Point(12, 162);
            this.lbl_Country.Name = "lbl_Country";
            this.lbl_Country.Size = new System.Drawing.Size(87, 25);
            this.lbl_Country.TabIndex = 4;
            this.lbl_Country.Text = "Country";
            // 
            // lbl_Epoch
            // 
            this.lbl_Epoch.AutoSize = true;
            this.lbl_Epoch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Epoch.Location = new System.Drawing.Point(12, 210);
            this.lbl_Epoch.Name = "lbl_Epoch";
            this.lbl_Epoch.Size = new System.Drawing.Size(73, 25);
            this.lbl_Epoch.TabIndex = 5;
            this.lbl_Epoch.Text = "Epoch";
            // 
            // lbl_Main_Style
            // 
            this.lbl_Main_Style.AutoSize = true;
            this.lbl_Main_Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Main_Style.Location = new System.Drawing.Point(12, 258);
            this.lbl_Main_Style.Name = "lbl_Main_Style";
            this.lbl_Main_Style.Size = new System.Drawing.Size(113, 25);
            this.lbl_Main_Style.TabIndex = 6;
            this.lbl_Main_Style.Text = "Main Style";
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Description.Location = new System.Drawing.Point(12, 306);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(120, 25);
            this.lbl_Description.TabIndex = 7;
            this.lbl_Description.Text = "Description";
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(164, 12);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(261, 31);
            this.txt_Name.TabIndex = 8;
            // 
            // txt_Date_Born
            // 
            this.txt_Date_Born.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Date_Born.Location = new System.Drawing.Point(164, 60);
            this.txt_Date_Born.Name = "txt_Date_Born";
            this.txt_Date_Born.Size = new System.Drawing.Size(261, 31);
            this.txt_Date_Born.TabIndex = 9;
            // 
            // txt_Date_Died
            // 
            this.txt_Date_Died.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Date_Died.Location = new System.Drawing.Point(164, 108);
            this.txt_Date_Died.Name = "txt_Date_Died";
            this.txt_Date_Died.Size = new System.Drawing.Size(261, 31);
            this.txt_Date_Died.TabIndex = 10;
            // 
            // txt_Country
            // 
            this.txt_Country.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Country.Location = new System.Drawing.Point(164, 156);
            this.txt_Country.Name = "txt_Country";
            this.txt_Country.Size = new System.Drawing.Size(261, 31);
            this.txt_Country.TabIndex = 11;
            // 
            // txt_Epoch
            // 
            this.txt_Epoch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Epoch.Location = new System.Drawing.Point(164, 204);
            this.txt_Epoch.Name = "txt_Epoch";
            this.txt_Epoch.Size = new System.Drawing.Size(261, 31);
            this.txt_Epoch.TabIndex = 12;
            // 
            // txt_Main_Style
            // 
            this.txt_Main_Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Main_Style.Location = new System.Drawing.Point(164, 252);
            this.txt_Main_Style.Name = "txt_Main_Style";
            this.txt_Main_Style.Size = new System.Drawing.Size(261, 31);
            this.txt_Main_Style.TabIndex = 13;
            // 
            // txt_Description
            // 
            this.txt_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Description.Location = new System.Drawing.Point(164, 300);
            this.txt_Description.Multiline = true;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(261, 94);
            this.txt_Description.TabIndex = 14;
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(13, 400);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(91, 38);
            this.btn_Add.TabIndex = 15;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.Location = new System.Drawing.Point(120, 400);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(91, 38);
            this.btn_Edit.TabIndex = 16;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(227, 400);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(91, 38);
            this.btn_Search.TabIndex = 17;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(334, 400);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(91, 38);
            this.btn_Delete.TabIndex = 18;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // frm_Artists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 450);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txt_Description);
            this.Controls.Add(this.txt_Main_Style);
            this.Controls.Add(this.txt_Epoch);
            this.Controls.Add(this.txt_Country);
            this.Controls.Add(this.txt_Date_Died);
            this.Controls.Add(this.txt_Date_Born);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.lbl_Description);
            this.Controls.Add(this.lbl_Main_Style);
            this.Controls.Add(this.lbl_Epoch);
            this.Controls.Add(this.lbl_Country);
            this.Controls.Add(this.lbl_Date_Died);
            this.Controls.Add(this.lbl_Date_Born);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.dgv_Artists);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_Artists";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Artists";
            this.Load += new System.EventHandler(this.frm_Artists_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Artists)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Artists;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Date_Born;
        private System.Windows.Forms.Label lbl_Date_Died;
        private System.Windows.Forms.Label lbl_Country;
        private System.Windows.Forms.Label lbl_Epoch;
        private System.Windows.Forms.Label lbl_Main_Style;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Date_Born;
        private System.Windows.Forms.TextBox txt_Date_Died;
        private System.Windows.Forms.TextBox txt_Country;
        private System.Windows.Forms.TextBox txt_Epoch;
        private System.Windows.Forms.TextBox txt_Main_Style;
        private System.Windows.Forms.TextBox txt_Description;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Delete;
    }
}