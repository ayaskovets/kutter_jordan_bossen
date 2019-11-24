namespace KutterJordanBossenForm.Core
{
    public interface IMainFormView
    {
        /// <summary>
        /// Represents typed text by user
        /// </summary>
        string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        decimal Density { get; set; }

        /// <summary>
        /// 
        /// </summary>
        decimal Robustness { get; set; }

        /// <summary>
        /// 
        /// </summary>
        int Seed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        string SourcePath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        string ResultedPath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        int NeighbourhoodLength { get; set; }
    }
}
