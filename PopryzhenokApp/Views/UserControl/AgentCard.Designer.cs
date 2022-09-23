namespace PopryzhenokApp.Model
{
    partial class AgentCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgentCard));
            this.AgentPicBox = new System.Windows.Forms.PictureBox();
            this.TypeTitleLbl = new System.Windows.Forms.Label();
            this.YearSalesLbl = new System.Windows.Forms.Label();
            this.PhoneLbl = new System.Windows.Forms.Label();
            this.PriorityLbl = new System.Windows.Forms.Label();
            this.PriorityValueLbl = new System.Windows.Forms.Label();
            this.DiscountLbl = new System.Windows.Forms.Label();
            this.IdLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AgentPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AgentPicBox
            // 
            this.AgentPicBox.Image = ((System.Drawing.Image)(resources.GetObject("AgentPicBox.Image")));
            this.AgentPicBox.Location = new System.Drawing.Point(20, 16);
            this.AgentPicBox.Name = "AgentPicBox";
            this.AgentPicBox.Size = new System.Drawing.Size(183, 153);
            this.AgentPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AgentPicBox.TabIndex = 0;
            this.AgentPicBox.TabStop = false;
            // 
            // TypeTitleLbl
            // 
            this.TypeTitleLbl.AutoSize = true;
            this.TypeTitleLbl.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeTitleLbl.Location = new System.Drawing.Point(248, 16);
            this.TypeTitleLbl.Name = "TypeTitleLbl";
            this.TypeTitleLbl.Size = new System.Drawing.Size(95, 27);
            this.TypeTitleLbl.TabIndex = 1;
            this.TypeTitleLbl.Text = "Тип|Имя";
            // 
            // YearSalesLbl
            // 
            this.YearSalesLbl.AutoSize = true;
            this.YearSalesLbl.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YearSalesLbl.Location = new System.Drawing.Point(248, 52);
            this.YearSalesLbl.Name = "YearSalesLbl";
            this.YearSalesLbl.Size = new System.Drawing.Size(167, 26);
            this.YearSalesLbl.TabIndex = 1;
            this.YearSalesLbl.Text = "10 продаж за год";
            // 
            // PhoneLbl
            // 
            this.PhoneLbl.AutoSize = true;
            this.PhoneLbl.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneLbl.Location = new System.Drawing.Point(248, 93);
            this.PhoneLbl.Name = "PhoneLbl";
            this.PhoneLbl.Size = new System.Drawing.Size(147, 26);
            this.PhoneLbl.TabIndex = 1;
            this.PhoneLbl.Text = "+7 111 111 11 11";
            // 
            // PriorityLbl
            // 
            this.PriorityLbl.AutoSize = true;
            this.PriorityLbl.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriorityLbl.Location = new System.Drawing.Point(248, 143);
            this.PriorityLbl.Name = "PriorityLbl";
            this.PriorityLbl.Size = new System.Drawing.Size(168, 26);
            this.PriorityLbl.TabIndex = 1;
            this.PriorityLbl.Text = "Приоритетность:";
            // 
            // PriorityValueLbl
            // 
            this.PriorityValueLbl.AutoSize = true;
            this.PriorityValueLbl.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriorityValueLbl.Location = new System.Drawing.Point(422, 143);
            this.PriorityValueLbl.Name = "PriorityValueLbl";
            this.PriorityValueLbl.Size = new System.Drawing.Size(33, 26);
            this.PriorityValueLbl.TabIndex = 1;
            this.PriorityValueLbl.Text = "10";
            // 
            // DiscountLbl
            // 
            this.DiscountLbl.AutoSize = true;
            this.DiscountLbl.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiscountLbl.Location = new System.Drawing.Point(775, 16);
            this.DiscountLbl.Name = "DiscountLbl";
            this.DiscountLbl.Size = new System.Drawing.Size(49, 26);
            this.DiscountLbl.TabIndex = 1;
            this.DiscountLbl.Text = "10%";
            // 
            // IdLbl
            // 
            this.IdLbl.AutoSize = true;
            this.IdLbl.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IdLbl.Location = new System.Drawing.Point(775, 143);
            this.IdLbl.Name = "IdLbl";
            this.IdLbl.Size = new System.Drawing.Size(27, 26);
            this.IdLbl.TabIndex = 1;
            this.IdLbl.Text = "id";
            this.IdLbl.Visible = false;
            // 
            // AgentCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.PhoneLbl);
            this.Controls.Add(this.IdLbl);
            this.Controls.Add(this.DiscountLbl);
            this.Controls.Add(this.PriorityValueLbl);
            this.Controls.Add(this.PriorityLbl);
            this.Controls.Add(this.YearSalesLbl);
            this.Controls.Add(this.TypeTitleLbl);
            this.Controls.Add(this.AgentPicBox);
            this.Name = "AgentCard";
            this.Size = new System.Drawing.Size(871, 201);
            ((System.ComponentModel.ISupportInitialize)(this.AgentPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox AgentPicBox;
        private System.Windows.Forms.Label TypeTitleLbl;
        private System.Windows.Forms.Label YearSalesLbl;
        private System.Windows.Forms.Label PhoneLbl;
        private System.Windows.Forms.Label PriorityLbl;
        private System.Windows.Forms.Label PriorityValueLbl;
        private System.Windows.Forms.Label DiscountLbl;
        private System.Windows.Forms.Label IdLbl;
    }
}
