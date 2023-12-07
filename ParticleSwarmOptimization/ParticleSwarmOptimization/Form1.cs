using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParticleSwarmOptimization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
            ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            InitializeComponent();
            NumParticlesInp.Text = "30";
            MaxIterationsInp.Text = "1000";
            cogCompInp.Text = "4";
            socCompInp.Text = "4";
            lowerBoundInp.Text = "-10 -10 -10";
            upperBoundInp.Text = "10 10 10";
        }
        PSO pso = new PSO();
        int NumParticles = 0;
        int depend = 0;
        const int dimension = 3;
        int MaxIterations = 100;
        private double cogComp = 2.0; // Коэффициент когнитивной компоненты
        private double socComp = 2.0; // Коэффициент социальной компоненты
        int function = 0;
        double[] lowerBound = new double[dimension];
        double[] upperBound = new double[dimension];


        private void Form1_Load(object sender, EventArgs e) {}

        private void label1_Click(object sender, EventArgs e){}

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String functionStr = comboBox1.SelectedItem.ToString();
            if (functionStr == "f(x) = (x-3)^2") 
                function = 1;
            else
            {
                if (functionStr == "f(x,y) = (y-x^2)^2+(1-x)^2")
                    function = 2;
                else function = 3;
            }
        }

        private void label5_Click(object sender, EventArgs e) {}

        private void NumParticlesInp_TextChanged(object sender, EventArgs e)
        {
            NumParticles = Convert.ToInt32(NumParticlesInp.Text);
        }

        private void MaxIterationsInp_TextChanged(object sender, EventArgs e)
        {
            MaxIterations = Convert.ToInt32(MaxIterationsInp.Text);
        }

        private void cogCompInp_TextChanged(object sender, EventArgs e)
        {
            cogComp = Convert.ToDouble(cogCompInp.Text);
        }

        private void socCompInp_TextChanged(object sender, EventArgs e)
        {
            socComp = Convert.ToDouble(socCompInp.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (function)
            {
                case 1:
                    {
                        depend = 1;
                        break;
                    }
                case 2:
                    {
                        depend = 2;
                        break;
                    }
                default:
                    {
                        depend = 3;
                        break;
                    }
            }
            String[] text = (upperBoundInp.Text).Split(' ');
            for (int i = 0;i<dimension;i++)
                upperBound[i] = double.Parse(text[i]);
            text = (lowerBoundInp.Text).Split(' ');
            for (int i = 0; i < dimension; i++)
                lowerBound[i] = double.Parse(text[i]);
            pso.InitializeSwarm(NumParticles, function, upperBound, lowerBound, depend);
            double[] result = pso.RunOptimization(MaxIterations, cogComp, socComp, function, upperBound, lowerBound, depend);
            String textLabel = "";
            for (int i = 0; i < depend; i++)
            {
                textLabel += Convert.ToString(result[i]) +"\n";
            }
            label7.Text = textLabel;
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void coordinatesInp_TextChanged(object sender, EventArgs e)
        {}

        private void coordinateY_TextChanged(object sender, EventArgs e){}


    }
}
