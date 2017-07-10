using System.Collections.ObjectModel;
using System.Linq;

namespace WpfTreeView
{
    /// <summary>
    /// The view model for the applications main directory view
    /// </summary>
    public class DirectoryStructureViewModel : BaseViewModel
    {
        #region Public Properies

        /// <summary>
        /// A list of all directories on the machine
        /// </summary>
        public ObservableCollection<DirectoryItemViewModel> Items { get; set; }

        #endregion

        #region Contstructior

        /// <summary>
        /// Default constructor
        /// </summary>
        public DirectoryStructureViewModel()
        {

            //Get all logical drives
            var children = DirectoryStructure.GetLocicalDrives();
            
            // Create the view models for the data
            this.Items = new ObservableCollection<DirectoryItemViewModel>(children.
                Select(drive => new DirectoryItemViewModel(drive.FullPath, DirectoryItemType.Drive)));
        }

        #endregion
    }
}
