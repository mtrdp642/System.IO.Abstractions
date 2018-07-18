using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;

namespace System.IO.Abstractions
{
    [Serializable]
    public class DirectoryInfoWrapper : IDirectoryInfo
    {
        private readonly DirectoryInfo instance;

        public DirectoryInfoWrapper(DirectoryInfo instance)
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

        public void Create()
        {
            instance.Create();
        }

#if NET40
        public void Create(DirectorySecurity directorySecurity)
        {
            instance.Create(directorySecurity);
        }
#endif

        public IDirectoryInfo CreateSubdirectory(string path)
        {
            return new DirectoryInfoWrapper(instance.CreateSubdirectory(path));
        }

#if NET40
        public IDirectoryInfo CreateSubdirectory(string path, DirectorySecurity directorySecurity)
        {
            return new DirectoryInfoWrapper(instance.CreateSubdirectory(path, directorySecurity));
        }
#endif

        public void Delete(bool recursive)
        {
            instance.Delete(recursive);
        }

        public IEnumerable<IDirectoryInfo> EnumerateDirectories()
        {
            return instance.EnumerateDirectories().Select(directoryInfo => new DirectoryInfoWrapper(directoryInfo));
        }

        public IEnumerable<IDirectoryInfo> EnumerateDirectories(string searchPattern)
        {
            return instance.EnumerateDirectories(searchPattern).Select(directoryInfo => new DirectoryInfoWrapper(directoryInfo));
        }

        public IEnumerable<IDirectoryInfo> EnumerateDirectories(string searchPattern, SearchOption searchOption)
        {
            return instance.EnumerateDirectories(searchPattern, searchOption).Select(directoryInfo => new DirectoryInfoWrapper(directoryInfo));
        }

        public IEnumerable<IFileInfo> EnumerateFiles()
        {
            return instance.EnumerateFiles().Select(fileInfo => new FileInfoWrapper(fileInfo));
        }

        public IEnumerable<IFileInfo> EnumerateFiles(string searchPattern)
        {
            return instance.EnumerateFiles(searchPattern).Select(fileInfo => new FileInfoWrapper(fileInfo));
        }

        public IEnumerable<IFileInfo> EnumerateFiles(string searchPattern, SearchOption searchOption)
        {
            return instance.EnumerateFiles(searchPattern, searchOption).Select(fileInfo => new FileInfoWrapper(fileInfo));
        }

        public IEnumerable<IFileSystemInfo> EnumerateFileSystemInfos()
        {
            return instance.EnumerateFileSystemInfos().WrapFileSystemInfos();
        }

        public IEnumerable<IFileSystemInfo> EnumerateFileSystemInfos(string searchPattern)
        {
            return instance.EnumerateFileSystemInfos(searchPattern).WrapFileSystemInfos();
        }

        public IEnumerable<IFileSystemInfo> EnumerateFileSystemInfos(string searchPattern, SearchOption searchOption)
        {
            return instance.EnumerateFileSystemInfos(searchPattern, searchOption).WrapFileSystemInfos();
        }

        public DirectorySecurity GetAccessControl()
        {
            return instance.GetAccessControl();
        }

        public DirectorySecurity GetAccessControl(AccessControlSections includeSections)
        {
            return instance.GetAccessControl(includeSections);
        }

        public IDirectoryInfo[] GetDirectories()
        {
            return instance.GetDirectories().WrapDirectories();
        }

        public IDirectoryInfo[] GetDirectories(string searchPattern)
        {
            return instance.GetDirectories(searchPattern).WrapDirectories();
        }

        public IDirectoryInfo[] GetDirectories(string searchPattern, SearchOption searchOption)
        {
            return instance.GetDirectories(searchPattern, searchOption).WrapDirectories();
        }

        public IFileInfo[] GetFiles()
        {
            return instance.GetFiles().WrapFiles();
        }

        public IFileInfo[] GetFiles(string searchPattern)
        {
            return instance.GetFiles(searchPattern).WrapFiles();
        }

        public IFileInfo[] GetFiles(string searchPattern, SearchOption searchOption)
        {
            return instance.GetFiles(searchPattern, searchOption).WrapFiles();
        }

        public IFileSystemInfo[] GetFileSystemInfos()
        {
            return instance.GetFileSystemInfos().WrapFileSystemInfos();
        }

        public IFileSystemInfo[] GetFileSystemInfos(string searchPattern)
        {
            return instance.GetFileSystemInfos(searchPattern).WrapFileSystemInfos();
        }

        public IFileSystemInfo[] GetFileSystemInfos(string searchPattern, SearchOption searchOption)
        {
            return instance.GetFileSystemInfos(searchPattern, searchOption).WrapFileSystemInfos();
        }

        public void MoveTo(string destDirName)
        {
            instance.MoveTo(destDirName);
        }

        public void SetAccessControl(DirectorySecurity directorySecurity)
        {
            instance.SetAccessControl(directorySecurity);
        }

        public IDirectoryInfo Parent
        {
            get { return instance.Parent; }
        }

        public IDirectoryInfo Root
        {
            get { return instance.Root; }
        }

        public string ToString()
        {
            return instance.ToString();
        }
    }
}