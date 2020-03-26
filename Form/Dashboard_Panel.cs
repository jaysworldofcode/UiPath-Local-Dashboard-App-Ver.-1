using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using WindowsFormsApp1.Controller;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1
{
    public partial class Dashboard_Panel : Form
    {
        dashboard_controller controller;
        failed_transactions_model model = new failed_transactions_model();
        queue_list_model queue_list_model = new queue_list_model();
        public Dashboard_Panel()
        {
            InitializeComponent();
            controller = new dashboard_controller(this);
            Self_Init();
        }
        void Self_Init()
        {
            attach_model_data();
            SetPieChartData();
            SetGaugeStatus();
            queue_list.SelectedIndexChanged += controller.queue_data_change;
            queue_filter_type.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        void attach_model_data()
        {
            //Queues list attach
            for (int count = 0; count < queue_list_model.GetQueue_name_list().Count; count++)
            {
                queue_list.Items.Add(queue_list_model.GetQueue_name_list()[count]);
            }
            //Failed data attach
            for (int count = 0; count < model.GetTransactionName().Count; count++)
            {
                failed_transactions_list failed_ui = new failed_transactions_list();
                Panel panel = failed_ui.main_panel;
                failed_ui.set_data(model.GetTransactionName()[count]);
                panel.Location = new Point(0, panel.Height * count);
                list_panel.Controls.Add(panel);
                new size_listener(list_panel, panel, panel.Height, 0);
            }
        }
        public void SetGaugeStatus()
        {
            //rotated 90° and has an inverted clockwise fill
            gauge_status_queue_meter.Uses360Mode = true;
            gauge_status_queue_meter.From = 0;
            gauge_status_queue_meter.To = 100;
            gauge_status_queue_meter.Value = 60;
            gauge_status_queue_meter.Base.GaugeRenderTransform = new TransformGroup
            {
                Children = new TransformCollection
                {
                    new RotateTransform(90),
                    new ScaleTransform {ScaleX = -1}
                }
            };
        }
        public void SetPieChartData()
        {
            Func<ChartPoint, string> labelPoint = chartPoint =>
                string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            pieChart1.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "NEW",
                    Values = new ChartValues<double> {3},
                    PushOut = 15,
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "FAIL",
                    Values = new ChartValues<double> {4},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "SUCCESS",
                    Values = new ChartValues<double> {6},
                    Fill = System.Windows.Media.Brushes.LawnGreen,
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "ABANDON",
                    Values = new ChartValues<double> {2},
                    Fill = System.Windows.Media.Brushes.DimGray,
                    DataLabels = true,
                    LabelPoint = labelPoint
                }
            };

            pieChart1.LegendLocation = LegendLocation.Bottom;
        }
    }
}
