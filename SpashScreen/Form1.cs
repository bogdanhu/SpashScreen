using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpashScreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            FluentSplashScreenOptions options = new FluentSplashScreenOptions();
            options.Title = "Daedalus is back";
            options.Subtitle = "subtitle";
            options.RightFooter = "Right footer";
            options.LoadingIndicatorType = FluentLoadingIndicatorType.Ring;
            options.Opacity = 130;
            // options.OpacityColor = Color.DarkGreen;
            options.OpacityColor = Color.SeaGreen;
            SplashScreenManager.ShowFluentSplashScreen(options, useFadeIn:true,useFadeOut:true) ;
            System.Threading.Thread.Sleep(2000);
            InitializeComponent();
            SplashScreenManager.CloseForm();
        }
    }
}
