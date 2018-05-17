using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace KivetítőWPF3MVVMPages
{
    class DataAccsessLayer
    {
        public void DataLoad(ref List<Model.Dalok> dals)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(ofd.FileName))
                {
                    while (!sr.EndOfStream)
                    {
                        Model.Dalok Temp = new Model.Dalok();
                        //Beolvasás fájlból
                        dals.Add(Temp);
                    }
                }
            }

        }
    }
}
