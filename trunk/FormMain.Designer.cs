using System.Windows.Forms;

namespace MceRemoteMapper
{
    partial class FormMain
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
            this.dataGridViewMappings = new System.Windows.Forms.DataGridView();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonApply = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMappings)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMappings
            // 
            this.dataGridViewMappings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMappings.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewMappings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewMappings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMappings.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewMappings.Name = "dataGridViewMappings";
            this.dataGridViewMappings.RowHeadersVisible = false;
            this.dataGridViewMappings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMappings.ShowCellErrors = false;
            this.dataGridViewMappings.ShowCellToolTips = false;
            this.dataGridViewMappings.ShowEditingIcon = false;
            this.dataGridViewMappings.ShowRowErrors = false;
            this.dataGridViewMappings.Size = new System.Drawing.Size(570, 375);
            this.dataGridViewMappings.TabIndex = 0;
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.Location = new System.Drawing.Point(507, 393);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "&Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExitClick);
            // 
            // buttonApply
            // 
            this.buttonApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonApply.Location = new System.Drawing.Point(426, 393);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 23);
            this.buttonApply.TabIndex = 1;
            this.buttonApply.Text = "&Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.ButtonApplyClick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 428);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.dataGridViewMappings);
            this.Name = "FormMain";
            this.Text = "MCE Remote Key Mapper";
            this.Load += new System.EventHandler(this.FormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMappings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMappings;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonApply;
    }
}

