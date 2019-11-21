namespace KutterJordanBossenForm.Interfaces
{
    public interface IEncryptionService
    {
        /// <summary>
        /// Calls method from unmanaged library which encrypt value
        /// </summary>
        /// <param name="message">message which will be encrypted</param>
        /// <returns>Status code of operation</returns>
        int Encrypt(string message);

        /// <summary>
        /// Calls Method from unmanaged library which decrypt value
        /// </summary>
        /// <returns>Status code of operation</returns>
        int Decrypt();
    }
}
