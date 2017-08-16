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
 * Version 0.7: Tried Validation
 */

namespace Assignment5
{
    public partial class BMICalculatorForm : Form
    {

        //Private Instance Variables

        private bool _isMetric = false;

        private double _result;

        private double _height;

        private double _weight;


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

        public double UserHeight
        {
            get { return _convertValues(HeightTextBox.Text); }
            //set { this._height = value; }
        }

        public double UserWeight
        {
            get { return _convertValues(WeightTextBox.Text); }
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
            switch (IsMetric)
            {
                case true:
                    this.Result = UserWeight / (UserHeight * UserHeight);  //Metric BMI calculation
                    break;
                case false:
                    this.Result = (UserWeight * 703) / (UserHeight * UserHeight);   //Imperial BMI calculation
                    break;
            }
            BMIResultsTextBox.Text = Result.ToString();
            string scaleMessage;
            if (this.Result > 0 && this.Result < 18.5)
            {
                scaleMessage = "Underweight - Less than 18.5!";
            }
            else if (this.Result >= 18.5 && this.Result < 25)
            {
                scaleMessage = "Normal - Between 18.5 and 24.9";
            }
            else if (this.Result >= 25 && this.Result < 30)
            {
                scaleMessage = "Overweight - Between 25 and 29.9!";
            }
            else if (this.Result >= 30)
            {
                scaleMessage = "Obese - 30 or greater!";
            }
            else
            {
                scaleMessage = "¿Que?";
            }
            BMIScaleTextBox.Text = scaleMessage;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            HeightTextBox.Text = "";
            WeightTextBox.Text = "";
            BMIResultsTextBox.Text = "";
            BMIScaleTextBox.Text = "";
            
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

        private void TextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
