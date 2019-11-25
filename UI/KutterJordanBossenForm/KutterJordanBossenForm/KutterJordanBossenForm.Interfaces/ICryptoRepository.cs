namespace KutterJordanBossenForm.Interfaces
{
    public interface ICryptoRepository
    {
        int Insert(string sourceFilePath, string resultFilePath, string pureMessage, int messageBits, int seed, int redundancy, float robustness, float density);

        int Extract(string sourceFilePath, byte[] messageBuffer, int messageBits, int seed, int redundancy, int nbh_len, float density);
    }
}
