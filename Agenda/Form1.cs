using Agenda.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var compromisso = new Compromisso();
            compromisso.Id = Guid.NewGuid();
            compromisso.DataCompromisso = dtpDataCompromisso.Value;
            compromisso.Descricao = txtCompromisso.Text;
            using (var contexto = new Agenda.Context.ApplicationContext())
            {
                contexto.Compromisso.Add(compromisso);
                contexto.SaveChanges();
            }
            dtpDataCompromisso.Value = DateTime.MinValue;
            txtCompromisso.Text = String.Empty;
        }

        private void cmbCompromissos_DropDown(object sender, EventArgs e)
        {
            cmbCompromissos.Items.Clear();
            List<Compromisso> compromissos = new List<Compromisso>();
            using (var contexto = new Agenda.Context.ApplicationContext())
            {
                compromissos = contexto.Compromisso.ToList();
            }
            foreach (var item in compromissos)
            {
                cmbCompromissos.Items.Add(item.Descricao);
            }//}
            //compromissos.ForEach(pX =>
            //{
            //    cmbCompromissos.Items.AddRange(compromissos.ToArray());
            //});
            
        }
    }
}
