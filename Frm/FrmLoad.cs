
using OptimizeDelete.AcessoDados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OptimizeDelete
{
    public partial class FrmLoad : Form
    {
        static string tab;
        static string item;
        static List<objeto> list = new List<objeto>();
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
       

        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nTopRect,
            int RightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse

            );
        public FrmLoad()
        {
            InitializeComponent();
            
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            circularProgressBar1.Value = 0;
            label3.MaximumSize = new Size(240, 0);
            label3.AutoSize = true;
            label2.MaximumSize = new Size(150, 0);
            label2.AutoSize = true;



        }

        public class objeto
        {
            public objeto(string tabela, string query)
            {
                this.tabela = tabela;
                this.query = query;
            }

            public string tabela { get; set; }
            public string query { get; set; }


        }

        public void adicionarSqlLista(string tabela, string novasql)
        {
            list.Add(new objeto(tabela, novasql));
        }

        bool executaComando()
        {
            AcessoDadosMysql acessoDados = new AcessoDadosMysql();

            double i = 0;
            

            for (int z = 0; list.Count > z; z++) {
                 item = list[z].query;
                tab = list[z].tabela;
              

                acessoDados.ExecutarConsulta(CommandType.Text, item);

               
               
                double  counttabelas = list.Count;
                double valorpercorre;
                valorpercorre = (double)100 / (double)counttabelas;
                i = i + valorpercorre;
                this.backgroundWorker1.ReportProgress(Convert.ToInt32(i));

            }
        

            
            
            return true;



        }
        

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            
         
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {


            if (executaComando() == true)
            {
                backgroundWorker1.ReportProgress(100);
            }




        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            circularProgressBar1.Value = e.ProgressPercentage;

            //informa o percentual na forma de texto.
            label1.Text = e.ProgressPercentage.ToString() + "%" ;
            label2.Text = "Deletando tabela " + tab + "...";
            label3.Text= item;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                //informa ao usuario do acontecimento de algum erro.
               label2.Text = "Aconteceu um erro durante a execução do processo!";
            }
            else
            {
                //informa que a tarefa foi concluida com sucesso.
               label2.Text="Deletes concluidos";
                list.Clear();
                this.Close();
            }
        }

        private void FrmLoad_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
            
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            
        }
    }
}
