/*

   Copyright 2017 Esri

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.

   See the License for the specific language governing permissions and
   limitations under the License.

*/
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
using System.Windows.Shapes;
using ArcGIS.Desktop.Mapping;
using ArcGIS.Desktop.Mapping.Controls;


namespace MagnifierWindow
{
    /// <summary>
    /// Interaction logic for MapControlWindow.xaml
    /// </summary>
    public partial class MapControlWindow : Window
    {
        internal MapControlWindow_ViewModel viewModel = null;
        internal static MapControl _mapControl = null;
        public MapControlWindow()
        {
            InitializeComponent();
            _mapControl = this.mapControl;
            viewModel = new MapControlWindow_ViewModel();
            viewModel.UpdateMapControlContent();
            DataContext = viewModel;
        }
    }
}
