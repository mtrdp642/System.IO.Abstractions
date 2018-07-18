namespace System.IO.Abstractions
{
    [Serializable]
    public class FileSystem : IFileSystem
    {
        IDirectory directory;
        public IDirectory Directory
        {
            get { return directory ?? (directory = new DirectoryWrapper()); }
        }

        IFile file;
        public IFile File
        {
            get { return file ?? (file = new FileWrapper()); }
        }

        FileInfoFactory fileInfoFactory;
        public IFileInfoFactory FileInfo
        {
            get { return fileInfoFactory ?? (fileInfoFactory = new FileInfoFactory()); }
        }

        FileStreamFactory fileStreamFactory;
        public IFileStreamFactory FileStream
        {
            get { return fileStreamFactory ?? (fileStreamFactory = new FileStreamFactory()); }
        }

        IPath path;
        public IPath Path
        {
            get { return path ?? (path = new PathWrapper()); }
        }

        DirectoryInfoFactory directoryInfoFactory;
        public IDirectoryInfoFactory DirectoryInfo
        {
            get { return directoryInfoFactory ?? (directoryInfoFactory = new DirectoryInfoFactory()); }
        }

        private readonly Lazy<DriveInfoFactory> driveInfoFactory = new Lazy<DriveInfoFactory>(() => new DriveInfoFactory());

        public IDriveInfoFactory DriveInfo
        {
            get { return driveInfoFactory.Value; }
        }
		
        private IFileSystemWatcherFactory fileSystemWatcherFactory;
        public IFileSystemWatcherFactory FileSystemWatcher
        {
            get { return fileSystemWatcherFactory ?? (fileSystemWatcherFactory = new FileSystemWatcherFactory()); }
        }
    }
}