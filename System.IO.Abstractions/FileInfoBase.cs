using System.Security.AccessControl;

namespace System.IO.Abstractions
{
    /// <inheritdoc cref="FileInfo"/>
    public interface IFileInfo : IFileSystemInfo
    {
        /// <inheritdoc cref="FileInfo.AppendText"/>
        StreamWriter AppendText();

        /// <inheritdoc cref="FileInfo.CopyTo(string)"/>
        IFileInfo CopyTo(string destFileName);

        /// <inheritdoc cref="FileInfo.CopyTo(string,bool)"/>
        IFileInfo CopyTo(string destFileName, bool overwrite);

        /// <inheritdoc cref="FileInfo.Create"/>
        Stream Create();

        /// <inheritdoc cref="FileInfo.CreateText"/>
        StreamWriter CreateText();

#if NET40
        /// <inheritdoc cref="FileInfo.Decrypt"/>
        void Decrypt();

        /// <inheritdoc cref="FileInfo.Encrypt"/>
        void Encrypt();
#endif

        /// <inheritdoc cref="FileInfo.GetAccessControl()"/>
        FileSecurity GetAccessControl();

        /// <inheritdoc cref="FileInfo.GetAccessControl(AccessControlSections)"/>
        FileSecurity GetAccessControl(AccessControlSections includeSections);

        /// <inheritdoc cref="FileInfo.MoveTo"/>
        void MoveTo(string destFileName);

        /// <inheritdoc cref="FileInfo.Open(FileMode)"/>
        Stream Open(FileMode mode);

        /// <inheritdoc cref="FileInfo.Open(FileMode,FileAccess)"/>
        Stream Open(FileMode mode, FileAccess access);

        /// <inheritdoc cref="FileInfo.Open(FileMode,FileAccess,FileShare)"/>
        Stream Open(FileMode mode, FileAccess access, FileShare share);

        /// <inheritdoc cref="FileInfo.OpenRead"/>
        Stream OpenRead();

        /// <inheritdoc cref="FileInfo.OpenText"/>
        StreamReader OpenText();

        /// <inheritdoc cref="FileInfo.OpenWrite"/>
        Stream OpenWrite();

#if NET40
        /// <inheritdoc cref="FileInfo.Replace(string,string)"/>
        IFileInfo Replace(string destinationFileName, string destinationBackupFileName);

        /// <inheritdoc cref="FileInfo.Replace(string,string,bool)"/>
        IFileInfo Replace(string destinationFileName, string destinationBackupFileName, bool ignoreMetadataErrors);
#endif

        /// <inheritdoc cref="FileInfo.SetAccessControl(FileSecurity)"/>
        void SetAccessControl(FileSecurity fileSecurity);

        /// <inheritdoc cref="FileInfo.Directory"/>
        IDirectoryInfo Directory { get; }

        /// <inheritdoc cref="FileInfo.DirectoryName"/>
        string DirectoryName { get; }

        /// <inheritdoc cref="FileInfo.IsReadOnly"/>
        bool IsReadOnly { get; set; }

        /// <inheritdoc cref="FileInfo.Length"/>
        long Length { get; }
    }

    /// <inheritdoc cref="FileInfo"/>
    [Serializable]
    public abstract class FileInfoBase : IFileInfo
    {
        /// <inheritdoc cref="FileInfo.AppendText"/>
        public abstract StreamWriter AppendText();

        /// <inheritdoc cref="FileInfo.CopyTo(string)"/>
        public abstract IFileInfo CopyTo(string destFileName);

        /// <inheritdoc cref="FileInfo.CopyTo(string,bool)"/>
        public abstract IFileInfo CopyTo(string destFileName, bool overwrite);

        /// <inheritdoc cref="FileInfo.Create"/>
        public abstract Stream Create();

        /// <inheritdoc cref="FileInfo.CreateText"/>
        public abstract StreamWriter CreateText();

#if NET40
        /// <inheritdoc cref="FileInfo.Decrypt"/>
        public abstract void Decrypt();

        /// <inheritdoc cref="FileInfo.Encrypt"/>
        public abstract void Encrypt();
#endif

        /// <inheritdoc cref="FileInfo.GetAccessControl()"/>
        public abstract FileSecurity GetAccessControl();

        /// <inheritdoc cref="FileInfo.GetAccessControl(AccessControlSections)"/>
        public abstract FileSecurity GetAccessControl(AccessControlSections includeSections);

        /// <inheritdoc cref="FileInfo.MoveTo"/>
        public abstract void MoveTo(string destFileName);

        /// <inheritdoc cref="FileInfo.Open(FileMode)"/>
        public abstract Stream Open(FileMode mode);

        /// <inheritdoc cref="FileInfo.Open(FileMode,FileAccess)"/>
        public abstract Stream Open(FileMode mode, FileAccess access);

        /// <inheritdoc cref="FileInfo.Open(FileMode,FileAccess,FileShare)"/>
        public abstract Stream Open(FileMode mode, FileAccess access, FileShare share);

        /// <inheritdoc cref="FileInfo.OpenRead"/>
        public abstract Stream OpenRead();

        /// <inheritdoc cref="FileInfo.OpenText"/>
        public abstract StreamReader OpenText();

        /// <inheritdoc cref="FileInfo.OpenWrite"/>
        public abstract Stream OpenWrite();

#if NET40
        /// <inheritdoc cref="FileInfo.Replace(string,string)"/>
        public abstract IFileInfo Replace(string destinationFileName, string destinationBackupFileName);

        /// <inheritdoc cref="FileInfo.Replace(string,string,bool)"/>
        public abstract IFileInfo Replace(string destinationFileName, string destinationBackupFileName, bool ignoreMetadataErrors);
#endif

        /// <inheritdoc cref="FileInfo.SetAccessControl(FileSecurity)"/>
        public abstract void SetAccessControl(FileSecurity fileSecurity);

        /// <inheritdoc cref="FileInfo.Delete"/>
        public abstract void Delete();

        /// <inheritdoc cref="FileSystemInfo.Refresh"/>
        public abstract void Refresh();

        /// <inheritdoc cref="FileInfo.Directory"/>
        public abstract IDirectoryInfo Directory { get; }

        /// <inheritdoc cref="FileInfo.DirectoryName"/>
        public abstract string DirectoryName { get; }

        /// <inheritdoc cref="FileInfo.IsReadOnly"/>
        public abstract bool IsReadOnly { get; set; }

        /// <inheritdoc cref="FileInfo.Length"/>
        public abstract long Length { get; }

        /// <inheritdoc cref="FileSystemInfo.Attributes"/>
        public abstract FileAttributes Attributes { get; set; }

        /// <inheritdoc cref="FileSystemInfo.CreationTime" />
        public abstract DateTime CreationTime { get; set; }

        /// <inheritdoc cref="FileSystemInfo.CreationTimeUtc" />
        public abstract DateTime CreationTimeUtc { get; set; }

        /// <inheritdoc cref="FileSystemInfo.Exists" />
        public abstract bool Exists { get; }

        /// <inheritdoc cref="FileSystemInfo.Extension" />
        public abstract string Extension { get; }

        /// <inheritdoc cref="FileSystemInfo.FullName" />
        public abstract string FullName { get; }

        /// <inheritdoc cref="FileSystemInfo.LastAccessTime" />
        public abstract DateTime LastAccessTime { get; set; }

        /// <inheritdoc cref="FileSystemInfo.LastAccessTimeUtc" />
        public abstract DateTime LastAccessTimeUtc { get; set; }

        /// <inheritdoc cref="FileSystemInfo.LastWriteTime" />
        public abstract DateTime LastWriteTime { get; set; }

        /// <inheritdoc cref="FileSystemInfo.LastWriteTimeUtc" />
        public abstract DateTime LastWriteTimeUtc { get; set; }

        /// <inheritdoc cref="FileSystemInfo.Name" />
        public abstract string Name { get; }

        public static implicit operator FileInfoBase(FileInfo fileInfo)
        {
            return new FileInfoWrapper(fileInfo);
        }
    }
}