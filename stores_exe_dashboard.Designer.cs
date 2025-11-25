namespace IMS
{
    partial class stores_exe_dashboard
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
            this.btn_additem = new System.Windows.Forms.Button();
            this.btn_viewstock = new System.Windows.Forms.Button();
            this.btn_updateprofile = new System.Windows.Forms.Button();
            this.lbl_name = new System.Windows.Forms.Label();
            this.btn_viewrequests = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_additem
            // 
            this.btn_additem.BackColor = System.Drawing.Color.Transparent;
            this.btn_additem.BackgroundImage = global::IMS.Properties.Resources.Screenshot_2025_01_15_023325;
            this.btn_additem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_additem.Location = new System.Drawing.Point(14, 245);
            this.btn_additem.Name = "btn_additem";
            this.btn_additem.Size = new System.Drawing.Size(284, 112);
            this.btn_additem.TabIndex = 0;
            this.btn_additem.UseVisualStyleBackColor = false;
            this.btn_additem.Click += new System.EventHandler(this.btn_additem_Click);
            // 
            // btn_viewstock
            // 
            this.btn_viewstock.BackColor = System.Drawing.Color.Transparent;
            this.btn_viewstock.BackgroundImage = global::IMS.Properties.Resources.Screenshot_2025_01_15_023857;
            this.btn_viewstock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_viewstock.Location = new System.Drawing.Point(327, 245);
            this.btn_viewstock.Name = "btn_viewstock";
            this.btn_viewstock.Size = new System.Drawing.Size(284, 112);
            this.btn_viewstock.TabIndex = 1;
            this.btn_viewstock.UseVisualStyleBackColor = false;
            this.btn_viewstock.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_updateprofile
            // 
            this.btn_updateprofile.BackColor = System.Drawing.Color.Transparent;
            this.btn_updateprofile.BackgroundImage = global::IMS.Properties.Resources.Screenshot_2025_01_15_094110;
            this.btn_updateprofile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_updateprofile.Location = new System.Drawing.Point(810, 2);
            this.btn_updateprofile.Name = "btn_updateprofile";
            this.btn_updateprofile.Size = new System.Drawing.Size(97, 79);
            this.btn_updateprofile.TabIndex = 3;
            this.btn_updateprofile.UseVisualStyleBackColor = false;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(222)))), ((int)(((byte)(233)))));
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_name.Location = new System.Drawing.Point(125, 165);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(0, 22);
            this.lbl_name.TabIndex = 5;
            // 
            // btn_viewrequests
            // 
            this.btn_viewrequests.BackColor = System.Drawing.Color.Transparent;
            this.btn_viewrequests.BackgroundImage = global::IMS.Properties.Resources.Screenshot_2025_01_15_032650;
            this.btn_viewrequests.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_viewrequests.Location = new System.Drawing.Point(641, 241);
            this.btn_viewrequests.Name = "btn_viewrequests";
            this.btn_viewrequests.Size = new System.Drawing.Size(291, 116);
            this.btn_viewrequests.TabIndex = 2;
            this.btn_viewrequests.UseVisualStyleBackColor = false;
            this.btn_viewrequests.Click += new System.EventHandler(this.btn_viewrequests_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.Transparent;
            this.btn_logout.BackgroundImage = global::IMS.Properties.Resources.Screenshot_2025_01_15_094136;
            this.btn_logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_logout.Location = new System.Drawing.Point(810, 78);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(97, 79);
            this.btn_logout.TabIndex = 7;
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // stores_exe_dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IMS.Properties.Resources.stores_exe_dash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(938, 489);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.btn_updateprofile);
            this.Controls.Add(this.btn_viewrequests);
            this.Controls.Add(this.btn_viewstock);
            this.Controls.Add(this.btn_additem);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "stores_exe_dashboard";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_additem;
        private System.Windows.Forms.Button btn_viewstock;
        private System.Windows.Forms.Button btn_updateprofile;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Button btn_viewrequests;
        private System.Windows.Forms.Button btn_logout;
    }
}