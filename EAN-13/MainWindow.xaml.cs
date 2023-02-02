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

namespace EAN_13
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dictionary<int, List<int>> dictA = new Dictionary<int, List<int>>(10);
        Dictionary<int, List<int>> dictB = new Dictionary<int, List<int>>(10);
        Dictionary<int, List<int>> dictC = new Dictionary<int, List<int>>(10);
        Dictionary<int, List<string>> numGroup = new Dictionary<int, List<string>>(10);

        public MainWindow()
        {
            InitializeComponent();
            FillDict();
            Load("0000000000000");
        }

        private Rectangle copyRec(Rectangle Rec)
        {
            return new Rectangle()
            {
                Height = Math.Floor(Rec.Height),
                Width = Math.Floor(Rec.Width),
                Margin = new Thickness(Rec.Margin.Left + Rec.Width, 10, 0, 0),
                Fill = System.Windows.Media.Brushes.Black,
                SnapsToDevicePixels = true
            };
        }
        private void FillDict()
        {
            dictA.Add(0, new List<int> { 3, 2, 1, 1 });
            dictA.Add(1, new List<int> { 2, 2, 2, 1 });
            dictA.Add(2, new List<int> { 2, 1, 2, 2 });
            dictA.Add(3, new List<int> { 1, 4, 1, 1 });
            dictA.Add(4, new List<int> { 1, 1, 3, 2 });
            dictA.Add(5, new List<int> { 1, 2, 3, 1 });
            dictA.Add(6, new List<int> { 1, 1, 1, 4 });
            dictA.Add(7, new List<int> { 1, 3, 1, 2 });
            dictA.Add(8, new List<int> { 1, 2, 1, 3 });
            dictA.Add(9, new List<int> { 3, 1, 1, 2 });

            dictB.Add(0, new List<int> { 1, 1, 2, 3 });
            dictB.Add(1, new List<int> { 1, 2, 2, 2 });
            dictB.Add(2, new List<int> { 2, 2, 1, 2 });
            dictB.Add(3, new List<int> { 1, 1, 4, 1 });
            dictB.Add(4, new List<int> { 2, 3, 1, 1 });
            dictB.Add(5, new List<int> { 1, 3, 2, 1 });
            dictB.Add(6, new List<int> { 4, 1, 1, 1 });
            dictB.Add(7, new List<int> { 2, 1, 3, 1 });
            dictB.Add(8, new List<int> { 3, 1, 2, 1 });
            dictB.Add(9, new List<int> { 2, 1, 1, 3 });

            dictC.Add(0, new List<int> { 3, 2, 1, 1 });
            dictC.Add(1, new List<int> { 2, 2, 2, 1 });
            dictC.Add(2, new List<int> { 2, 1, 2, 2 });
            dictC.Add(3, new List<int> { 1, 4, 1, 1 });
            dictC.Add(4, new List<int> { 1, 1, 3, 2 });
            dictC.Add(5, new List<int> { 1, 2, 3, 1 });
            dictC.Add(6, new List<int> { 1, 1, 1, 4 });
            dictC.Add(7, new List<int> { 1, 3, 1, 2 });
            dictC.Add(8, new List<int> { 1, 2, 1, 3 });
            dictC.Add(9, new List<int> { 3, 1, 1, 2 });

            numGroup.Add(0, new List<string> { "A", "A", "A", "A", "A", "A" });
            numGroup.Add(1, new List<string> { "A", "A", "B", "A", "B", "B" });
            numGroup.Add(2, new List<string> { "A", "A", "B", "B", "A", "B" });
            numGroup.Add(3, new List<string> { "A", "A", "B", "B", "B", "A" });
            numGroup.Add(4, new List<string> { "A", "B", "A", "A", "B", "B" });
            numGroup.Add(5, new List<string> { "A", "B", "B", "A", "A", "B" });
            numGroup.Add(6, new List<string> { "A", "B", "B", "B", "A", "A" });
            numGroup.Add(7, new List<string> { "A", "B", "A", "B", "A", "B" });
            numGroup.Add(8, new List<string> { "A", "B", "A", "B", "B", "A" });
            numGroup.Add(9, new List<string> { "A", "B", "B", "A", "B", "A" });
        }

        public void Load(string num)
        {
            barcodeCan.Children.RemoveRange(0, barcodeCan.Children.Count - 1);
            char[] nums = num.Replace("", "").Replace("", "").ToArray<char>();
            List<string> numGroupNum = numGroup[Convert.ToInt32(nums[0]) - 48];

            Rectangle rect = new Rectangle()
            {
                Height = 222.0,
                Width = 4.0,
                Margin = new Thickness(30, 10, 0, 0),
                Fill = System.Windows.Media.Brushes.Black,
                SnapsToDevicePixels = true

            };

            Rectangle rect2 = new Rectangle()
            {
                Height = 222.0,
                Width = 2.0,
                Margin = new Thickness(33, 10, 0, 0),
                Fill = System.Windows.Media.Brushes.White,
                SnapsToDevicePixels = true

            };

            Rectangle rect1_2 = new Rectangle()
            {
                Height = 222.0,
                Width = 4.0,
                Margin = new Thickness(36, 10, 0, 0),
                Fill = System.Windows.Media.Brushes.White,
                SnapsToDevicePixels = true

            };

            Label lb1 = new Label()
            {
                Content = nums[0],
                FontSize = 24,
                FontWeight = FontWeights.Bold,
                Margin = new Thickness(8, 207, 0, 0)
            };

            barcodeCan.Children.Add(lb1);
            barcodeCan.Children.Add(rect);
            barcodeCan.Children.Add(rect2);
            barcodeCan.Children.Add(rect1_2);



            Rectangle localRec = rect1_2;
            for (int i = 1; i < 6; i++)
            {
                Rectangle rec1 = new Rectangle()
                {
                    Height = 207.0,
                    Width = (numGroupNum[1] == "A" ? dictA[Convert.ToInt32(nums[i + 1]) - 48][0] : 3.0 * dictB[Convert.ToInt32(nums[i + 1]) - 48][0]],
                    Margin = new Thickness(localRec.Margin.Left + localRec.Width, 10, 0, 0),
                    Fill = System.Windows.Media.Brushes.White,
                    SnapsToDevicePixels = true
                };
            }
        }

        private void txtBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                Load(txtBox.Text);
            }

            catch
            {
            }

        }
    }
}   

