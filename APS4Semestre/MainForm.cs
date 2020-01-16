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

namespace APS4Semestre
{
    public partial class MainForm : Form
    {

        Stopwatch stopWatch = new Stopwatch();
        Control control = new Control();
        int[] vector1 = new int[500000];
        int[] vector2 = new int[500000];
        int[] vector3 = new int[500000];
        int[] vector4 = new int[500000];
        int[] vector5 = new int[500000];
        int[] vector6 = new int[500000];
        int[] vector7 = new int[500000];
        int[] vector8 = new int[500000];
        int[] vector9 = new int[500000];
        int[] vector10 = new int[500000];

        public MainForm()
        {
            InitializeComponent();
            control.VectorFill(vector1);
            vector2 = vector1;
            vector3 = vector1;
            vector4 = vector1;
            vector5 = vector1;
            vector6 = vector1;
            vector7 = vector1;
            vector8 = vector1;
            vector9 = vector1;
            vector10 = vector1;
        }

        private void limpar()
        {
            time.Text = "";
        }

        private void btnInsertionSort_Click(object sender, EventArgs e)
        {
            this.limpar();
            stopWatch.Start();
            control.insertionSort(vector1);
            stopWatch.Stop();

            method.Text = "Insertion Sort";
            time.Text = $"Time: {stopWatch.Elapsed}";
            stopWatch.Reset();
        }

        private void btnShellSort_Click(object sender, EventArgs e)
        {
            this.limpar();
            stopWatch.Start();
            control.shellSort(vector2);
            stopWatch.Stop();

            method.Text = "Shell Sort";
            time.Text = $"Time: {stopWatch.Elapsed}";
            stopWatch.Reset();
        }

        private void btnSelectionSort_Click(object sender, EventArgs e)
        {
            this.limpar();
            stopWatch.Start();
            control.selectionSort(vector3);
            stopWatch.Stop();

            method.Text = "Selection Sort";
            time.Text = $"Time: {stopWatch.Elapsed}";
            stopWatch.Reset();
        }

        private void btnHeapSort_Click(object sender, EventArgs e)
        {
            this.limpar();
            stopWatch.Start();
            control.heapSort(vector4);
            stopWatch.Stop();

            method.Text = "Heap Sort";
            time.Text = $"Time: {stopWatch.Elapsed}";
            stopWatch.Reset();
        }

        private void btnBubbleSort_Click(object sender, EventArgs e)
        {
            this.limpar();
            stopWatch.Start();
            control.bubbleSort(vector5);
            stopWatch.Stop();

            method.Text = "Bubble Sort";
            time.Text = $"Time: {stopWatch.Elapsed}";
            stopWatch.Reset();
        }

        private void btnCocktails_Click(object sender, EventArgs e)
        {
            this.limpar();
            stopWatch.Start();
            control.cocktailSort(vector6);
            stopWatch.Stop();

            method.Text = "Cocktails";
            time.Text = $"Time: {stopWatch.Elapsed}";
            stopWatch.Reset();
        }

        private void btnCombSort_Click(object sender, EventArgs e)
        {
            this.limpar();
            stopWatch.Start();
            control.combSort(vector7);
            stopWatch.Stop();

            method.Text = "Comb Sort";
            time.Text = $"Time: {stopWatch.Elapsed}";
            stopWatch.Reset();
        }

        private void btnGnomeSort_Click(object sender, EventArgs e)
        {
            this.limpar();
            stopWatch.Start();
            control.gnomeSort(vector8);
            stopWatch.Stop();

            method.Text = "Gnome Sort";
            time.Text = $"Time: {stopWatch.Elapsed}";
            stopWatch.Reset();
        }

        private void btnOddEvenSort_Click(object sender, EventArgs e)
        {
            this.limpar();
            stopWatch.Start();
            control.oddEvenSort(vector9);
            stopWatch.Stop();

            method.Text = "Odd-Even Sort";
            time.Text = $"Time: {stopWatch.Elapsed}";
            stopWatch.Reset();
        }

        private void btnQuickSort_Click(object sender, EventArgs e)
        {
            this.limpar();
            stopWatch.Start();
            control.quickSort(vector10);
            stopWatch.Stop();

            method.Text = "Quick Sort";
            time.Text = $"Time: {stopWatch.Elapsed}";
            stopWatch.Reset();
        }
    }
}
