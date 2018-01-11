using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace automat_perkusyjny
{
    public class otwieranie_sampli
    {
        public string sampel ;
        public string nazwa; 

        public void otworz()
        {
            OpenFileDialog otwieranie = new OpenFileDialog();            
            if (otwieranie.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                otwieranie.Filter = "pliki wav lub mp3|*.wav;*.mp3";
                otwieranie.Title = "Wybierz dźwięk";
                sampel = otwieranie.FileName;
                nazwa = System.IO.Path.GetFileName(otwieranie.FileName);
                

                
            }
        }        
    }                
}











    

