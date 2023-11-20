using System.Windows.Forms;

namespace SeaBattleGraph_for_laptop
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        

        #endregion

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PictureYourField = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PictureEnemyField = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureYourField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureEnemyField)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureYourField
            // 
            this.PictureYourField.BackColor = System.Drawing.Color.Yellow;
            this.PictureYourField.BackgroundImage = global::SeaBattleGraph_for_laptop.Properties.Resources.Fields2;
            this.PictureYourField.Location = new System.Drawing.Point(59, 67);
            this.PictureYourField.Name = "PictureYourField";
            this.PictureYourField.Size = new System.Drawing.Size(501, 501);
            this.PictureYourField.TabIndex = 0;
            this.PictureYourField.TabStop = false;
            this.PictureYourField.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureYourField_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 615);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // PictureEnemyField
            // 
            this.PictureEnemyField.BackColor = System.Drawing.Color.Yellow;
            this.PictureEnemyField.BackgroundImage = global::SeaBattleGraph_for_laptop.Properties.Resources.Fields2;
            this.PictureEnemyField.Location = new System.Drawing.Point(637, 67);
            this.PictureEnemyField.Name = "PictureEnemyField";
            this.PictureEnemyField.Size = new System.Drawing.Size(501, 501);
            this.PictureEnemyField.TabIndex = 2;
            this.PictureEnemyField.TabStop = false;
            this.PictureEnemyField.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureEnemyField_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label2.Location = new System.Drawing.Point(218, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Твои корабли:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label3.Location = new System.Drawing.Point(768, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Корабли противника:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.Location = new System.Drawing.Point(164, 594);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(857, 39);
            this.label4.TabIndex = 5;
            this.label4.Text = "Расставь свои корабли";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 671);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PictureEnemyField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PictureYourField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Морской бой";
            ((System.ComponentModel.ISupportInitialize)(this.PictureYourField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureEnemyField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox PictureYourField;
        private Label label1;
        private PictureBox PictureEnemyField;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}

