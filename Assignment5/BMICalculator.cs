using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
 * Version 0.4: Added method to convert text fields to number, and BMI calculation
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
            double height = _convertValues(HeightTextBox.Text);
            double weight = _convertValues(WeightTextBox.Text);
            switch (IsMetric)
            {
                case true:
                    this.Result = weight / (height * height);
                    break;
                case false:
                    this.Result = (weight * 703) / (height * height);
                    break;
            }
            BMIResultsTextBox.Text = Result.ToString();
        }

        private void RadioButton_Click(object sender, EventArgs e)
        {
            this.IsMetric = this.MetricRadioButton.Checked;
        }

        private double _convertValues(string values)
        {
            try
            {
                return Convert.ToDouble(values);
            }
            catch (Exception exception)
            {
                Debug.WriteLine("Oops - Something Went Wrong");
                Debug.WriteLine(exception);
            }
            return 0;
        }
    }
}
