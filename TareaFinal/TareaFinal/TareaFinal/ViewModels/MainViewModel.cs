using System;
using System.Collections.Generic;
using System.Text;

namespace TareaFinal.ViewModels
{
    public class MainViewModel
    {
        #region Constructor 
        public MainViewModel()
        {
            instance = this;


        }
        #endregion
        #region singleton
        private static MainViewModel instance;
        #endregion



    }
}
