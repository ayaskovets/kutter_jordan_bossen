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
            _service = service;
        }

        public void Hash()
        {
            _service.Encrypt(_view.Message);
        }
    }
}
