using System;
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
        private AllInputSources lastInput;

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
        
        
        /// <summary>
        /// Logic for setting desktop toggle delay
        /// </summary>
        private void delay_toggle() {

            // get string from timeTextbox
            string timeString = timeTextbox.Text;
            int time;

            // try to convert the string in timeTextbox to a number
            try {
                time = Int32.Parse(timeString);
            }
            catch (FormatException e) {         // if invalid input (i.e. not numbers), display the error
                statusLabel.Content = "Invalid time entered. Please try again";
                statusLabel.Foreground = Brushes.Red;
                return;
            }

            // if the user selects their units in minutes, multiply it by 60 (to convert to seconds)
            if (minRadio.IsChecked == true) 
                time *= 60;            

            // convert seconds to milliseconds
            time *= 1000;

            // Create an instance of the shell class
            Shell32.Shell objShel = new Shell32.Shell();

            // create a separate thread for delay
            Thread beginDelay = new Thread( () => delay(time, objShel) );
            beginDelay.Start();

            // update status
            statusLabel.Content = "Timer set.";
            statusLabel.Foreground = Brushes.Green;
        }


        /// <summary>
        /// Toggle desktop after x milliseconds of delay
        /// </summary>
        /// <param name="time">time delay, in milliseconds</param>
        /// <param name="objShel">instance of shell that will perform the desktop toggle</param>
        private void delay(int time, Shell32.Shell objShel) {
            
            // initialize class AllInputSources, which contains methods for getting time since last input
            lastInput = new AllInputSources();

            // check if time-since-lastInput is greater than the specified time delay; continuously check if not
            while (lastInput.getDiffMilliseconds(lastInput.GetLastInputTime()) <= time) {
                // wait 1 second before polling again
                Thread.Sleep(1000);
            }            

            // Show the desktop
            ((Shell32.IShellDispatch4)objShel).ToggleDesktop();
        }
    }
}
