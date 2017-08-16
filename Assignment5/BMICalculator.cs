using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Fuad Mannan
 * ID: 300923068
 * Date: August 15, 2017
 * Description: BMI Calculator for assignment 5
 * Version 0.3: Added some private instance variables, public properties, created RadioButton_Click for units
 */

namespace Assignment5
{
    public partial class BMICalculatorForm : Form
    {

        //Private Instance Variables

        private bool _isMetric = false;

        private double _result;


        //Public Properties

        public bool IsMetric
        {
            get { return this._isMetric; }
            set { this._isMetric = value; }
        }

        public double Result
        {
            get { return this._result; }
            set { this._result = value; }
        }

        public BMICalculatorForm()
        {
            InitializeComponent();
        }

        private void UnitsLabel_Click(object sender, EventArgs e)
        {

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {

        }

        private void RadioButton_Click(object sender, EventArgs e)
        {
            IsMetric = MetricRadioButton.Checked;
        }

        
    }
}
