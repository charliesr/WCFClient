using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WCFClient.WebReference;

namespace WCFClient
{
    public partial class Form1 : Form
    {
        private string protocolSelected;
        private IService1 webService;
        public Form1()
        {
            InitializeComponent();
            protocolSelected = rbHttp.Checked ? rbHttp.Text : rbTcp.Text;
            webService = new Service1Client(protocolSelected);
            lbProtocolSelected.Text = "Protocolo seleccionado: " + protocolSelected;
            foreach (var op in Enum.GetValues(typeof(Operation)).Cast<Operation>())
            {
                cbOperations.Items.Add(op);
            }
        }

        private void protocol_CheckedChanged(object sender, EventArgs e)
        {
            if (!((RadioButton)sender).Checked) return;
            webService = new Service1Client
                (((RadioButton)sender).Text);
            lbProtocolSelected.Text = "Protocolo seleccionado: " + ((RadioButton)sender).Text;
        }

        private void btExecute_Click(object sender, EventArgs e)
        {
            switch (cbOperations.SelectedItem)
            {
                case Operation.Suma:
                    lbResult.Text = webService.Suma
                        (Convert.ToInt32(tbNum1.Text),
                        Convert.ToInt32(tbNum2.Text)).ToString();
                    break;
                case Operation.Resta:
                    lbResult.Text = webService.Suma
                        (Convert.ToInt32(tbNum1.Text),
                        Convert.ToInt32(tbNum2.Text)).ToString();
                    break;
                case Operation.Multiplicacion:
                    lbResult.Text = webService.Suma
                        (Convert.ToInt32(tbNum1.Text),
                        Convert.ToInt32(tbNum2.Text)).ToString();
                    break;
                case Operation.Division:
                    lbResult.Text = webService.Suma
                        (Convert.ToInt32(tbNum1.Text),
                        Convert.ToInt32(tbNum2.Text)).ToString();
                    break;
            }
        }
    }
}
