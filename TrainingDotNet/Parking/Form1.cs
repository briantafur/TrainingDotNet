﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parking
{
    public partial class Form1 : Form
    {

        private VehicleController control;

        public Form1()
        {
            InitializeComponent();
            control = new VehicleController();
            String time = DateTime.Now.ToString("hh:mm");
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbPlaqueIn.Text))
            {
                String plaque = tbPlaqueIn.Text;
                String inHour = DateTime.Now.ToString();
                Vehicle veh = new Vehicle(plaque, inHour);
                if (control.add(veh))
                {
                    MessageBox.Show("Vehicle succesfull added");
                }
                else
                {
                    if (control.editIngres(veh))
                    {
                        MessageBox.Show("Welcome back");
                    }
                    else
                    {
                        MessageBox.Show("Vehicle already inside");
                    }
                }
            }
            fillTable();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbPlaqueIn.Text))
            {
                String plaque = tbPlaqueIn.Text;
                String outHour = DateTime.Now.ToString();
                Vehicle veh = control.search(plaque);
                if (veh != null)
                {
                    Vehicle aux = new Vehicle(veh.Plate, veh.HourIn);
                    aux.HourOut = outHour;
                    aux.State = "Out";
                    if (control.edit(aux))
                    {
                        tbTimeIn.Text = aux.HourIn;
                        tbTimeOut.Text = aux.HourOut;
                        tbTotalHours.Text = Convert.ToString(control.calculateHours(aux));
                        tbTotal.Text = Convert.ToString(control.calculateTotal(aux));
                        MessageBox.Show("See you next time, thanks for coming");
                        fillTable();
                    }
                    else
                    {
                        MessageBox.Show("nada");
                    }
                }
            }
        }

        private void fillTable()
        {
            dataGridVehicles.RowCount = 1;
            LinkedList<Vehicle> vehicles = control.Vehicles;
            dataGridVehicles.ColumnCount = 0;
            dataGridVehicles.Columns.Add("colPlaque", "Plaque");
            dataGridVehicles.Columns.Add("colState", "State");
            dataGridVehicles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            foreach (Vehicle item in vehicles)
            {
                dataGridVehicles.Rows.Add(new Object[] { item.Plate, item.State });
            }

        }
    }
}
