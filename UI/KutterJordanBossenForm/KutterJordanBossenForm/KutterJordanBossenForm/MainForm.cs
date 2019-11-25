using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;
using System.Windows.Forms;

using KutterJordanBossen.IoC;

using KutterJordanBossenForm.Core;
using KutterJordanBossenForm.Interfaces;
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

        public decimal Density
        {
            get => nudDensity.Value;
            set => nudDensity.Value = value;
        }

        public decimal Robustness
        {
            get => nudRobustness.Value;
            set => nudRobustness.Value = value;
        }

        public int Seed
        {
            get => (int)nudSeed.Value;
            set => nudSeed.Value = value;
        }

        public int Redundancy
        {
            get => (int)nudRedundancy.Value;
            set => nudRedundancy.Value = value;
        }

        public string SourcePath
        {
            get => fdOpen.FileName;
            set => fdOpen.FileName = value;
        }

        public string ResultedPath
        {
            get => fdSave.FileName;
            set => fdSave.FileName = value;
        }

        public int NeighbourhoodLength
        {
            get => tbNeighbourhoodLength.Value;
            set => tbNeighbourhoodLength.Value = value;
        }

        public string OperationInfo
        {
            get => txtLog.Text;
            set => txtLog.Text = value;
        }


        public MainForm()
        {
            InitializeComponent();

            // TODO: change to IoC
            var service = Thread.CurrentThread.GetService<IEncryptionService>();
            _presenter = new MainFormPresenter(this, service);
        }

        private void OpenSourceImageHandler(object sender, EventArgs e)
        {
            try
            {
                fdOpen.Title = "Открыть изображение";
                fdOpen.Filter = "bmp (*.bmp)|*.bmp|jpg (*.jpg)|*.jpg|jpeg (*.jpeg)|*.jpeg|png (*.png)|*.png|Все файлы|*.*";

                if (fdOpen.ShowDialog() == DialogResult.OK)
                {
                    pbSourcePicture.Image = new Bitmap(fdOpen.FileName);

                    //TODO: enable encrypt button
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveSourceImageHandler(object sender, EventArgs e)
        {
            fdSave.Title = "Сохранить изображение";
            fdSave.Filter = "bmp (*.bmp)|*.bmp";
            if (fdSave.ShowDialog() == DialogResult.OK)
            {
                pbSourcePicture.Image.Save(fdSave.FileName, ImageFormat.Bmp);
            }
            //TODO: save resulted image to the new path. Ask user to reload new image to pictureBox
        }

        private void HashDarlingHandler(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                _presenter.Encrypt();
                Cursor.Current = Cursors.Default;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbRobustness_Scroll(object sender, EventArgs e)
        {
            nudRobustness.Value = ConvertTrackBarValue(sender);
        }

        private void tbDensity_Scroll(object sender, EventArgs e)
        {
            nudDensity.Value = ConvertTrackBarValue(sender);
        }

        private void tbNeighbourhoodLength_Scroll(object sender, EventArgs e)
        {
            if (sender is TrackBar trackBar)
            {
                nudNeighbourhoodLength.Value = trackBar.Value;
            }
        }

        private void nudDensity_ValueChanged(object sender, EventArgs e)
        {
            if (sender is NumericUpDown numericUpDown && numericUpDown.Focused)
            {
                tbDensity.Value = (int)(numericUpDown.Value * tbDensity.Maximum);
            }
        }

        private void nudRobustness_ValueChanged(object sender, EventArgs e)
        {
            if (sender is NumericUpDown numericUpDown && numericUpDown.Focused)
            {
                tbRobustness.Value = (int)(numericUpDown.Value * tbRobustness.Maximum);
            }
        }

        private void nudNeighbourhoodLength_ValueChanged(object sender, EventArgs e)
        {
            if (sender is NumericUpDown numericUpDown && numericUpDown.Focused)
            {
                tbNeighbourhoodLength.Value = (int)numericUpDown.Value;
            }
        }

        private decimal ConvertTrackBarValue(object sender)
        {
            if (sender is TrackBar trackBar)
            {
                return trackBar.Value / (decimal)trackBar.Maximum;
            }

            throw new ArgumentException("ConvertTrackBarValue(object sender): sender cannot convert to TrackBar");
        }
    }
}
