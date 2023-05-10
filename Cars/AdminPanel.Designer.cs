﻿namespace Cars
{
    partial class AdminPanel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            this.logo = new System.Windows.Forms.PictureBox();
            this.cars_label = new System.Windows.Forms.Label();
            this._cars_comDataSet = new Cars._cars_comDataSet();
            this.carscomDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._cars_comDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carscomDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(13, 13);
            this.logo.Margin = new System.Windows.Forms.Padding(4);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(114, 62);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 7;
            this.logo.TabStop = false;
            // 
            // cars_label
            // 
            this.cars_label.AutoSize = true;
            this.cars_label.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cars_label.Location = new System.Drawing.Point(135, 13);
            this.cars_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cars_label.Name = "cars_label";
            this.cars_label.Size = new System.Drawing.Size(113, 25);
            this.cars_label.TabIndex = 6;
            this.cars_label.Text = "car$.com";
            // 
            // _cars_comDataSet
            // 
            this._cars_comDataSet.DataSetName = "_cars_comDataSet";
            this._cars_comDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carscomDataSetBindingSource
            // 
            this.carscomDataSetBindingSource.DataSource = this._cars_comDataSet;
            this.carscomDataSetBindingSource.Position = 0;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1130, 602);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.cars_label);
            this.MaximizeBox = false;
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPanel";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._cars_comDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carscomDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label cars_label;
        private _cars_comDataSet _cars_comDataSet;
        private System.Windows.Forms.BindingSource carscomDataSetBindingSource;
    }
}