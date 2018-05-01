using System.Windows.Forms;

namespace GraphDISM {
    public partial class FormInfoExt : Form {
        public FormInfoExt(string message) {
            InitializeComponent();
            txtOutputExt.Text = message;
        }
    }
}
