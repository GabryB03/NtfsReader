using System.Collections.Generic;
using System.Text;

namespace System.IO.Filesystem.Ntfs
{
    public partial class NtfsReader
    {
        /// <summary>
        /// Recurse the node hierarchy and construct its entire name
        /// stopping at the root directory.
        /// </summary>
        private string GetNodeFullNameCore(UInt32 nodeIndex)
        {
            UInt32 node = nodeIndex;

            Stack<UInt32> fullPathNodes = new Stack<UInt32>();
            fullPathNodes.Push(node);

            UInt32 lastNode = node;
            while (true)
            {
                UInt32 parent = _nodes[node].ParentNodeIndex;

                //loop until we reach the root directory
                if (parent == ROOTDIRECTORY)
                    break;

                if (parent == lastNode)
                    throw new InvalidDataException("Detected a loop in the tree structure.");

                fullPathNodes.Push(parent);

                lastNode = node;
                node = parent;
            }

            StringBuilder fullPath = new StringBuilder();
            fullPath.Append(_driveInfo.Name.TrimEnd(new char[] { '\\' }));

            while (fullPathNodes.Count > 0)
            {
                node = fullPathNodes.Pop();

                fullPath.Append(@"\");
                fullPath.Append(GetNameFromIndex(_nodes[node].NameIndex));
            }

            return fullPath.ToString();
        }
    }
}