using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Explorer.Shared.ViewModels
{

    internal class MainViewModel : BaseViewModel
        {
            private string _mainDiskName;

        #region public
        public string FilePath { get; set; }
        //public string MainDiskName { get; set; }
        public string DirectoriesAndFiles { get; set; }

        public FileEntityViewModel SelectedFileEntity { get; set; }
        #endregion

        #region events

        #endregion

        #region Constructor
            public MainViewModel()
            {
                OpenCommand = new DelegateCommand(Open);
            //    MainDiskName = Environment.SystemDirectory;
            }
        #endregion

        #region Protected

        #endregion

        #region Commands
            public ICommand OpenCommand { get; }
        #endregion

        #region CommandsMethods
            private void Open(object parameter) 
            {
                if(parameter is DirectoryViewModel directoryViewModel) 
                {
                    FilePath = directoryViewModel.Name;

                    DirectoriesAndFiles.Clear();

                    var directoryInfo = new DirectoryInfo(FilePath);

                foreach (var directory in directoryInfo.GetDirectories())
                {

                }
                }
            }
        #endregion
    }
}

