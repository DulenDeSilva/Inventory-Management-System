namespace IMS
{
    partial class view_items
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
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.dgv_items = new System.Windows.Forms.DataGridView();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_items)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(222)))), ((int)(((byte)(233)))));
            this.txt_search.Location = new System.Drawing.Point(218, 129);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(246, 22);
            this.txt_search.TabIndex = 0;
            // 
            // btn_search
            // 
            this.btn_search.BackgroundImage = global::IMS.Properties.Resources.search;
            this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_search.Location = new System.Drawing.Point(483, 119);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(105, 42);
            this.btn_search.TabIndex = 1;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // dgv_items
            // 
            this.dgv_items.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(143)))), ((int)(((byte)(169)))));
            this.dgv_items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_items.Location = new System.Drawing.Point(48, 179);
            this.dgv_items.Name = "dgv_items";
            this.dgv_items.RowHeadersWidth = 51;
            this.dgv_items.RowTemplate.Height = 24;
            this.dgv_items.Size = new System.Drawing.Size(707, 165);
            this.dgv_items.TabIndex = 2;
            this.dgv_items.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_items_CellContentClick_1);
            // 
            // btn_update
            // 
            this.btn_update.BackgroundImage = global::IMS.Properties.Resources.btn_update;
            this.btn_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_update.Location = new System.Drawing.Point(218, 369);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(142, 53);
            this.btn_update.TabIndex = 3;
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackgroundImage = global::IMS.Properties.Resources.btn_back;
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_back.Location = new System.Drawing.Point(690, 3);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(78, 71);
            this.btn_back.TabIndex = 4;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackgroundImage = global::IMS.Properties.Resources.btn_delete;
            this.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_delete.Location = new System.Drawing.Point(446, 369);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(142, 53);
            this.btn_delete.TabIndex = 5;
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // view_items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IMS.Properties.Resources.view_items2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.dgv_items);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.DoubleBuffered = true;
            this.Name = "view_items";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "view_items";
            this.Load += new System.EventHandler(this.view_items_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_items)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridView dgv_items;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_delete;
    }
}