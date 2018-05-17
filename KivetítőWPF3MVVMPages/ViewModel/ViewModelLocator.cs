using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using CommonServiceLocator;

namespace KivetítőWPF3MVVMPages.ViewModel
{
    public class ViewModelLocator : ViewModelBase
    {
        #region Static Method to SimpleIoc Register
        static ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<IgeViewModel>();
            SimpleIoc.Default.Register<DalViewModel>();
            SimpleIoc.Default.Register<KepViewModel>();
            SimpleIoc.Default.Register<VideoViewModel>();
        }
        #endregion

        #region Fields
        private MainViewModel mainViewModel;
        private IgeViewModel igeViewModel;
        private DalViewModel dalViewModel;
        private KepViewModel kepViewModel;
        private VideoViewModel videoViewModel;
        #endregion

        #region Propertys
        public MainViewModel MainView
        {
            get { return ServiceLocator.Current.GetInstance<MainViewModel>(); }
            private set { mainViewModel = value; }
        }
        
        public IgeViewModel IgeView
        {
            get { return ServiceLocator.Current.GetInstance<IgeViewModel>(); }
            private set { igeViewModel = value; }
        }
        
        public DalViewModel DalView
        {
            get { return ServiceLocator.Current.GetInstance<DalViewModel>(); }
            private set { dalViewModel = value; }
        }

        public KepViewModel KepView
        {
            get { return ServiceLocator.Current.GetInstance<KepViewModel>(); }
            private set { kepViewModel = value; }
        }

        public VideoViewModel VideoView
        {
            get { return ServiceLocator.Current.GetInstance<VideoViewModel>(); }
            private set { videoViewModel = value; }
        }
        #endregion
    }
}
