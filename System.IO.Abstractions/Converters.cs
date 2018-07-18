using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace System.IO.Abstractions
{
    internal static class Converters
    {
        internal static IEnumerable<IFileSystemInfo> WrapFileSystemInfos(this IEnumerable<FileSystemInfo> input)
            => input.Select(WrapFileSystemInfo);

        internal static IFileSystemInfo[] WrapFileSystemInfos(this FileSystemInfo[] input)
            => input.Select(WrapFileSystemInfo).ToArray();

        internal static IEnumerable<IDirectoryInfo> WrapDirectories(this IEnumerable<DirectoryInfo> input) 
            => input.Select(WrapDirectoryInfo);

        internal static IDirectoryInfo[] WrapDirectories(this DirectoryInfo[] input)
            => input.Select(WrapDirectoryInfo).ToArray();

        internal static IEnumerable<IFileInfo> WrapFiles(this IEnumerable<FileInfo> input) 
            => input.Select(WrapFileInfo);

        internal static IFileInfo[] WrapFiles(this FileInfo[] input) 
            => input.Select(WrapFileInfo).ToArray();
        
        private static IFileSystemInfo WrapFileSystemInfo(FileSystemInfo item)
        {
            if (item is FileInfo)
            {
                return WrapFileInfo((FileInfo)item);
            }
            else if (item is DirectoryInfo)
            {
                return WrapDirectoryInfo((DirectoryInfo)item);
            }
            else
            {
                throw new NotImplementedException(string.Format(
                    CultureInfo.InvariantCulture,
                    "The type {0} is not recognized by the System.IO.Abstractions library.",
                    item.GetType().AssemblyQualifiedName
                ));
            }
        }

        private static IFileInfo WrapFileInfo(FileInfo f) => (FileInfoBase)f;
    
        private static IDirectoryInfo WrapDirectoryInfo(DirectoryInfo d) => (IDirectoryInfo)d;
    }
}