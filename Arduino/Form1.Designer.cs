namespace Arduino
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.app_name = new System.Windows.Forms.TextBox();
            this.transition_property = new System.Windows.Forms.Button();
            this.transition_themometer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // app_name
            // 
            this.app_name.BackColor = System.Drawing.SystemColors.Control;
            this.app_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.app_name.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.app_name.Location = new System.Drawing.Point(150, 63);
            this.app_name.Name = "app_name";
            this.app_name.Size = new System.Drawing.Size(187, 48);
            this.app_name.TabIndex = 1;
            this.app_name.Text = "THRMOMETER";
            // 
            // transition_property
            // 
            this.transition_property.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.transition_property.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.transition_property.Location = new System.Drawing.Point(256, 165);
            this.transition_property.Name = "transition_property";
            this.transition_property.Size = new System.Drawing.Size(164, 141);
            this.transition_property.TabIndex = 2;
            this.transition_property.Text = "設定";
            this.transition_property.UseVisualStyleBackColor = false;
            this.transition_property.Click += new System.EventHandler(this.transition_property_Click);
            // 
            // transition_themometer
            // 
            this.transition_themometer.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.transition_themometer.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.transition_themometer.ForeColor = System.Drawing.Color.Red;
            this.transition_themometer.Location = new System.Drawing.Point(64, 165);
            this.transition_themometer.Name = "transition_themometer";
            this.transition_themometer.Size = new System.Drawing.Size(164, 141);
            this.transition_themometer.TabIndex = 3;
            this.transition_themometer.Text = "温度計";
            this.transition_themometer.UseVisualStyleBackColor = false;
            this.transition_themometer.Click += new System.EventHandler(this.transition_themometer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 353);
            this.Controls.Add(this.transition_themometer);
            this.Controls.Add(this.transition_property);
            this.Controls.Add(this.app_name);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox app_name;
        private System.Windows.Forms.Button transition_property;
        private System.Windows.Forms.Button transition_themometer;
    }
}

