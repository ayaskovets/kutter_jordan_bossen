using System.Runtime.InteropServices;

using KutterJordanBossenForm.Interfaces;

namespace KutterJordanBossenRepository
{
    public class NativeRepository : ICryptoRepository
    {
        [DllImport("img.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern int kjb_insert(
            string container_path,
            string result_path,
            string msg_ptr,
            int msg_bits,
            int seed,
            int redundancy,
            float robustness,
            float density
            );

        [DllImport("img.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern int kjb_extract(
            string img_path,
            byte[] msg_buffer,
            int msg_bits,
            int seed,
            int redundancy,
            int nbh_len,
            float density);

        public int Insert(string sourceFilePath, string resultFilePath, string pureMessage, int messageBits, int seed, int redundancy, float robustness, float density)
        {
            return kjb_insert(sourceFilePath, resultFilePath, pureMessage, messageBits, seed, redundancy, robustness, density);
        }

        public int Extract(string sourceFilePath, byte[] messageBuffer, int messageBits, int seed, int redundancy, int nbh_len, float density)
        {
            return kjb_extract(sourceFilePath, messageBuffer, messageBits, seed, redundancy, nbh_len, density);
        }
    }
}
