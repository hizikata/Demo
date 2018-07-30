using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight;
using CommonServiceLocator;

namespace Demo.ViewModel
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<ALineViewModel>();
            SimpleIoc.Default.Register<BLineVewModel>();
            SimpleIoc.Default.Register<CLineViewModel>();
            SimpleIoc.Default.Register<DLineViewModel>();
        }
        public MainViewModel Main
        {
            get
            {
                return SimpleIoc.Default.GetInstance<MainViewModel>();
            }
        }
        public ALineViewModel ALine
        {
            get
            {
                return SimpleIoc.Default.GetInstance<ALineViewModel>();
            }
        }
        public BLineVewModel BLine
        {
            get
            {
                return SimpleIoc.Default.GetInstance<BLineVewModel>();
            }
        }
        public CLineViewModel CLine
        {
            get
            {
                return SimpleIoc.Default.GetInstance<CLineViewModel>();
            }
        }
        public DLineViewModel DLine
        {
            get
            {
                return SimpleIoc.Default.GetInstance<DLineViewModel>();
            }
        }
    }
}
