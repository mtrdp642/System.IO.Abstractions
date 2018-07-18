using System.Security.AccessControl;

namespace System.IO.Abstractions
{
    [Serializable]
    public class FileInfoWrapper : IFileInfo
    {
        private readonly FileInfo instance;

        public FileInfoWrapper(FileInfo instance)
        {
            this.instance = instance ?? throw new ArgumentNullException(nameof(instance));
        }

        public void Delete()
        {
            instance.Delete();
        }

        public void Refresh()
        {
            instance.Refresh();
        }

        public FileAttributes Attributes
        {
            get { return instance.Attributes; }
            set { instance.Attributes = value; }
        }

        public DateTime CreationTime
        {
            get { return instance.CreationTime; }
            set { instance.CreationTime = value; }
        }

        public DateTime CreationTimeUtc
        {
            get { return instance.CreationTimeUtc; }
            set { instance.CreationTimeUtc = value; }
        }

        public bool Exists
        {
            get { return instance.Exists; }
        }

        public string Extension
        {
            get { return instance.Extension; }
        }

        public string FullName
        {
            get { return instance.FullName; }
        }

        public DateTime LastAccessTime
        {
            get { return instance.LastAccessTime; }
            set { instance.LastAccessTime = value; }
        }

        public DateTime LastAccessTimeUtc
        {
            get { return instance.LastAccessTimeUtc; }
            set { instance.LastAccessTimeUtc = value; }
        }

        public DateTime LastWriteTime
        {
            get { return instance.LastWriteTime; }
            set { instance.LastWriteTime = value; }
        }

        public DateTime LastWriteTimeUtc
        {
            get { return instance.LastWriteTimeUtc; }
            set { instance.LastWriteTimeUtc = value; }
        }

        public string Name
        {
            get { return instance.Name; }
        }

        public StreamWriter AppendText()
        {
            return instance.AppendText();
        }

        public IFileInfo CopyTo(string destFileName)
        {
            return instance.CopyTo(destFileName);
        }

        public IFileInfo CopyTo(string destFileName, bool overwrite)
        {
            return instance.CopyTo(destFileName, overwrite);
        }

        public Stream Create()
        {
            return instance.Create();
        }

        public StreamWriter CreateText()
        {
            return instance.CreateText();
        }

#if NET40
        public void Decrypt()
        {
            instance.Decrypt();
        }

        public void Encrypt()
        {
            instance.Encrypt();
        }
#endif

        public FileSecurity GetAccessControl()
        {
            return instance.GetAccessControl();
        }

        public FileSecurity GetAccessControl(AccessControlSections includeSections)
        {
            return instance.GetAccessControl(includeSections);
        }

        public void MoveTo(string destFileName)
        {
            instance.MoveTo(destFileName);
        }

        public Stream Open(FileMode mode)
        {
            return instance.Open(mode);
        }

        public Stream Open(FileMode mode, FileAccess access)
        {
            return instance.Open(mode, access);
        }

        public Stream Open(FileMode mode, FileAccess access, FileShare share)
        {
            return instance.Open(mode, access, share);
        }

        public Stream OpenRead()
        {
            return instance.OpenRead();
        }

        public StreamReader OpenText()
        {
            return instance.OpenText();
        }

        public Stream OpenWrite()
        {
            return instance.OpenWrite();
        }

#if NET40
        public IFileInfo Replace(string destinationFileName, string destinationBackupFileName)
        {
            return instance.Replace(destinationFileName, destinationBackupFileName);
        }

        public IFileInfo Replace(string destinationFileName, string destinationBackupFileName, bool ignoreMetadataErrors)
        {
            return instance.Replace(destinationFileName, destinationBackupFileName, ignoreMetadataErrors);
        }
#endif

        public void SetAccessControl(FileSecurity fileSecurity)
        {
            instance.SetAccessControl(fileSecurity);
        }

        public IDirectoryInfo Directory
        {
            get { return instance.Directory; }
        }

        public string DirectoryName
        {
            get { return instance.DirectoryName; }
        }

        public bool IsReadOnly
        {
            get { return instance.IsReadOnly; }
            set { instance.IsReadOnly = value; }
        }

        public long Length
        {
            get { return instance.Length; }
        }
    }
}