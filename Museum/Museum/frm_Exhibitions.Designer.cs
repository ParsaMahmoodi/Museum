namespace Museum
{
    partial class frm_Exhibitions
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
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Start_Date = new System.Windows.Forms.Label();
            this.lbl_End_Date = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Start_Date = new System.Windows.Forms.TextBox();
            this.txt_End_Date = new System.Windows.Forms.TextBox();
            this.dgv_Exhibition = new System.Windows.Forms.DataGridView();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Exhibition)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(31, 74);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(68, 25);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_Start_Date
            // 
            this.lbl_Start_Date.AutoSize = true;
            this.lbl_Start_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Start_Date.Location = new System.Drawing.Point(31, 136);
            this.lbl_Start_Date.Name = "lbl_Start_Date";
            this.lbl_Start_Date.Size = new System.Drawing.Size(108, 25);
            this.lbl_Start_Date.TabIndex = 1;
            this.lbl_Start_Date.Text = "Start Date";
            // 
            // lbl_End_Date
            // 
            this.lbl_End_Date.AutoSize = true;
            this.lbl_End_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_End_Date.Location = new System.Drawing.Point(31, 205);
            this.lbl_End_Date.Name = "lbl_End_Date";
            this.lbl_End_Date.Size = new System.Drawing.Size(101, 25);
            this.lbl_End_Date.TabIndex = 2;
            this.lbl_End_Date.Text = "End Date";
            this.lbl_End_Date.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(168, 68);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(260, 31);
            this.txt_Name.TabIndex = 3;
            // 
            // txt_Start_Date
            // 
            this.txt_Start_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Start_Date.Location = new System.Drawing.Point(168, 130);
            this.txt_Start_Date.Name = "txt_Start_Date";
            this.txt_Start_Date.Size = new System.Drawing.Size(260, 31);
            this.txt_Start_Date.TabIndex = 4;
            // 
            // txt_End_Date
            // 
            this.txt_End_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_End_Date.Location = new System.Drawing.Point(168, 199);
            this.txt_End_Date.Name = "txt_End_Date";
            this.txt_End_Date.Size = new System.Drawing.Size(260, 31);
            this.txt_End_Date.TabIndex = 5;
            // 
            // dgv_Exhibition
            // 
            this.dgv_Exhibition.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Exhibition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Exhibition.Location = new System.Drawing.Point(434, 12);
            this.dgv_Exhibition.Name = "dgv_Exhibition";
            this.dgv_Exhibition.Size = new System.Drawing.Size(354, 426);
            this.dgv_Exhibition.TabIndex = 6;
            this.dgv_Exhibition.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Exhibition_CellClick);
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(12, 394);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(89, 44);
            this.btn_Add.TabIndex = 7;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.Location = new System.Drawing.Point(118, 394);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(89, 44);
            this.btn_Edit.TabIndex = 8;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(231, 394);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(89, 44);
            this.btn_Search.TabIndex = 9;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(339, 394);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(89, 44);
            this.btn_Delete.TabIndex = 10;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // frm_Exhibitions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dgv_Exhibition);
            this.Controls.Add(this.txt_End_Date);
            this.Controls.Add(this.txt_Start_Date);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.lbl_End_Date);
            this.Controls.Add(this.lbl_Start_Date);
            this.Controls.Add(this.lbl_Name);
            this.Name = "frm_Exhibitions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exhibitions";
            this.Load += new System.EventHandler(this.frm_Exhibitions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Exhibition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Start_Date;
        private System.Windows.Forms.Label lbl_End_Date;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Start_Date;
        private System.Windows.Forms.TextBox txt_End_Date;
        private System.Windows.Forms.DataGridView dgv_Exhibition;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Delete;
    }
}