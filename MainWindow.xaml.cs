﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

// additional references
using Shell32;
using System.Threading;

namespace Desktop_Toggle {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }


        private void button_Click(object sender, RoutedEventArgs e) {
            toggle_desktop_logic();
        }


        private void toggle_desktop_logic() {
            // Create an instance of the shell class
            Shell32.Shell objShel = new Shell32.Shell();

            // Show the desktop
            ((Shell32.IShellDispatch4)objShel).ToggleDesktop();
        }

        private void setTimerButton_Click(object sender, RoutedEventArgs e) {
            delay_toggle();
        }


        private void delay_toggle() {

            // get string from timeTextbox
            string timeString = timeTextbox.Text;
            int time;

            // try to convert the string in timeTextbox to a number
            try {
                time = Int32.Parse(timeString);
            }
            catch (FormatException e) {         // if invalid input (i.e. not numbers)
                statusLabel.Content = "Invalid time entered. Please try again";
                statusLabel.Foreground = Brushes.Red;
                return;
            }

            // if the user selects their units in minutes, multiply it by 60 (to convert to seconds)
            if (minRadio.IsChecked == true) {
                time *= 60;
            }

            // convert seconds to milliseconds
            time *= 1000;

            // wait
            Thread.Sleep(time);

            // call toggle desktop
            toggle_desktop_logic();
        }
    }
}