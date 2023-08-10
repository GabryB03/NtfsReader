namespace System.IO.Filesystem.Ntfs
{
    /// <summary>
    /// Disk information
    /// </summary>
    public interface IDiskInfo
    {
        UInt16 BytesPerSector { get; }
        byte SectorsPerCluster { get; }
        UInt64 TotalSectors { get; }
        UInt64 MftStartLcn { get; }
        UInt64 Mft2StartLcn { get; }
        UInt32 ClustersPerMftRecord { get; }
        UInt32 ClustersPerIndexRecord { get; }
        UInt64 BytesPerMftRecord { get; }
        UInt64 BytesPerCluster { get; }
        UInt64 TotalClusters { get; }
    }
}