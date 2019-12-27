﻿namespace TareaFinal.ViewModels
{
    using TareaFinal.Models;
    using System.Collections.Generic;

    public class MainViewModel
    {
        #region Properties
        public List<Contact> ContactList { get; set; }
        #endregion

        #region ViewModel
        public ContactViewModel contactViewModel { get; set; }
        #endregion

        #region Constructor
        public MainViewModel()
        {
            instance = this;
            this.contactViewModel = new ContactViewModel();
        }
        #endregion

        #region singleton
        private static MainViewModel instance;

        public static MainViewModel GetInstance()
        {
            if (instance == null)
            {
                instance = new MainViewModel();
            }
            return (instance);
        }
        #endregion



    }

}
