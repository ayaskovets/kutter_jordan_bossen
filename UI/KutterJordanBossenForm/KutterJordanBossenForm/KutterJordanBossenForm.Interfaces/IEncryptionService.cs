namespace KutterJordanBossenForm.Interfaces
{
    public interface IEncryptionService
    {
        /// <summary>
        /// Calls method from unmanaged library which encrypt value
        /// </summary>
        /// <param name="pureMessage">message which will be encrypted</param>
        /// <returns>Status code of operation</returns>
        int Encrypt(string sourceFilePath, string resultFilePath, string pureMessage, int seed, int redundancy, float robustness, float density);

        /// <summary>
        /// Calls Method from unmanaged library which decrypt value
        /// </summary>
        /// <returns>Status code of operation</returns>
        string Decrypt(string sourceFilePath, int seed, int redundancy, int nbh_len, float density);
    }
}
