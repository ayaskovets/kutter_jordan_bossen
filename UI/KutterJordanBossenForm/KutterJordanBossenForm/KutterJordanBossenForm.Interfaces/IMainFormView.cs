namespace KutterJordanBossenForm.Core
{
    public interface IMainFormView
    {
        /// <summary>
        /// Represents typed text by user
        /// </summary>
        string Message { get; set; }

        /// <summary>
        /// Probability of a bit being inserted into a pixel. Must be between 0 and 1. Uses to increase cryptographic strength
        /// </summary>
        decimal Density { get; set; }

        /// <summary>
        /// Sets robustness of the encoded message. Must be between 0 and 1. The greater its value the more 'visible' the encoded data.
        /// </summary>
        decimal Robustness { get; set; }

        /// <summary>
        /// A seed for a pseudo-random number generator. Acts like a key.
        /// </summary>
        int Seed { get; set; }

        /// <summary>
        /// Max number of times which each bit gets inserted
        /// </summary>
        int Redundancy { get; set; }

        /// <summary>
        /// Path to the image
        /// </summary>
        string SourcePath { get; set; }

        /// <summary>
        /// Path where resulted image will be saved
        /// </summary>
        string ResultedPath { get; set; }

        /// <summary>
        /// Size of a pixel neighbourhood area that is used for computing the predicated blue color value.
        /// </summary>
        int NeighbourhoodLength { get; set; }

        /// <summary>
        /// Info about executed operation
        /// </summary>
        string OperationInfo { get; set; }
    }
}
