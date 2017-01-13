namespace TuningDroidControls
{
    partial class StartPage
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.transparentLabel2 = new TuningDroidControls.TransparentLabel();
            this.transparentLabel1 = new TuningDroidControls.TransparentLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(316, 189);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(176, 49);
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "Begin";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // transparentLabel2
            // 
            this.transparentLabel2.ExtLocation = new System.Drawing.Point(0, 0);
            this.transparentLabel2.Font = new System.Drawing.Font("Segoe UI Light", 30F);
            this.transparentLabel2.Location = new System.Drawing.Point(257, 374);
            this.transparentLabel2.Name = "transparentLabel2";
            this.transparentLabel2.Size = new System.Drawing.Size(301, 44);
            this.transparentLabel2.SizeInPoints = 30F;
            this.transparentLabel2.TabIndex = 4;
            // 
            // transparentLabel1
            // 
            this.transparentLabel1.ExtLocation = new System.Drawing.Point(0, 0);
            this.transparentLabel1.Font = new System.Drawing.Font("Segoe UI Light", 30F);
            this.transparentLabel1.Location = new System.Drawing.Point(246, 93);
            this.transparentLabel1.Name = "transparentLabel1";
            this.transparentLabel1.Size = new System.Drawing.Size(301, 90);
            this.transparentLabel1.SizeInPoints = 30F;
            this.transparentLabel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TuningDroidControls.Properties.Resources.Minimal_gray_to_white_gradient_1920x1200;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 418);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.transparentLabel2);
            this.Controls.Add(this.transparentLabel1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "StartPage";
            this.Size = new System.Drawing.Size(800, 418);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private TransparentLabel transparentLabel1;
        private TransparentLabel transparentLabel2;
    }
}
