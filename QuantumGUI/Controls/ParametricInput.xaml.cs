﻿/**
    This file is part of QuIDE.

    QuIDE - The Quantum IDE
    Copyright (C) 2014  Joanna Patrzyk, Bartłomiej Patrzyk

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

using QuIDE.ViewModels;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
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

namespace QuIDE.Controls
{
    /// <summary>
    /// Interaction logic for ParametricInput.xaml
    /// </summary>
    public partial class ParametricInput : UserControl
    {
        public ParametricInput(ParametricInputVM context)
        {
            InitializeComponent();
            DataContext = context;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            methodBox.SelectedIndex = 0;
            Height = ActualHeight;
            Width = ActualWidth;
        }

        private void methodBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ParametricInputVM context = DataContext as ParametricInputVM;
            if (e.AddedItems.Count > 0)
            {
                context.MethodIndex = methodBox.SelectedIndex;
            }
        }

        private void gateBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ParametricInputVM context = DataContext as ParametricInputVM;
            if (e.AddedItems.Count > 0)
            {
                context.GateIndex = gateBox.SelectedIndex;
                context.MethodIndex = 0;
            }
        }

        private void addParam_Click(object sender, RoutedEventArgs e)
        {
            ParametricInputVM context = DataContext as ParametricInputVM;
            context.AddParam();
        }
    }
}
