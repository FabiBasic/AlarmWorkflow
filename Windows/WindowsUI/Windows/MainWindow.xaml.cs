﻿// This file is part of AlarmWorkflow.
// 
// AlarmWorkflow is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// AlarmWorkflow is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with AlarmWorkflow.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using AlarmWorkflow.Windows.UI.ViewModels;
using AlarmWorkflow.Windows.UI.Views;
using AlarmWorkflow.Windows.UIContracts;
using Application = System.Windows.Application;

namespace AlarmWorkflow.Windows.UI.Windows
{
    partial class MainWindow
    {
        #region Constants

        private const double UiScaleChangeFactor = 0.001d;

        #endregion

        #region Fields

        private MainWindowViewModel _viewModel;
        private bool _isFullscreen;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            _viewModel = new MainWindowViewModel(this);
            this.DataContext = _viewModel;

            this.Loaded += Window_Loaded;

            SetWindowPosition();
        }

        #endregion

        #region Methods

        private void SetWindowPosition()
        {
            WindowState = WindowState.Normal;
            WindowStartupLocation = WindowStartupLocation.Manual;
            var pos = Properties.Settings.Default.WindowPosition;
            this.Top = (double)pos.Top;
            this.Left = (double)pos.Left;
            this.Width = (double)pos.Width;
            this.Height = (double)pos.Height;
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Window.Closing"/> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.ComponentModel.CancelEventArgs"/> that contains the event data.</param>
        protected override void OnClosing(CancelEventArgs e)
        {
            SetFullscreen(false);

            if (!UIUtilities.ConfirmMessageBox(MessageBoxImage.Warning, AlarmWorkflow.Windows.UI.Properties.Resources.UIServiceExitWarning))
            {
                e.Cancel = true;
                return;
            }

            SaveWindowPosition();

            base.OnClosing(e);
        }

        private void SaveWindowPosition()
        {
            Rectangle rectangle = Helper.GetWindowRect(this);
            Properties.Settings.Default.WindowPosition = rectangle;
            Properties.Settings.Default.WindowMaximized = this.WindowState == System.Windows.WindowState.Maximized;
        }

        internal void SetFullscreen(bool value)
        {
            if (value != _isFullscreen)
            {
                Application.Current.Dispatcher.Invoke(() => SetFullscreenCore(value));
            }
        }

        private void SetFullscreenCore(bool value)
        {
            Screen screen = Screen.FromRectangle(new Rectangle((int)Left, (int)Top, (int)Width, (int)Height));

            Rectangle rectangle = new Rectangle();
            if (value)
            {
                _isFullscreen = true;

                WindowStyle = WindowStyle.None;
                WindowState = WindowState.Normal;
                rectangle = screen.Bounds;
                ResizeMode = ResizeMode.NoResize;

                //Hiding of Taskbar and Start-Orb only needed on primnary screen
                if (screen.Primary)
                {
                    try
                    {
                        Helper.HideTaskBar();
                        Helper.HideStartOrb();
                    }
                    catch (Exception)
                    {
                        //Sometimes this can throw an error. Maybe because of some usermodifications e.g. "classic shell" on Windows 8.
                    }
                }
            }
            else
            {
                _isFullscreen = false;

                WindowStyle = WindowStyle.SingleBorderWindow;
                WindowState = Properties.Settings.Default.WindowMaximized ? WindowState.Maximized : WindowState.Normal;
                rectangle = screen.WorkingArea;
                ResizeMode = ResizeMode.CanResize;

                //Showing of Taskbar and Start-Orb only needed on primnary screen. The UI shouldn't have moved since hiding them ... otherwise the Start-Orb and Taskbar will be gone.
                if (screen.Primary)
                {
                    try
                    {
                        Helper.ShowStartOrb();
                        Helper.ShowTaskBar();
                    }
                    catch (Exception)
                    {
                        //Sometimes this can throw an error. Maybe because of some usermodifications e.g. "classic shell" on Windows 8.
                    }
                }
            }

            Top = rectangle.Top;
            Left = rectangle.Left;
            Height = rectangle.Height;
            Width = rectangle.Width;

            Focus();
            Activate();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.WindowState = Properties.Settings.Default.WindowMaximized ? WindowState.Maximized : WindowState.Normal;
        }

        private void Window_PreviewMouseWheel(object sender, System.Windows.Input.MouseWheelEventArgs e)
        {
            _viewModel.UiScaleFactor += UiScaleChangeFactor * e.Delta;
        }

        private void Window_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == App.GetApp().Configuration.AcknowledgeOperationKey)
            {
                _viewModel.AcknowledgeCurrentOperation();
                e.Handled = true;
            }
            else if (e.Key == Key.F11)
            {
                SetFullscreen(!_isFullscreen);
                e.Handled = true;
            }
        }

        #endregion
    }
}