﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFGameApp1.PresentationLayer
{
    /// <summary>
    /// Interaction logic for Combat.xaml
    /// </summary>
    public partial class GameSessionView : Window
    {
        public GameSessionView(GameSessionViewModel gameSessionViewModel)
        {
            InitializeComponent();
        }
    }
}
