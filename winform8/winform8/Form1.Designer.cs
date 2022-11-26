
namespace winform8
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.D_score = new System.Windows.Forms.Label();
            this.Mole = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tim = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Mole)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "alive.png");
            this.imageList1.Images.SetKeyName(1, "dead.png");
            this.imageList1.Images.SetKeyName(2, "ground.png");
            // 
            // D_score
            // 
            this.D_score.AutoSize = true;
            this.D_score.BackColor = System.Drawing.Color.Transparent;
            this.D_score.Font = new System.Drawing.Font("휴먼엑스포", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.D_score.ForeColor = System.Drawing.Color.Snow;
            this.D_score.Location = new System.Drawing.Point(492, 9);
            this.D_score.Name = "D_score";
            this.D_score.Size = new System.Drawing.Size(85, 27);
            this.D_score.TabIndex = 0;
            this.D_score.Text = "점수 : ";
            // 
            // Mole
            // 
            this.Mole.BackColor = System.Drawing.Color.Transparent;
            this.Mole.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Mole.BackgroundImage")));
            this.Mole.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Mole.Location = new System.Drawing.Point(435, 330);
            this.Mole.Name = "Mole";
            this.Mole.Size = new System.Drawing.Size(120, 115);
            this.Mole.TabIndex = 1;
            this.Mole.TabStop = false;
            this.Mole.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tim
            // 
            this.tim.AutoSize = true;
            this.tim.BackColor = System.Drawing.Color.Transparent;
            this.tim.Font = new System.Drawing.Font("휴먼엑스포", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tim.ForeColor = System.Drawing.Color.Snow;
            this.tim.Location = new System.Drawing.Point(196, 9);
            this.tim.Name = "tim";
            this.tim.Size = new System.Drawing.Size(77, 27);
            this.tim.TabIndex = 2;
            this.tim.Text = ".............";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::winform8.Properties.Resources.unknown;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(602, 545);
            this.Controls.Add(this.tim);
            this.Controls.Add(this.Mole);
            this.Controls.Add(this.D_score);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Mole)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label D_score;
        private System.Windows.Forms.PictureBox Mole;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label tim;
        private System.Windows.Forms.Timer timer2;
    }
}

