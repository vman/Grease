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
using System.Windows.Forms;

namespace Grease
{
    public static class KeyCommands
    {
        public static RoutedCommand PlayPauseCommand = new RoutedCommand();
        public static RoutedCommand NextTrackCommand = new RoutedCommand();
        public static RoutedCommand PreviousTrackCommand = new RoutedCommand();
        public static RoutedCommand VolumeDownCommand = new RoutedCommand();
        public static RoutedCommand VolumeUpCommand = new RoutedCommand();
    }
}
