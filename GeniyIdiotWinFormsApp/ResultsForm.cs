using GeniyIdiot.Common;

namespace GeniyIdiotWinFormsApp
{
    public partial class ResultsForm : Form
    {
        private UsersResultStorage _usersResultStorage;
        public ResultsForm()
        {
            InitializeComponent();
            _usersResultStorage = new UsersResultStorage();
        }
        private void ResultsForm_Load(object sender, EventArgs e)
        {
            var users = _usersResultStorage.GetResults();
            foreach (var user in users)
            {
                var item = new ListViewItem(user.Name);
                item.SubItems.Add(user.RightAnswerCount.ToString());
                item.SubItems.Add(user.Diagnosis);
                listViewResults.Items.Add(item);
            }
        }
        private void MainMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}