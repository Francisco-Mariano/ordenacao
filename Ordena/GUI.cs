using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ordena
{
    public partial class GUI : Form
    {
        // Atributos
        Ordenar ordenar;
        int[] v_origem;
        Random r;

        public GUI()
        {
            InitializeComponent();
        }

        // Carrega o Form
        private void GUI_Load(object sender, EventArgs e)
        {
            // Cria uma classe para ordenação
            ordenar = new Ordenar();
            r = new Random(DateTime.Now.Millisecond);
            cbMethods.SelectedIndex = 0;
        }

        // Sorteando origem
        private void btnGerar_Click(object sender, EventArgs e)
        {
            v_origem = new int[(int)nudCasos.Value];
            for (int i = 0; i < v_origem.Length; i++)
            {
                v_origem[i] = i; 
            }
            for (int i = 0; i < v_origem.Length; i++)
            {
                int x = r.Next(v_origem.Length);
                int y = r.Next(v_origem.Length);
                int temp = v_origem[x];
                v_origem[x] = v_origem[y];
                v_origem[y] = temp;
            }
            
            if (cbShow.Checked)
                Apresentar(lstOrigem, v_origem);
        }

        // Ordenar
        private void btnOrdena_Click(object sender, EventArgs e)
        {
            // Copiando o vetor
            int[] v = (int []) v_origem.Clone();
            //int[] v = { 0, 0, 0 };

            // Medindo tempo
            DateTime ini = DateTime.Now;
            // Ordenando
            switch (cbMethods.Text)
            {
                case "Inserção": ordenar.InsertOrder(v); break;
                case "Bolha": ordenar.BubbleOrder(v); break;
                case "Quick Sort": ordenar.QuickSortOrder(v); break;
                case "Seleção": ordenar.SelectionOrder(v); break;
                case "Merge Sort": ordenar.MergeSortOrder(v); break;
            }
            // Verificando tempo
            TimeSpan ts = DateTime.Now - ini;
            lblTempo.Text = ts.TotalMilliseconds.ToString();

            // Mostrando
            if (cbShow.Checked)
                Apresentar(lstOrdenada, v);
        }

        // Apresenta o vetor na listbox
        public void Apresentar(ListBox lb, int [] v)
        {
            lb.Items.Clear();
            for (int i = 0; i < v.Length; i++)
            {
                lb.Items.Add(v[i]);
            }
        }


    }
}