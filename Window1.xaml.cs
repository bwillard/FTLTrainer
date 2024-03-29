﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;
using System.IO;
using FTLTrainer.Data;

namespace FTLTrainer
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public SaveFile SaveFile {get;set;}
        protected int Test { get; set; }
        public Window1()
        {
            SaveFile = new SaveFile();
            Test = 5;
            InitializeComponent();
            DataContext = this;
        }

        private void BrowseClicked(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Save Files|*.sav";
            ofd.DefaultExt = "*.sav";
            ofd.InitialDirectory = "C:\\Users\\bwillard\\Desktop\\ftlSaveFiles";
            ofd.ShowDialog();
            FileLoacation.Text = ofd.FileName;
        }

        private void OpenClicked(object sender, RoutedEventArgs e)
        {
            byte[] data = File.ReadAllBytes(FileLoacation.Text);
            SaveFile.InitFromBytes(data, 0);
        }

        private void SaveClicked(object sender, RoutedEventArgs e)
        {
            if (File.Exists(FileLoacation.Text))
            {
                File.Move(FileLoacation.Text, FileLoacation.Text + ".bak");
            }

            File.WriteAllBytes(FileLoacation.Text, SaveFile.GetBytes());
        }
    }
}
