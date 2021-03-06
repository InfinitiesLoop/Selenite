﻿using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Selenite.Client.ViewModels.WebAutomation
{
    public class ManifestViewModel : ViewModelBase
    {
        public ManifestViewModel()
        {
            TestCollections = new ObservableCollection<TestCollectionSummaryViewModel>();
        }

        public string Name
        {
            get { return Get(() => Name); }
            set { Set(value, () => Name); }
        }

        public string DomainOverride
        {
            get { return Get(() => DomainOverride); }
            set
            {
                Set(value, () => DomainOverride);
                if (DomainOverrideChangedCommand != null)
                {
                    DomainOverrideChangedCommand.Execute(value);
                }
            }
        }

        public ICommand DomainOverrideChangedCommand { get; set; }

        public ObservableCollection<TestCollectionSummaryViewModel> TestCollections { get; set; }
    }
}