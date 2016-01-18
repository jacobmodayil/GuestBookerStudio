using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guest_Booker_Studio.ViewModel
{
    public class ECCAssetsStructure : BaseFormViewModel
    {
        private string _assetName;
        public string AssetName
        {
            get
            {
                return _assetName;
            }
            set
            {
                _assetName = value;
                onPropertyChanged("AssetName");
            }
        }
    }
    public class ECCMiscellaneousStructure : BaseFormViewModel
    {
        private string _itemName;
        public string ItemName
        {
            get
            {
                return _itemName;
            }
            set
            {
                _itemName = value;
                onPropertyChanged("ItemName");
            }
        }
    }
}
