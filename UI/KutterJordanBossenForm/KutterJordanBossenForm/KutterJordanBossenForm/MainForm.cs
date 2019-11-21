using System;
using System.Windows.Forms;

using KutterJordanBossenForm.Core;
using KutterJordanBossenForm.Presenters;

namespace KutterJordanBossenForm
{
    public partial class MainForm : Form, IMainFormView
    {
        private MainFormPresenter _presenter;

        public string Message
        {
            get => txtMessage.Text;
            set => txtMessage.Text = value;
        }

        public MainForm()
        {
            InitializeComponent();
            
            // TODO: change to IoC
            _presenter = new MainFormPresenter(this, null);
        }

        private void OpenSourceImageHandler(object sender, EventArgs e)
        {
            //TODO: save file path. send it to unmanaged assembly and show image.
        }

        private void SaveSourceImageHandler(object sender, EventArgs e)
        {
            //TODO: save resulted image to the new path. Ask user to reload new image to pictureBox
        }

        private void HashDarlingHandler(object sender, EventArgs e)
        {
            _presenter.Hash();
        }
    }
}
