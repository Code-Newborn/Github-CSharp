
namespace VS2019_焦点控件变色
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tbox_num = new System.Windows.Forms.TextBox();
            this.tbox_name = new System.Windows.Forms.TextBox();
            this.tbox_gender = new System.Windows.Forms.TextBox();
            this.tbox_age = new System.Windows.Forms.TextBox();
            this.tbox_birth = new System.Windows.Forms.TextBox();
            this.tbox_position = new System.Windows.Forms.TextBox();
            this.lbl_num = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbox_num
            // 
            this.tbox_num.Location = new System.Drawing.Point(66, 22);
            this.tbox_num.Name = "tbox_num";
            this.tbox_num.Size = new System.Drawing.Size(67, 21);
            this.tbox_num.TabIndex = 0;
            this.tbox_num.Tag = "1";
            this.tbox_num.Enter += new System.EventHandler(this.tbox_num_Enter);
            this.tbox_num.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbox_num_KeyDown);
            this.tbox_num.Leave += new System.EventHandler(this.tbox_num_Leave);
            // 
            // tbox_name
            // 
            this.tbox_name.Location = new System.Drawing.Point(229, 22);
            this.tbox_name.Name = "tbox_name";
            this.tbox_name.Size = new System.Drawing.Size(67, 21);
            this.tbox_name.TabIndex = 1;
            this.tbox_name.Tag = "2";
            this.tbox_name.Enter += new System.EventHandler(this.tbox_num_Enter);
            this.tbox_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbox_num_KeyDown);
            this.tbox_name.Leave += new System.EventHandler(this.tbox_num_Leave);
            // 
            // tbox_gender
            // 
            this.tbox_gender.Location = new System.Drawing.Point(66, 71);
            this.tbox_gender.Name = "tbox_gender";
            this.tbox_gender.Size = new System.Drawing.Size(67, 21);
            this.tbox_gender.TabIndex = 2;
            this.tbox_gender.Tag = "3";
            this.tbox_gender.Enter += new System.EventHandler(this.tbox_num_Enter);
            this.tbox_gender.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbox_num_KeyDown);
            this.tbox_gender.Leave += new System.EventHandler(this.tbox_num_Leave);
            // 
            // tbox_age
            // 
            this.tbox_age.Location = new System.Drawing.Point(229, 71);
            this.tbox_age.Name = "tbox_age";
            this.tbox_age.Size = new System.Drawing.Size(67, 21);
            this.tbox_age.TabIndex = 3;
            this.tbox_age.Tag = "4";
            this.tbox_age.Enter += new System.EventHandler(this.tbox_num_Enter);
            this.tbox_age.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbox_num_KeyDown);
            this.tbox_age.Leave += new System.EventHandler(this.tbox_num_Leave);
            // 
            // tbox_birth
            // 
            this.tbox_birth.Location = new System.Drawing.Point(66, 120);
            this.tbox_birth.Name = "tbox_birth";
            this.tbox_birth.Size = new System.Drawing.Size(67, 21);
            this.tbox_birth.TabIndex = 4;
            this.tbox_birth.Tag = "5";
            this.tbox_birth.Enter += new System.EventHandler(this.tbox_num_Enter);
            this.tbox_birth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbox_num_KeyDown);
            this.tbox_birth.Leave += new System.EventHandler(this.tbox_num_Leave);
            // 
            // tbox_position
            // 
            this.tbox_position.Location = new System.Drawing.Point(229, 120);
            this.tbox_position.Name = "tbox_position";
            this.tbox_position.Size = new System.Drawing.Size(67, 21);
            this.tbox_position.TabIndex = 5;
            this.tbox_position.Tag = "6";
            this.tbox_position.Enter += new System.EventHandler(this.tbox_num_Enter);
            this.tbox_position.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbox_num_KeyDown);
            this.tbox_position.Leave += new System.EventHandler(this.tbox_num_Leave);
            // 
            // lbl_num
            // 
            this.lbl_num.AutoSize = true;
            this.lbl_num.Location = new System.Drawing.Point(17, 26);
            this.lbl_num.Name = "lbl_num";
            this.lbl_num.Size = new System.Drawing.Size(35, 12);
            this.lbl_num.TabIndex = 6;
            this.lbl_num.Text = "编号:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "姓名:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "性别:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "年龄:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "生日:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "职务:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 161);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_num);
            this.Controls.Add(this.tbox_position);
            this.Controls.Add(this.tbox_birth);
            this.Controls.Add(this.tbox_age);
            this.Controls.Add(this.tbox_gender);
            this.Controls.Add(this.tbox_name);
            this.Controls.Add(this.tbox_num);
            this.Name = "Form1";
            this.Text = "焦点控件变色";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbox_num;
        private System.Windows.Forms.TextBox tbox_name;
        private System.Windows.Forms.TextBox tbox_gender;
        private System.Windows.Forms.TextBox tbox_age;
        private System.Windows.Forms.TextBox tbox_birth;
        private System.Windows.Forms.TextBox tbox_position;
        private System.Windows.Forms.Label lbl_num;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

