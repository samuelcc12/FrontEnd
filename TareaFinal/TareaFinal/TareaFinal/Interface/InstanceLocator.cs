﻿namespace TareaFinal.Interface
{
    public class InstanceLocator
    {

        #region Properties
        public MainViewModel Main { get; set; }
        #endregion

        #region Constructors
        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }
        #endregion
    }


}
