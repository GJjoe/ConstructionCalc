using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace ConstructionCalc
{
    public partial class Form1 : Form
    {
        StringBuilder docString;
        StringBuilder sb;
        string selMaterial;
        double density;
        double overEST;


        public Form1()
        {

            InitializeComponent();
            sb = new StringBuilder();
            docString = new StringBuilder();
           

            matBox.SelectedIndex = 0;
            unitBox.SelectedIndex = 0;
            numericUpDown1.Value = 13;

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sb.Length = 0;
            richTextBox1.Clear();


            //CALCULATE TONS by Density 

            getDensity();

            //sb.AppendLine();
           // sb.AppendLine("Density: " + density.ToString());

            string material = matBox.SelectedItem.ToString();
            sb.AppendLine(material);
            sb.Append("L x W x D = ");
            double length = double.Parse(lenBox.Text);
            sb.Append(length.ToString() + " ft" + " x ");
            double width = double.Parse(widBox.Text);
            sb.Append(" " + length.ToString() + " ft" + " x ");
            


            String unit = unitBox.Text;

            if (unit == "inches")
            {
                double units = double.Parse(depBox.Text) / 12;
                sb.Append(" " + double.Parse(depBox.Text) + " in");
            }

            else
            {
                double units = double.Parse(depBox.Text);
                sb.Append(" " + units.ToString() + " ft");
            }

            sb.Append(" @ Density:  " + density.ToString());

            double area = length * width;
            sb.AppendLine();
            sb.Append("Area: " + area.ToString() + " sqft");

            double depth = double.Parse(depBox.Text) / 12;

            // CALCULATE VOLUME 

            double volume = ((length * width) * depth);
            
            sb.Append(" / Volume: " + volume.ToString()+"^3");

            overEST = 1 + (Convert.ToDouble(numericUpDown2.Value) / 100);

            sb.AppendLine();
            sb.AppendLine("Overestimate % " + numericUpDown2.Value);

            double weight = ((volume / 27) * density) * overEST;

            sb.AppendLine();
            sb.AppendLine("Tons: " + weight.ToString());

            double truckCompacity = Convert.ToDouble(numericUpDown1.Value);
            double loads = weight / truckCompacity;
            sb.AppendLine("Loads: " + loads.ToString());


            richTextBox1.Text = sb.ToString();


            
            //sb.Length = 0;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            
            docString.AppendLine(sb.ToString());
            richTextBox2.Text = docString.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void getDensity()
        {
            selMaterial = matBox.Text;

            if (selMaterial == "Class A")
            {

                density = 1.5;

            }

            else
                MessageBox.Show("No density");
            

        }


    }

   

}
