namespace System.IO.Filesystem.Ntfs
{
    /// <summary>
    /// This is where the parts of the file are located on the volume.
    /// </summary>
    public interface IFragment
    {
        /// <summary>
        /// Logical cluster number, location on disk. 
        /// </summary>
        UInt64 Lcn { get; }

        /// <summary>
        /// Virtual cluster number of next fragment.
        /// </summary>
        UInt64 NextVcn { get; }
    }
}