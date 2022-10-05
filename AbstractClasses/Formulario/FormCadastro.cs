using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AbstractClasses.Classes;

namespace AbstractClasses.Formulario
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }


        private void IncludeTeacher(object sender, EventArgs e)
        {
            Teacher t = new Teacher();
            t.Name = nameInput.Text;
            t.Address = addresInput.Text;
            t.CPF = cpfInput.Text;
            t.Graduation = graduationInput.Text;
            t.Category = categoryInput.Text;

            statusLbl.Text = t.Include();
        }

        private void IncludeStudent(object s, EventArgs e)
        {
            Student s = new Student();
            s.Name = nameInput.Text;
            s.Address = addresInput.Text;
            s.CPF = cpfInput.Text;
            s.Curso = courseInput.Text;
            s.Turma = teamInput.Text;

            statusLbl.Text = s.Include();
        }

        private void ExcludeStudent(object sender, EventArgs e)
        {

        }
    }
}
