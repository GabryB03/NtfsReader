using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace System.IO.Filesystem.Ntfs
{
    /// <summary>
    /// Directory & Files Information are stored in inodes
    /// </summary>
    public interface INode
    {
        Attributes Attributes { get; }
        UInt32 NodeIndex { get; }
        UInt32 ParentNodeIndex { get; }
        string Name { get; }
        UInt64 Size { get; }
        string FullName { get; }
        IList<IStream> Streams { get; }

        DateTime CreationTime { get; }
        DateTime LastChangeTime { get; }
        DateTime LastAccessTime { get; }
    }
}
