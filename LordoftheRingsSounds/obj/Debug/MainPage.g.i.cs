﻿#pragma checksum "C:\Users\Jérémy\Documents\Visual Studio 2012\Projects\LordoftheRingsSounds\LordoftheRingsSounds\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9E70D13296885C1115C95E5851C365BA"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.34014
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace LordoftheRingsSounds {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Image BackImage;
        
        internal System.Windows.Controls.MediaElement AudioPlayer;
        
        internal System.Windows.Controls.Image LogoLOTR;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton PlayButton;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/LordoftheRingsSounds;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.BackImage = ((System.Windows.Controls.Image)(this.FindName("BackImage")));
            this.AudioPlayer = ((System.Windows.Controls.MediaElement)(this.FindName("AudioPlayer")));
            this.LogoLOTR = ((System.Windows.Controls.Image)(this.FindName("LogoLOTR")));
            this.PlayButton = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("PlayButton")));
        }
    }
}

