using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace project
{
    public partial class IContactRepository : Form
    {
        private ContactContext _DbContext;
        private bool isAggiungiContattoButtonPressed = false;
        private bool isAggiornaContattoButtonPressed = false;
        private bool isRecuperaContattoButtonPressed = false;
        private bool isEliminaContattoButtonPressed = false;


        public IContactRepository()
        {
            InitializeComponent();
            AggiungiContattoMenuBTN.Click += AggiungiContattoMenuBTN_Click;
            AggiornaContattoMenuBTN.Click += AggiornaContattoMenuBTN_Click;
            RecuperaContattoMenuBTN.Click += RecuperaContattoMenuBTN_Click;
            EliminaContattoMenuBTN.Click += EliminaContattoMenuBTN_Click;
            AggiungiPanel.Hide();
            AggiornaPanel.Hide();
            RecuperaPanel.Hide();
            EliminaPanel.Hide();
            InitializeComponent();
            _DbContext = new ContactContext($"Data Source=localhost\\sqlexpress");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void AggiungiContattoMenuBTN_Click(object sender, EventArgs e)
        {


            isAggiungiContattoButtonPressed = true;
            

            
            if (isAggiungiContattoButtonPressed)
            {
                AggiungiPanel.Show();
                EliminaPanel.Hide();
                AggiornaPanel.Hide();
                RecuperaPanel.Hide();
            }
            else
            {
                AggiungiPanel.Hide();
            }



        }

        private void EliminaContattoMenuBTN_Click(object sender, EventArgs e)
        {
            isEliminaContattoButtonPressed = true;
            if (isAggiungiContattoButtonPressed)
            {

                EliminaPanel.Show();
                AggiungiPanel.Hide();
                RecuperaPanel.Hide();
                AggiornaPanel.Hide();
            }
            else
            {
                EliminaPanel.Hide();
            }
        }





        private void AggiornaContattoMenuBTN_Click(object sender, EventArgs e)
        {
            isAggiornaContattoButtonPressed = true;

            if (isAggiungiContattoButtonPressed)
            {

                AggiornaPanel.Show();
                AggiungiPanel.Hide();
                RecuperaPanel.Hide();
                EliminaPanel.Hide();
            }
            else
            {
                AggiornaPanel.Hide();
            }
        }





        private void RecuperaContattoMenuBTN_Click(object sender, EventArgs e)
        {
            isRecuperaContattoButtonPressed = true;

            if (isAggiungiContattoButtonPressed)
            {

                RecuperaPanel.Show();
                AggiungiPanel.Hide();
                EliminaPanel.Hide();
                AggiornaPanel.Hide();
            }
            else
            {
                RecuperaPanel.Hide();
            }
        }





        private void AggiungiPanel_Paint(object sender, PaintEventArgs e)
        {

            

        }

        private void AggiornaPanel_Paint_1(object sender, PaintEventArgs e)
        {
            
        }

        private void EliminaPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

      

        private void RecuperaPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }
         
        private async void AggiungiContattoBTN_Click(object sender, EventArgs e)
        {
            var tempCustomer = new Customer();
            var tempContact = new Contact();
            if(NomeClienteAggiungiTXT.Text != ""){
                tempContact.Nome = NomeClienteAggiungiTXT.Text;
            }
            else
            {
                MessageBox.Show("Il campo Nome è vuoto");
            }

            if(CognomeClienteAggiungiTXT.Text != "")
            {
                tempCustomer.Cognome = CognomeClienteAggiungiTXT.Text;
            }
            else
            {
                MessageBox.Show("Il campo Cognome è vuoto");
            }
            
            if(EmailClienteAggiungiTXT.Text != "")
            {   

                tempCustomer.Email = EmailClienteAggiungiTXT.Text;
            }
            else
            {
                MessageBox.Show("Il campo email è vuoto");
            }

            _DbContext.Contacts.Add(tempContact);
            int result2 = _DbContext.SaveChanges();
            



            
       

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NomeAggiungiTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void RecuperaContattoBTN_Click(object sender, EventArgs e)
        {
            string id = "";
            if(IdClienteRecuperaTXT.Text != "")
            {
                id = IdClienteRecuperaTXT.Text;
            }
            else
            {
                Console.WriteLine("il campo Id è vuoto");
            }
        }

        private void AggiornaContattoBTN_Click(object sender, EventArgs e)
        {

            
            if (IdClienteEliminaTXT.Text != "")
            {
                var idDaEliminare = Convert.ToInt32(IdClienteEliminaTXT.Text);

                var trovaContatto = _DbContext.Contacts.FirstOrDefault(x => x.IdCliente == idDaEliminare);
                if (trovaContatto != null)
                {
                    _DbContext.Contacts.Remove(trovaContatto);
                    int result = _DbContext.SaveChanges();
                }
            }
            else
            {
                MessageBox.Show("il campo Id è vuoto");
            }

            var tempContact = new Contact();
            if (NomeClienteAggiungiTXT.Text != "")
            {
                tempContact.Nome = NomeClienteAggiungiTXT.Text;
            }
            else
            {
                MessageBox.Show("Il campo Nome è vuoto");
            }

            if (CognomeClienteAggiungiTXT.Text != "")
            {
                tempContact.Cognome = CognomeClienteAggiungiTXT.Text;
            }
            else
            {
                MessageBox.Show("Il campo Cognome è vuoto");
            }

            if (EmailClienteAggiungiTXT.Text != "")
            {
                tempContact.Email = EmailClienteAggiungiTXT.Text;
            }
            else
            {
                MessageBox.Show("Il campo email è vuoto");
            }

            _DbContext.Contacts.Add(tempContact);
            int result2 = _DbContext.SaveChanges();



        }

        private void EliminaContattoBTN_Click(object sender, EventArgs e)
        {
            
            if (IdClienteEliminaTXT.Text != "")
            {
                var idDaEliminare = Convert.ToInt32(IdClienteEliminaTXT.Text);
                var trovaContatto = _DbContext.Contacts.FirstOrDefault(x => x.IdCliente == idDaEliminare);
                if (trovaContatto != null)
                {
                    _DbContext.Contacts.Remove(trovaContatto);
                    int result = _DbContext.SaveChanges();
                }
            }
            else
            {
                MessageBox.Show( "il campo Id è vuoto");
            }
        }

        private void AggiungiFornitoreBTN_Click(object sender, EventArgs e)
        {
            var tempSupplier = new Supplier();
            var tempContact = new Contact();
            if (NomeFornitoreAggiungiTXT.Text != "")
            {
                tempSupplier.Nome = NomeFornitoreAggiungiTXT.Text;
            }
            else
            {
                MessageBox.Show("Il campo Nome è vuoto");
            }

            if (CognomeFornitoreAggiungiTXT.Text != "")
            {
                tempSupplier.Cognome = CognomeFornitoreAggiungiTXT.Text;
            }
            else
            {
                MessageBox.Show("Il campo Cognome è vuoto");
            }

            if (EmailFornitoreAggiungiTXT.Text != "")
            {
                tempSupplier.Email = EmailFornitoreAggiungiTXT.Text;
            }
            else
            {
                MessageBox.Show("Il campo email è vuoto");
            }

            if (TelefonoFornitoreAggiungiTXT.Text != "")
            {
                var telefono = Convert.ToInt32(TelefonoFornitoreAggiungiTXT.Text);
                tempSupplier.Telefono = telefono;
            }
            else
            {
                MessageBox.Show("Il campo numero telefono è vuoto");
            }

            if (CittaFornitoreAggiungiTXT.Text != "")
            {
                tempSupplier.Città = CittaFornitoreAggiungiTXT.Text;
            }
            else
            {
                MessageBox.Show("Il campo città è vuoto");
            }
            _DbContext.Contacts.Add(tempSupplier);
            _DbContext.Contacts.Add(tempContact);
            int result2 = _DbContext.SaveChanges();
        }

        private void EliminaFornitoreBTN_Click(object sender, EventArgs e)
        {
            if (IdFornitoreEliminaTXT.Text != "")
            {
                var idDaEliminare = Convert.ToInt32(IdFornitoreEliminaTXT.Text);
                var trovaContatto = _DbContext.Contacts.FirstOrDefault(x => x.IdFornitore == idDaEliminare);
                if (trovaContatto != null)
                {
                    _DbContext.Contacts.Remove(trovaContatto);
                    int result = _DbContext.SaveChanges();
                }
            }
            else
            {
                MessageBox.Show("il campo Id è vuoto");
            }
        }
    }
}
