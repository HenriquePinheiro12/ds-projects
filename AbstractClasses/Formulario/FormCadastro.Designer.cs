namespace AbstractClasses.Formulario
{
    partial class FormCadastro
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.excludeStudentBtn = new System.Windows.Forms.Button();
            this.includeStudentBtn = new System.Windows.Forms.Button();
            this.teamInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.courseInput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addresInput = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cpfInput = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.excludeTeacherBtn = new System.Windows.Forms.Button();
            this.inlcudeTeacherBtn = new System.Windows.Forms.Button();
            this.categoryInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.graduationInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.adressInputT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nameInputT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cpfInputT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusLbl = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(30, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(737, 285);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.excludeStudentBtn);
            this.tabPage1.Controls.Add(this.includeStudentBtn);
            this.tabPage1.Controls.Add(this.teamInput);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.courseInput);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.addresInput);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.nameInput);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.cpfInput);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(729, 259);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Alunos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // excludeStudentBtn
            // 
            this.excludeStudentBtn.Location = new System.Drawing.Point(166, 226);
            this.excludeStudentBtn.Name = "excludeStudentBtn";
            this.excludeStudentBtn.Size = new System.Drawing.Size(75, 23);
            this.excludeStudentBtn.TabIndex = 23;
            this.excludeStudentBtn.Text = "Excluir";
            this.excludeStudentBtn.UseVisualStyleBackColor = true;
            this.excludeStudentBtn.Click += new System.EventHandler(this.ExcludeStudent);
            // 
            // includeStudentBtn
            // 
            this.includeStudentBtn.Location = new System.Drawing.Point(69, 226);
            this.includeStudentBtn.Name = "includeStudentBtn";
            this.includeStudentBtn.Size = new System.Drawing.Size(75, 23);
            this.includeStudentBtn.TabIndex = 22;
            this.includeStudentBtn.Text = "Incluir";
            this.includeStudentBtn.UseVisualStyleBackColor = true;
            this.includeStudentBtn.Click += new System.EventHandler(this.IncludeTeacher);
            // 
            // teamInput
            // 
            this.teamInput.Location = new System.Drawing.Point(69, 179);
            this.teamInput.Name = "teamInput";
            this.teamInput.Size = new System.Drawing.Size(182, 20);
            this.teamInput.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Turma";
            // 
            // courseInput
            // 
            this.courseInput.Location = new System.Drawing.Point(69, 138);
            this.courseInput.Name = "courseInput";
            this.courseInput.Size = new System.Drawing.Size(182, 20);
            this.courseInput.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Curso";
            // 
            // addresInput
            // 
            this.addresInput.Location = new System.Drawing.Point(69, 100);
            this.addresInput.Name = "addresInput";
            this.addresInput.Size = new System.Drawing.Size(182, 20);
            this.addresInput.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "End.";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(69, 64);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(182, 20);
            this.nameInput.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Nome";
            // 
            // cpfInput
            // 
            this.cpfInput.Location = new System.Drawing.Point(69, 25);
            this.cpfInput.Name = "cpfInput";
            this.cpfInput.Size = new System.Drawing.Size(182, 20);
            this.cpfInput.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "CPF";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.excludeTeacherBtn);
            this.tabPage2.Controls.Add(this.inlcudeTeacherBtn);
            this.tabPage2.Controls.Add(this.categoryInput);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.graduationInput);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.adressInputT);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.nameInputT);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.cpfInputT);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(729, 259);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Professores";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // excludeTeacherBtn
            // 
            this.excludeTeacherBtn.Location = new System.Drawing.Point(152, 221);
            this.excludeTeacherBtn.Name = "excludeTeacherBtn";
            this.excludeTeacherBtn.Size = new System.Drawing.Size(75, 23);
            this.excludeTeacherBtn.TabIndex = 11;
            this.excludeTeacherBtn.Text = "Excluir";
            this.excludeTeacherBtn.UseVisualStyleBackColor = true;
            // 
            // inlcudeTeacherBtn
            // 
            this.inlcudeTeacherBtn.Location = new System.Drawing.Point(55, 221);
            this.inlcudeTeacherBtn.Name = "inlcudeTeacherBtn";
            this.inlcudeTeacherBtn.Size = new System.Drawing.Size(75, 23);
            this.inlcudeTeacherBtn.TabIndex = 10;
            this.inlcudeTeacherBtn.Text = "Incluir";
            this.inlcudeTeacherBtn.UseVisualStyleBackColor = true;
            this.inlcudeTeacherBtn.Click += new System.EventHandler(this.IncludeTeacher);
            // 
            // categoryInput
            // 
            this.categoryInput.Location = new System.Drawing.Point(55, 174);
            this.categoryInput.Name = "categoryInput";
            this.categoryInput.Size = new System.Drawing.Size(182, 20);
            this.categoryInput.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cat.";
            // 
            // graduationInput
            // 
            this.graduationInput.Location = new System.Drawing.Point(55, 133);
            this.graduationInput.Name = "graduationInput";
            this.graduationInput.Size = new System.Drawing.Size(182, 20);
            this.graduationInput.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Lic.";
            // 
            // adressInputT
            // 
            this.adressInputT.Location = new System.Drawing.Point(55, 95);
            this.adressInputT.Name = "adressInputT";
            this.adressInputT.Size = new System.Drawing.Size(182, 20);
            this.adressInputT.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "End.";
            // 
            // nameInputT
            // 
            this.nameInputT.Location = new System.Drawing.Point(55, 59);
            this.nameInputT.Name = "nameInputT";
            this.nameInputT.Size = new System.Drawing.Size(182, 20);
            this.nameInputT.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // cpfInputT
            // 
            this.cpfInputT.Location = new System.Drawing.Point(55, 20);
            this.cpfInputT.Name = "cpfInputT";
            this.cpfInputT.Size = new System.Drawing.Size(182, 20);
            this.cpfInputT.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPF";
            // 
            // statusLbl
            // 
            this.statusLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statusLbl.Location = new System.Drawing.Point(30, 339);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(729, 167);
            this.statusLbl.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 323);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Status";
            // 
            // FormCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 536);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.statusLbl);
            this.Controls.Add(this.tabControl1);
            this.MinimizeBox = false;
            this.Name = "FormCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastros";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox categoryInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox graduationInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox adressInputT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameInputT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cpfInputT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button excludeStudentBtn;
        private System.Windows.Forms.Button includeStudentBtn;
        private System.Windows.Forms.TextBox teamInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox courseInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox addresInput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox cpfInput;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button excludeTeacherBtn;
        private System.Windows.Forms.Button inlcudeTeacherBtn;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.Label label12;
    }
}