namespace ConexaoBDComTelas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void atualizaInterface()
        {
            Tarefa tarefa = new Tarefa();
            List<Tarefa> tarefas = tarefa.buscaTodos();
            foreach (Tarefa t in tarefas)
            {
                listTarefas.Items.Add($"{t.id} - {t.descricao}");
            }
        }

        private void btnSalvar_click(object sende, EventArgs e)
        {
            string descricao = txtTarefa.Text;
            bool concluido = cboxConcluido.Checked;

            Tarefa tarefa = new Tarefa();
            tarefa.descricao = descricao;
            tarefa.concluido = concluido;
            tarefa.Insere(tarefa);

            MessageBox.Show("Tarefa cadastrada com sucesso!");
            txtTarefa.Clear();
            cboxConcluido.Checked = false;
            atualizaInterface();



        }

        //--------------------------------

        private void Form1_Load(object sender, EventArgs e)
        {
            atualizaInterface();
        }
    }
}