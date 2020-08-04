using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Vektorel.CustomControls;

namespace UtilityLib
{
    public class DogrulamaIslemleri
    {
        public static bool BoslukKontrol(Control.ControlCollection kontroller)
        {
            bool bosluk = false;
            foreach (Control item in kontroller)
            {

            
                    if (item is MyTextBox&&((MyTextBox)item).ZorunluAlan&&item.Text==string.Empty)
                    {                     
                           item.BackColor = Color.Red;
                            bosluk = true;                    
                    }
          }
            return bosluk;

        }
    }
}
