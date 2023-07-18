using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula06Streaming
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string titulo = "Clube da Luta";
            string descricao = "Um homem deprimido que sofre de insônia conhece um estranho vendedor chamado Tyler Durden e se vê morando em uma casa suja depois que seu perfeito apartamento é destruído. A dupla forma um clube com regras rígidas onde homens lutam. A parceria perfeita é comprometida quando uma mulher, Marla, atrai a atenção de Tyler.";
            string caminho_imagem = "C:/Users/stella.gmendonca/source/repos/Aula06Streaming/Aula06Streaming/imagens/Clube_da_luta.jpg";
            string link_video = "https://www.youtube.com/embed/eBKvlCf0B4g?autoplay=true";


            Form2 telaInfo = new Form2();
            telaInfo.titulo = titulo;
            telaInfo.descricao = descricao;
            telaInfo.caminho_imagem = caminho_imagem;
            telaInfo.link_video = link_video;
            
            telaInfo.Show();


        }
    }
}
