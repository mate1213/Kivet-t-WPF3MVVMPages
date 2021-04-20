using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace KivetítőWPF3MVVMPages.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        #region Property

        public Model.Model model { get; set; }
        public Model.ButtonContent content { get; set; }
        public List<Model.Dal> dalAdatok { get; set; }
        public List<Model.Kep> kepAdatok { get; set; }
        public List<Model.Igek> igeAdatok { get; set; }

        #region Pages
        public Kep Kep { get; set; }
        public Ige Ige { get; set; }
        public Dal Dal { get; set; }
        public Video Video { get; set; }

        public DalEszkozok DalEszkozok { get; set; }
        public IgeEszkozok IgeEszkozok { get; set; }
        public KepEszkozok KepEszkozok { get; set; }
        public VideokEszkozok VideoEszkozok { get; set; }
        #endregion

        #endregion

        #region Constructor

        public MainViewModel()
        {
            #region Declaration
            
            Kep = new Kep();
            Ige = new Ige();
            Dal = new Dal();
            Video = new Video();
            IgeEszkozok = new IgeEszkozok();
            KepEszkozok = new KepEszkozok();
            DalEszkozok = new DalEszkozok();
            VideoEszkozok = new VideokEszkozok();
            dalAdatok = new List<Model.Dal>();
            kepAdatok = new List<Model.Kep>();
            igeAdatok = new List<Model.Igek>();

            model = new Model.Model()
            {
                Lapok = Ige,
                LapokEszkozok = IgeEszkozok
            };

            content = new Model.ButtonContent()
            {
                DalButtonContent = "Dalok",
                IgeButtonContent = "Igék",
                KepButtonContent = "Képek",
                VideoButtonContent = "Videók"
            };

            #endregion

            #region RelayCommands Declaration

            MiddleClickCommand = new RelayCommand<object>(Middle_Button);
            RightClickCommand = new RelayCommand<object>(Right_Button);
            LeftClickCommand = new RelayCommand<object>(Left_Button);

            #endregion

        }

        #endregion

        #region RelayCommands

        #region RelayCommands\Property

        public RelayCommand<object> MiddleClickCommand { get; set; }
        public RelayCommand<object> RightClickCommand { get; set; }
        public RelayCommand<object> LeftClickCommand { get; set; }

        #endregion

        #region Method

        private void Middle_Button(object button)
        {
            Button temp = button as Button;
            if (temp != null)
            {
                if (temp.Content.ToString() == content.IgeButtonContent)
                {
                    model.LapokEszkozok = IgeEszkozok;
                }
                else if (temp.Content.ToString() == content.DalButtonContent)
                {
                    model.LapokEszkozok = DalEszkozok;
                }
                else if (temp.Content.ToString() == content.KepButtonContent)
                {
                    model.LapokEszkozok = KepEszkozok;
                }
                else if (temp.Content.ToString() == content.VideoButtonContent)
                {
                    model.LapokEszkozok = VideoEszkozok;
                }
            }
        }
        private void Right_Button(object button)
        {
            Button temp = button as Button;
            if (temp != null)
            {
                if (temp.Content.ToString() == content.IgeButtonContent)
                {
                    model.Lapok = Ige;
                }
                else if (temp.Content.ToString() == content.DalButtonContent)
                {
                    model.Lapok = Dal;
                }
                else if (temp.Content.ToString() == content.KepButtonContent)
                {
                    model.Lapok = Kep;
                }
                else if (temp.Content.ToString() == content.VideoButtonContent)
                {
                    model.Lapok = Video;
                }
            }
        }
        private void Left_Button(object button)
        {
            Button temp = button as Button;
            if (temp != null)
            {
                if (temp.Content.ToString() == content.IgeButtonContent)
                {
                    model.Lapok = Ige;
                    model.LapokEszkozok = IgeEszkozok;
                }
                else if (temp.Content.ToString() == content.DalButtonContent)
                {
                    model.Lapok = Dal;
                    model.LapokEszkozok = DalEszkozok;
                }
                else if (temp.Content.ToString() == content.KepButtonContent)
                {
                    model.Lapok = Kep;
                    model.LapokEszkozok = KepEszkozok;
                }
                else if (temp.Content.ToString() == content.VideoButtonContent)
                {
                    model.Lapok = Video;
                    model.LapokEszkozok = VideoEszkozok;
                }
            }

        }

        #endregion

        #endregion

    }
}
