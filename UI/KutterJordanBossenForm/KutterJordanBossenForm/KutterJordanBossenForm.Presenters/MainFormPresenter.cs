using KutterJordanBossenForm.Core;
using KutterJordanBossenForm.Interfaces;

namespace KutterJordanBossenForm.Presenters
{
    public class MainFormPresenter
    {
        private IMainFormView _view;

        private IEncryptionService _service;

        public MainFormPresenter(IMainFormView view, IEncryptionService service)
        {
            _view = view;
            // TODO: Change to IoC
            _service = service ?? new KutterJordanBossenServices.EncryptionService(null);
        }

        public void Encrypt()
        {
            _service.Encrypt(_view.SourcePath, _view.ResultedPath, _view.Message, _view.Seed, _view.Redundancy, (float)_view.Robustness, (float)_view.Density);
        }

        public void Decrypt()
        {
            _service.Decrypt(_view.SourcePath, _view.Seed, _view.Redundancy, _view.NeighbourhoodLength, (float)_view.Density);
        }

    }
}
