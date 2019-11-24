using System.Text;

using KutterJordanBossenForm.Interfaces;

namespace KutterJordanBossenServices
{
    public class EncryptionService : IEncryptionService
    {
        private ICryptoRepository _cryptoRepository;

        public EncryptionService(ICryptoRepository cryptoRepository)
        {
            _cryptoRepository = cryptoRepository;
        }

        public string Decrypt(string sourceFilePath, int seed, int redundancy, int nbh_len, float density)
        {
            var buffer = new byte[42];
            var result = _cryptoRepository.Extract(sourceFilePath, buffer, 42 * 8, seed, redundancy, nbh_len, density);
            return Encoding.UTF8.GetString(buffer, 0, buffer.Length);
        }

        public int Encrypt(string sourceFilePath, string resultFilePath, string pureMessage, int seed, int redundancy, float robustness, float density)
        {
            return _cryptoRepository.Insert(sourceFilePath, resultFilePath, pureMessage, pureMessage.Length * 8, seed, redundancy, robustness, density);
        }
    }
}
