using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using KivetítőWPF3MVVMPages.ViewModel;

namespace KivetítőWPF3MVVMPages
{
    class DataAccsessLayer
    {
        //public void DalSzovegDataLoad(ref ViewModelLocator locator)
        //{
        //    using (StreamReader sr = new StreamReader())
        //    {
        //        while (!sr.EndOfStream)
        //        {

        //            //Beolvasás fájlból

        //        }
        //    }
        //}

        public void IgeDataLoad(ref ViewModelLocator locator)
        {
            using (StreamReader sr = new StreamReader(@"Bible/Biblia_Karoli.txt"))
            {
                string temp;
                int uresSorok = 0;
                while (!sr.EndOfStream)
                {
                    temp = sr.ReadLine();
                    Model.Igek tempModel;
                    if (temp == "")
                        uresSorok++;
                    if (uresSorok == 0 && temp != "")
                    {
                        tempModel = new Model.Igek();
                        tempModel.FejezetKaroli = Tuple.Create<string, int>( temp.Remove(temp.Length - 3), 0);
                        locator.MainView.igeAdatok.Add(tempModel);
                    }
                    else if (uresSorok == 1 && temp != "")
                    {

                    }
                    else if (uresSorok == 2 && temp != "")
                    {

                    }

                }
            }

        }
    }
}
